using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankingsys
{
    public partial class AddBranch : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public AddBranch()
        {
            InitializeComponent();
            DisplayBranchesInDataGridView();
        }

        public void RefreshControl()
        {
            DisplayBranchesInDataGridView();
        }

        public void DisplayBranchesInDataGridView()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM branch", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    // Clear existing columns
                    Branches.Columns.Clear();

                    // Manually add columns
                    DataGridViewTextBoxColumn bidColumn = new DataGridViewTextBoxColumn();
                    bidColumn.DataPropertyName = "bid";  // Replace with the actual column name
                    bidColumn.HeaderText = "Branch ID";
                    Branches.Columns.Add(bidColumn);

                    DataGridViewTextBoxColumn bnameColumn = new DataGridViewTextBoxColumn();
                    bnameColumn.DataPropertyName = "bname";  // Replace with the actual column name
                    bnameColumn.HeaderText = "Name";
                    Branches.Columns.Add(bnameColumn);

                    DataGridViewTextBoxColumn bcityColumn = new DataGridViewTextBoxColumn();
                    bcityColumn.DataPropertyName = "bcity";  // Replace with the actual column name
                    bcityColumn.HeaderText = "City";
                    Branches.Columns.Add(bcityColumn);



                    // Add other columns as needed...

                    // Set DataSource
                    Branches.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetSelectedBranchId()
        {
            if (Branches != null && Branches.SelectedRows.Count > 0)
            {
                int bidIndex = 0;

                // Check if the column index is valid
                if (bidIndex >= 0 && bidIndex < Branches.SelectedRows[0].Cells.Count)
                {
                    DataGridViewRow selectedRow = Branches.SelectedRows[0];

                    // Check if the cell value is not null before accessing it
                    if (selectedRow.Cells[bidIndex].Value != null)
                    {
                        return selectedRow.Cells[bidIndex].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("The selected branch number is null.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The column index for 'bid' is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No branch is selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        private void branch_Clear_Click(object sender, EventArgs e)
        {
            branch_name.Clear();
            branch_city.Clear();
        }

        private void Branch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = Branches.Rows[e.RowIndex];

                    int BranchNameIndex = 1;  // Assuming this is the index for the account number column
                    int BranchCityIndex = 2;  // Assuming this is the index for the loan amount column

                    // Check if the cell value is not null before accessing it
                    branch_name.Text = row.Cells[BranchNameIndex].Value?.ToString() ?? string.Empty;
                    branch_city.Text = row.Cells[BranchCityIndex].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void branch_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    // Get values from the UI controls
                    string bname = branch_name.Text;
                    string bcity = branch_city.Text;

                    // Check for empty or null values
                    if (string.IsNullOrEmpty(bname) || string.IsNullOrEmpty(bcity))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                    // Check if the branch name already exists
                    if (IsSameBranchName(conn, bname))
                    {
                        MessageBox.Show("Branch with the same name already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if the branch name already exists
                    }

                    // Generate the next branch ID
                    string nextBranchId = GenerateNextBranchId(conn);

                    // Insert data into the branch table using the InsertBranch stored procedure
                    InsertBranch(conn, nextBranchId, bname, bcity);

                    MessageBox.Show("Branch added successfully with ID: " + nextBranchId);

                    DisplayBranchesInDataGridView();

                    branch_name.Clear();
                    branch_city.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GenerateNextBranchId(SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand("EXEC GenerateNextBranchId", connection))
            {
                SqlParameter outputParameter = new SqlParameter
                {
                    ParameterName = "@NextBranchId",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 6,
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputParameter);

                cmd.ExecuteNonQuery();

                return outputParameter.Value.ToString(); // Return the generated branch ID
            }
        }

        private void InsertBranch(SqlConnection connection, string bid, string bname, string bcity)
        {
            using (SqlCommand insertCommand = new SqlCommand("EXEC InsertBranch @bid, @bname, @bcity", connection))
            {
                insertCommand.Parameters.AddWithValue("@bid", bid);
                insertCommand.Parameters.AddWithValue("@bname", bname);
                insertCommand.Parameters.AddWithValue("@bcity", bcity);

                insertCommand.ExecuteNonQuery();
            }
        }

        private bool IsSameBranchName(SqlConnection connection, string branchname)
        {
            bool isConnectionOpen = connection.State == ConnectionState.Open;

            try
            {
                if (!isConnectionOpen)
                {
                    connection.Open();
                }

                using (SqlCommand checkCmd = new SqlCommand("SELECT dbo.CheckBranchExistence(@bname)", connection))
                {
                    checkCmd.Parameters.AddWithValue("@bname", branchname);

                    return (bool)checkCmd.ExecuteScalar();
                }
            }
            finally
            {
                if (!isConnectionOpen)
                {
                    connection.Close();
                }
            }
        }

        private void RemoveSelectedRow()
        {
            if (Branches.SelectedRows.Count > 0)
            {
                int selectedIndex = Branches.SelectedRows[0].Index;
                Branches.Rows.RemoveAt(selectedIndex);
            }
        }

        private void branch_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    // Get the selected customer ID
                    string selectedBranchId = GetSelectedBranchId();

                    // Check if a customer is selected
                    if (selectedBranchId != null)
                    {
                        // Get values from the UI controls
                        string bname = branch_name.Text;
                        string bcity = branch_city.Text;

                        // Check for empty or null values
                        if (string.IsNullOrEmpty(bname) || string.IsNullOrEmpty(bcity))
                        {
                            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Check if the phone number is being changed
                        if (IsSameBranchName(conn, bname))
                        {
                            MessageBox.Show("Branch with the same name already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Call the UpdateCustomer stored procedure
                        using (SqlCommand updateCommand = new SqlCommand("UpdateBranch", conn))
                        {
                            updateCommand.CommandType = CommandType.StoredProcedure;

                            updateCommand.Parameters.AddWithValue("@bid", selectedBranchId);
                            updateCommand.Parameters.AddWithValue("@bname", bname);
                            updateCommand.Parameters.AddWithValue("@bcity", bcity);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Branch updated successfully.");

                            DisplayBranchesInDataGridView();

                            branch_name.Clear();
                            branch_city.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a branch to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Unique constraint violation (duplicate entry)
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("A branch with the same branch name already exists.", "Duplicate Branch Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void branch_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    // Get the selected branch ID
                    string selectedBranchId = GetSelectedBranchId();

                    // Check if a branch is selected
                    if (selectedBranchId != null)
                    {
                        // Call the CloseBranch stored procedure
                        using (SqlCommand deleteBranchCommand = new SqlCommand("CloseBranch", conn))
                        {
                            deleteBranchCommand.CommandType = CommandType.StoredProcedure;
                            deleteBranchCommand.Parameters.AddWithValue("@branchIdToDelete", selectedBranchId);

                            deleteBranchCommand.ExecuteNonQuery();

                            MessageBox.Show("Branch closed successfully.");

                            // Refresh your branch list or perform any other necessary actions
                            DisplayBranchesInDataGridView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a branch to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

