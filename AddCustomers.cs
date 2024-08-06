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
    public partial class AddCustomers : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public AddCustomers()
        {
            InitializeComponent();
            DisplayCustomersInDataGridView();
        }

        public void RefreshControl()
        {
            DisplayCustomersInDataGridView();
        }

        private void DisplayCustomersInDataGridView()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM customer", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    // Clear existing columns
                    Customers.Columns.Clear();

                    // Manually add columns
                    DataGridViewTextBoxColumn custIdColumn = new DataGridViewTextBoxColumn();
                    custIdColumn.DataPropertyName = "custid";  // Replace with the actual column name
                    custIdColumn.HeaderText = "Customer ID";
                    Customers.Columns.Add(custIdColumn);

                    DataGridViewTextBoxColumn fnameColumn = new DataGridViewTextBoxColumn();
                    fnameColumn.DataPropertyName = "fname";  // Replace with the actual column name
                    fnameColumn.HeaderText = "First Name";
                    Customers.Columns.Add(fnameColumn);

                    DataGridViewTextBoxColumn mnameColumn = new DataGridViewTextBoxColumn();
                    mnameColumn.DataPropertyName = "mname";  // Replace with the actual column name
                    mnameColumn.HeaderText = "Middle Name";
                    Customers.Columns.Add(mnameColumn);

                    DataGridViewTextBoxColumn lnameColumn = new DataGridViewTextBoxColumn();
                    lnameColumn.DataPropertyName = "ltname";  // Replace with the actual column name
                    lnameColumn.HeaderText = "Last Name";
                    Customers.Columns.Add(lnameColumn);

                    DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn();
                    cityColumn.DataPropertyName = "city";  // Replace with the actual column name
                    cityColumn.HeaderText = "City";
                    Customers.Columns.Add(cityColumn);

                    DataGridViewTextBoxColumn MobileNoColumn = new DataGridViewTextBoxColumn();
                    MobileNoColumn.DataPropertyName = "MobileNo";  // Replace with the actual column name
                    MobileNoColumn.HeaderText = "MobileNo";
                    Customers.Columns.Add(MobileNoColumn);

                    DataGridViewTextBoxColumn OccupationColumn = new DataGridViewTextBoxColumn();
                    OccupationColumn.DataPropertyName = "Occupation";  // Replace with the actual column name
                    OccupationColumn.HeaderText = "Occupation";
                    Customers.Columns.Add(OccupationColumn);

                    DataGridViewTextBoxColumn bdateColumn = new DataGridViewTextBoxColumn();
                    bdateColumn.DataPropertyName = "bdate";  // Replace with the actual column name
                    bdateColumn.HeaderText = "Birthdate";
                    Customers.Columns.Add(bdateColumn);

                    // Add other columns as needed...

                    // Set DataSource
                    Customers.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    // Get values from the UI controls
                    string fname = customer_fname.Text;
                    string mname = customer_mname.Text;
                    string lname = customer_lname.Text;
                    string city = customer_city.Text;
                    string mobileno = customer_mobileno.Text;
                    string occupation = customer_occupation.Text;
                    DateTime bdate = customer_bdate.Value;

                    // Check for empty or null values
                    if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(mobileno) || string.IsNullOrEmpty(occupation))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the phone number already exists
                    if (IsSamePhoneNumber(conn, mobileno))
                    {
                        MessageBox.Show("Customer with the same phone number already exists.", "Duplicate Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the phone number already exists
                    }

                    using (SqlCommand cmd = new SqlCommand("EXEC GenerateNextCustomerId", conn))
                    {
                        SqlParameter outputParameter = new SqlParameter();
                        outputParameter.ParameterName = "@nextCustomerId";
                        outputParameter.SqlDbType = SqlDbType.VarChar;
                        outputParameter.Size = 6;
                        outputParameter.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(outputParameter);

                        cmd.ExecuteNonQuery();

                        string nextCustomerId = outputParameter.Value.ToString();

                        // Insert data into the customer table using the InsertCustomer stored procedure
                        using (SqlCommand insertCommand = new SqlCommand("EXEC InsertCustomer @custid, @fname, @mname, @ltname, @city, @mobileno, @occupation, @bdate", conn))
                        {
                            insertCommand.Parameters.AddWithValue("@custid", nextCustomerId);
                            insertCommand.Parameters.AddWithValue("@fname", fname);
                            insertCommand.Parameters.AddWithValue("@mname", mname);
                            insertCommand.Parameters.AddWithValue("@ltname", lname);
                            insertCommand.Parameters.AddWithValue("@city", city);
                            insertCommand.Parameters.AddWithValue("@mobileno", mobileno);
                            insertCommand.Parameters.AddWithValue("@occupation", occupation);
                            insertCommand.Parameters.AddWithValue("@bdate", bdate);

                            insertCommand.ExecuteNonQuery();

                            MessageBox.Show("Customer added successfully with ID: " + nextCustomerId, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DisplayCustomersInDataGridView();

                            customer_fname.Clear();
                            customer_mname.Clear();
                            customer_lname.Clear();
                            customer_city.Clear();
                            customer_mobileno.Clear();
                            customer_occupation.Clear();
                            customer_bdate.Value = DateTime.Now;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool IsSamePhoneNumber(SqlConnection connection, string mobileno)
        {
            bool isConnectionOpen = connection.State == ConnectionState.Open;

            try
            {
                if (!isConnectionOpen)
                {
                    connection.Open();
                }

                using (SqlCommand checkCmd = new SqlCommand("SELECT dbo.CheckPhoneNumberExists2(@mobileno)", connection))
                {
                    checkCmd.Parameters.AddWithValue("@mobileno", mobileno);

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






        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            customer_fname.Clear();
            customer_mname.Clear();
            customer_lname.Clear();
            customer_city.Clear();
            customer_mobileno.Clear();
            customer_occupation.Clear();
            customer_bdate.Value = DateTime.Now;
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    // Get the selected customer ID
                    string selectedCustomerId = GetSelectedCustomerId();

                    // Check if a customer is selected
                    if (selectedCustomerId != null)
                    {
                        // Get values from the UI controls
                        string fname = customer_fname.Text;
                        string mname = customer_mname.Text;
                        string lname = customer_lname.Text;
                        string city = customer_city.Text;
                        string mobileno = customer_mobileno.Text;
                        string occupation = customer_occupation.Text;
                        DateTime bdate = customer_bdate.Value;

                        // Check for empty or null values
                        if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(mobileno) || string.IsNullOrEmpty(occupation))
                        {
                            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Check if the phone number is being changed

                        // Call the UpdateCustomer stored procedure
                        using (SqlCommand updateCommand = new SqlCommand("UpdateCustomer", conn))
                        {
                            updateCommand.CommandType = CommandType.StoredProcedure;

                            updateCommand.Parameters.AddWithValue("@custid", selectedCustomerId);
                            updateCommand.Parameters.AddWithValue("@fname", fname);
                            updateCommand.Parameters.AddWithValue("@mname", mname);
                            updateCommand.Parameters.AddWithValue("@ltname", lname);
                            updateCommand.Parameters.AddWithValue("@city", city);
                            updateCommand.Parameters.AddWithValue("@mobileno", mobileno);
                            updateCommand.Parameters.AddWithValue("@occupation", occupation);
                            updateCommand.Parameters.AddWithValue("@bdate", bdate);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Customer updated successfully.");

                            DisplayCustomersInDataGridView();

                            customer_fname.Clear();
                            customer_mname.Clear();
                            customer_lname.Clear();
                            customer_city.Clear();
                            customer_mobileno.Clear();
                            customer_occupation.Clear();
                            customer_bdate.Value = DateTime.Now;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a customer to update.");
                    }
                }
            }
            catch (SqlException ex)
            {
                // Unique constraint violation (duplicate entry)
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("A customer with the same phone number already exists.", "Duplicate Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetSelectedCustomerId()
        {
            if (Customers != null && Customers.SelectedRows.Count > 0)
            {
                int custIdIndex = 0; // Assuming "custid" is the first column

                // Check if the column index is valid
                if (custIdIndex >= 0 && custIdIndex < Customers.SelectedRows[0].Cells.Count)
                {
                    DataGridViewRow selectedRow = Customers.SelectedRows[0];

                    // Check if the cell value is not null before accessing it
                    if (selectedRow.Cells[custIdIndex].Value != null)
                    {
                        return selectedRow.Cells[custIdIndex].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("The selected customer ID is null.", "Null Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The column index for 'custid' is invalid.", "Invalid Index", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No customer is selected.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   

            return null;
        }






        private void Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = Customers.Rows[e.RowIndex];

                    // Check column indices and handle DBNull
                    int fnameIndex = 1;
                    int mnameIndex = 2;
                    int lnameIndex = 3;
                    int cityIndex = 4;
                    int mobileNoIndex = 5;
                    int occupationIndex = 6;
                    int bdateIndex = 7;

                    // Check if the cell value is not null before accessing it
                    customer_fname.Text = Convert.IsDBNull(row.Cells[fnameIndex].Value) ? string.Empty : row.Cells[fnameIndex].Value.ToString();
                    customer_mname.Text = Convert.IsDBNull(row.Cells[mnameIndex].Value) ? string.Empty : row.Cells[mnameIndex].Value.ToString();
                    customer_lname.Text = Convert.IsDBNull(row.Cells[lnameIndex].Value) ? string.Empty : row.Cells[lnameIndex].Value.ToString();
                    customer_city.Text = Convert.IsDBNull(row.Cells[cityIndex].Value) ? string.Empty : row.Cells[cityIndex].Value.ToString();
                    customer_mobileno.Text = Convert.IsDBNull(row.Cells[mobileNoIndex].Value) ? string.Empty : row.Cells[mobileNoIndex].Value.ToString();
                    customer_occupation.Text = Convert.IsDBNull(row.Cells[occupationIndex].Value) ? string.Empty : row.Cells[occupationIndex].Value.ToString();

                    if (!Convert.IsDBNull(row.Cells[bdateIndex].Value) && DateTime.TryParse(row.Cells[bdateIndex].Value.ToString(), out DateTime bdate))
                    {
                        customer_bdate.Value = bdate;
                    }
                    else
                    {
                        // Handle the case where the value cannot be parsed to DateTime
                        MessageBox.Show("Invalid date format in the selected row.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected customer ID
                string selectedCustomerId = GetSelectedCustomerId();

                // Check if a customer is selected
                if (selectedCustomerId != null)
                {
                    // Call the stored procedure to delete the customer
                    using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                    {
                        conn.Open();

                        using (SqlCommand deleteCommand = new SqlCommand("DeleteCustomer", conn))
                        {
                            deleteCommand.CommandType = CommandType.StoredProcedure;
                            deleteCommand.Parameters.AddWithValue("@custid", selectedCustomerId);

                            deleteCommand.ExecuteNonQuery();

                            MessageBox.Show("Customer deleted successfully.");

                            // Remove the selected row from the DataGridView
                            RemoveSelectedRow();

                            // Refresh the customer table (optional)
                            DisplayCustomersInDataGridView();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void RemoveSelectedRow()
        {
            if (Customers.SelectedRows.Count > 0)
            {
                int selectedIndex = Customers.SelectedRows[0].Index;
                Customers.Rows.RemoveAt(selectedIndex);
            }
        }


    }
}
