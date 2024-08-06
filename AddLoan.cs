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
    public partial class AddLoan : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public AddLoan()
        {
            InitializeComponent();
            PopulateLoanAccountIDsComboBox();
            DisplayLoansInDataGridView();
        }

        public void RefreshControl()
        {

            PopulateLoanAccountIDsComboBox();
            DisplayLoansInDataGridView();

        }


        private void PopulateLoanAccountIDsComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT acnumber FROM account WHERE atype = 'Loan'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            loan_accId.Items.Clear();

                            // Add each custID to the ComboBox
                            while (reader.Read())
                            {
                                string acnumber = reader["acnumber"].ToString();
                                loan_accId.Items.Add(acnumber);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DisplayLoansInDataGridView()
        {
            try
            {   
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM loan WHERE loan_amount >= 0", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    // Clear existing columns
                    Loans.Columns.Clear();

                    // Manually add columns
                    DataGridViewTextBoxColumn acNumberColumn = new DataGridViewTextBoxColumn();
                    acNumberColumn.DataPropertyName = "acnumber";  // Replace with the actual column name
                    acNumberColumn.HeaderText = "A. Number";
                    Loans.Columns.Add(acNumberColumn);

                    DataGridViewTextBoxColumn loan_table_amount = new DataGridViewTextBoxColumn();
                    loan_table_amount.DataPropertyName = "loan_amount";  // Replace with the actual column name
                    loan_table_amount.HeaderText = "Amount";
                    Loans.Columns.Add(loan_table_amount);



                    // Add other columns as needed...

                    // Set DataSource
                    Loans.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetSelectedAccountId()
        {
            if (Loans != null && Loans.SelectedRows.Count > 0)
            {
                int accIdIndex = 0;

                // Check if the column index is valid
                if (accIdIndex >= 0 && accIdIndex < Loans.SelectedRows[0].Cells.Count)
                {
                    DataGridViewRow selectedRow = Loans.SelectedRows[0];

                    // Check if the cell value is not null before accessing it
                    if (selectedRow.Cells[accIdIndex].Value != null)
                    {
                        return selectedRow.Cells[accIdIndex].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("The selected account number is null.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The column index for 'acnumber' is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No account is selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        private void loan_Clear_Click(object sender, EventArgs e)
        {
            loan_accId.Text = "";
            loan_amount.Clear();
        }
        private void Loans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = Loans.Rows[e.RowIndex];

                    int AccountNumIndex = 0;  // Assuming this is the index for the account number column
                    int LoanAmountIndex = 1;  // Assuming this is the index for the loan amount column

                    // Check if the cell value is not null before accessing it
                    loan_accId.Text = row.Cells[AccountNumIndex].Value?.ToString() ?? string.Empty;
                    loan_amount.Text = row.Cells[LoanAmountIndex].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private bool CheckLoanExists(SqlConnection connection, string accountID)
        {
            bool isConnectionOpen = connection.State == ConnectionState.Open;

            try
            {
                if (!isConnectionOpen)
                {
                    connection.Open();
                }

                using (SqlCommand checkCmd = new SqlCommand("SELECT dbo.CheckLoanExistence(@accountID)", connection))
                {
                    checkCmd.Parameters.AddWithValue("@accountID", accountID);

                    bool loanExists = (bool)checkCmd.ExecuteScalar();

                    return loanExists;
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
        private void loan_Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string loan_accID = loan_accId.Text;
                    string loan_amounts = loan_amount.Text;

                    // Check if either textbox is empty
                    if (string.IsNullOrEmpty(loan_accID) || string.IsNullOrEmpty(loan_amounts))
                    {
                        MessageBox.Show("Please enter values for both Account ID and Loan Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (CheckLoanExists(connection, loan_accID))
                    {
                        MessageBox.Show("Loan already exists for the specified account ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand command = new SqlCommand("InsertLoan", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@accountID", loan_accID);
                        command.Parameters.AddWithValue("@loanAmount", loan_amounts);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Loan added successfully.");

                    DisplayLoansInDataGridView(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding loan: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void RemoveSelectedRow()
        {
            if (Loans.SelectedRows.Count > 0)
            {
                int selectedIndex = Loans.SelectedRows[0].Index;
                Loans.Rows.RemoveAt(selectedIndex);
            }
        }

        private void loan_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if loan_accId and loan_amount textboxes are empty
                if (string.IsNullOrEmpty(loan_accId.Text) || string.IsNullOrEmpty(loan_amount.Text))
                {
                    MessageBox.Show("Please enter values for both Account ID and Loan Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    // Get the selected account ID
                    string selectedAccountId = GetSelectedAccountId();

                    // Check if an account is selected
                    if (selectedAccountId != null)
                    {
                        // Get the new account ID and loan amount
                        string newAccountId = loan_accId.Text;
                        string newLoanAmount = loan_amount.Text; // Assuming loan_amount is a string, adjust data type if needed

                        // Call the UpdateLoan stored procedure
                        using (SqlCommand updateCommand = new SqlCommand("UpdateLoan", conn))
                        {
                            updateCommand.CommandType = CommandType.StoredProcedure;

                            updateCommand.Parameters.AddWithValue("@acnumber", selectedAccountId);
                            updateCommand.Parameters.AddWithValue("@newLoanAmount", newLoanAmount);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Loan updated successfully.");

                            DisplayLoansInDataGridView();

                            loan_accId.Text = "";
                            loan_amount.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a loan to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void loan_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected account ID
                string selectedAccountId = GetSelectedAccountId();

                // Check if an account is selected
                if (selectedAccountId != null)
                {
                    using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                    {
                        conn.Open();

                        // Call the stored procedure to delete the account
                        using (SqlCommand deleteCommand = new SqlCommand("DeleteLoan", conn))
                        {
                            deleteCommand.CommandType = CommandType.StoredProcedure;
                            deleteCommand.Parameters.AddWithValue("@acnumber", selectedAccountId);

                            deleteCommand.ExecuteNonQuery();

                            MessageBox.Show("Loan deleted successfully.");

                            // Remove the selected row from the DataGridView
                            RemoveSelectedRow();

                            // Refresh the account table (optional)
                            DisplayLoansInDataGridView();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }

