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
    public partial class AddAccounts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");

        public AddAccounts()
        {
            InitializeComponent();
            PopulateCustomerIDsComboBox();
            PopulateBranchIDsComboBox();
            DisplayAccountsInDataGridView();

        }

        public void RefreshControl()
        {

            PopulateCustomerIDsComboBox();
            PopulateBranchIDsComboBox();
            DisplayAccountsInDataGridView();

        }


        private void PopulateCustomerIDsComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    // Query to retrieve custIDs from the customer table
                    string query = "SELECT custid FROM customer";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            account_custid.Items.Clear();

                            // Add each custID to the ComboBox
                            while (reader.Read())
                            {
                                string custID = reader["custid"].ToString();
                                account_custid.Items.Add(custID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateBranchIDsComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    // Query to retrieve custIDs from the customer table
                    string query = "SELECT bid FROM branch";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            account_bid.Items.Clear();

                            // Add each custID to the ComboBox
                            while (reader.Read())
                            {
                                string bid = reader["bid"].ToString();
                                account_bid.Items.Add(bid);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void DisplayAccountsInDataGridView()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM account", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    // Clear existing columns
                    Accounts.Columns.Clear();

                    // Manually add columns
                    DataGridViewTextBoxColumn acNumberColumn = new DataGridViewTextBoxColumn();
                    acNumberColumn.DataPropertyName = "acnumber";  // Replace with the actual column name
                    acNumberColumn.HeaderText = "A. Number";
                    Accounts.Columns.Add(acNumberColumn);

                    DataGridViewTextBoxColumn acc_custIDColumn = new DataGridViewTextBoxColumn();
                    acc_custIDColumn.DataPropertyName = "custid";  // Replace with the actual column name
                    acc_custIDColumn.HeaderText = "CustID";
                    Accounts.Columns.Add(acc_custIDColumn); 

                    DataGridViewTextBoxColumn bidColumn = new DataGridViewTextBoxColumn();
                    bidColumn.DataPropertyName = "bid";  // Replace with the actual column name
                    bidColumn.HeaderText = "Branch ID";
                    Accounts.Columns.Add(bidColumn);

                    DataGridViewTextBoxColumn openingBalanceColumn = new DataGridViewTextBoxColumn();
                    openingBalanceColumn.DataPropertyName = "opening_balance";  // Replace with the actual column name
                    openingBalanceColumn.HeaderText = "O.Balance";
                    Accounts.Columns.Add(openingBalanceColumn);

                    DataGridViewTextBoxColumn aodColumn = new DataGridViewTextBoxColumn();
                    aodColumn.DataPropertyName = "aod";  // Replace with the actual column name
                    aodColumn.HeaderText = "Creation Date";
                    Accounts.Columns.Add(aodColumn);

                    DataGridViewTextBoxColumn atypeColumn = new DataGridViewTextBoxColumn();
                    atypeColumn.DataPropertyName = "atype";  // Replace with the actual column name
                    atypeColumn.HeaderText = "Type";
                    Accounts.Columns.Add(atypeColumn);

                    DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
                    statusColumn.DataPropertyName = "astatus";  // Replace with the actual column name
                    statusColumn.HeaderText = "Status";
                    Accounts.Columns.Add(statusColumn);

                    DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
                    passwordColumn.DataPropertyName = "password";  // Replace with the actual column name
                    passwordColumn.HeaderText = "Password";
                    Accounts.Columns.Add(passwordColumn);


                    // Add other columns as needed...

                    // Set DataSource
                    Accounts.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetSelectedAccountId()
        {
            if (Accounts != null && Accounts.SelectedRows.Count > 0)
            {
                int accIdIndex = 0; 

                // Check if the column index is valid
                if (accIdIndex >= 0 && accIdIndex < Accounts.SelectedRows[0].Cells.Count)
                {
                    DataGridViewRow selectedRow = Accounts.SelectedRows[0];

                    // Check if the cell value is not null before accessing it
                    if (selectedRow.Cells[accIdIndex].Value != null)
                    {
                        return selectedRow.Cells[accIdIndex].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("The selected account number is null.");
                    }
                }
                else
                {
                    MessageBox.Show("The column index for 'acnumber' is invalid.");
                }
            }
            else
            {
                MessageBox.Show("No account is selected.");
            }

            return null;
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Clear_Click(object sender, EventArgs e)
        {

            account_custid.Text = "";
            account_bid.Text = "";
            account_type.Text = "";
            account_status.Text = "";

            account_openingbalance.Clear();
            account_password.Clear();
        }


        private void Accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = Accounts.Rows[e.RowIndex];

                    int accCustIDIndex = 1;
                    int accBranchIDIndex = 2;
                    int accOpeningBalanceIndex = 3;
                    int accTypeIndex = 5;
                    int accStatusIndex = 6;
                    int accPasswordIndex = 7;

                    // Check if the cell value is not null before accessing it
                    account_custid.Text = row.Cells[accCustIDIndex].Value?.ToString() ?? string.Empty;
                    account_bid.Text = row.Cells[accBranchIDIndex].Value?.ToString() ?? string.Empty;
                    account_openingbalance.Text = row.Cells[accOpeningBalanceIndex].Value?.ToString() ?? string.Empty;
                    account_type.Text = row.Cells[accTypeIndex].Value?.ToString() ?? string.Empty;
                    account_status.Text = row.Cells[accStatusIndex].Value?.ToString() ?? string.Empty;
                    account_password.Text = row.Cells[accPasswordIndex].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool IsAccountExist(SqlConnection connection, string custID, string atype)
        {
            bool isConnectionOpen = connection.State == ConnectionState.Open;

            try
            {
                if (!isConnectionOpen)
                {
                    connection.Open();
                }

                // Use the CheckAccountExists function directly in the SQL query
                using (SqlCommand checkCmd = new SqlCommand("SELECT dbo.CheckAccountExists(@custid, @atype)", connection))
                {
                    checkCmd.Parameters.AddWithValue("@custid", custID);
                    checkCmd.Parameters.AddWithValue("@atype", atype);

                    int recordCount = (int)checkCmd.ExecuteScalar();

                    return recordCount > 0;
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




        private void AddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if all required fields are filled
                if (string.IsNullOrEmpty(account_custid.Text) || string.IsNullOrEmpty(account_bid.Text) ||
                    string.IsNullOrEmpty(account_openingbalance.Text) || string.IsNullOrEmpty(account_type.Text) ||
                    string.IsNullOrEmpty(account_status.Text) || string.IsNullOrEmpty(account_password.Text))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("EXEC GenerateNextAccountId", conn))
                    {
                        SqlParameter outputParameter = new SqlParameter();
                        outputParameter.ParameterName = "@nextAccountId";
                        outputParameter.SqlDbType = SqlDbType.VarChar;
                        outputParameter.Size = 6;
                        outputParameter.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(outputParameter);

                        cmd.ExecuteNonQuery();

                        string nextAccountId = outputParameter.Value.ToString();

                        // Get values from the UI controls
                        string custID = account_custid.Text;
                        string bid = account_bid.Text;
                        string openingBalance = account_openingbalance.Text;
                        string type = account_type.Text;
                        string status = account_status.Text;
                        string password = account_password.Text;

                        if (IsAccountExist(conn, custID, type))
                        {
                            MessageBox.Show("Account with the same Customer ID and Type already exists.");
                            return; // Exit the method if the account already exists
                        }

                        // Insert data into the customer table using the InsertCustomer stored procedure
                        using (SqlCommand insertCommand = new SqlCommand("EXEC InsertAccount @acnumber, @custid, @bid, @opening_balance, @aod, @atype, @astatus, @password", conn))
                        {
                            insertCommand.Parameters.AddWithValue("@acnumber", nextAccountId);
                            insertCommand.Parameters.AddWithValue("@custid", custID);
                            insertCommand.Parameters.AddWithValue("@bid", bid);
                            insertCommand.Parameters.AddWithValue("@opening_balance", openingBalance);
                            insertCommand.Parameters.AddWithValue("@aod", DateTime.Now);
                            insertCommand.Parameters.AddWithValue("@atype", type);
                            insertCommand.Parameters.AddWithValue("@astatus", status);
                            insertCommand.Parameters.AddWithValue("@password", password);

                            insertCommand.ExecuteNonQuery();

                            MessageBox.Show("Account added successfully with ID: " + nextAccountId);

                            DisplayAccountsInDataGridView();

                            account_custid.Text = "";
                            account_bid.Text = "";
                            account_type.Text = "";
                            account_status.Text = "";
                            account_openingbalance.Clear();
                            account_password.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


private void UpdateAccount_Click(object sender, EventArgs e)
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

                // Get values from the UI controls
                string custID = account_custid.Text;
                string bid = account_bid.Text;
                // string openingBalance = account_openingbalance.Text; // Remove this line
                string type = account_type.Text;
                string status = account_status.Text;
                string password = account_password.Text;


                // Call the UpdateAccount stored procedure
                using (SqlCommand updateCommand = new SqlCommand("UpdateAccount", conn))
                {
                    updateCommand.CommandType = CommandType.StoredProcedure;

                    updateCommand.Parameters.AddWithValue("@acnumber", selectedAccountId);
                    updateCommand.Parameters.AddWithValue("@custid", custID);
                    updateCommand.Parameters.AddWithValue("@bid", bid);
                    // updateCommand.Parameters.AddWithValue("@opening_balance", openingBalance); // Remove this line
                    updateCommand.Parameters.AddWithValue("@atype", type);
                    updateCommand.Parameters.AddWithValue("@astatus", status);
                    updateCommand.Parameters.AddWithValue("@password", password);

                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Account updated successfully.");

                    DisplayAccountsInDataGridView();

                    account_custid.Text = "";
                    account_bid.Text = "";
                    account_type.Text = "";
                    account_status.Text = "";
                    account_openingbalance.Clear();  // This line can be removed since opening_balance is not being used
                    account_password.Clear();
                }
            }
        }
    }
    catch (SqlException ex)
    {
        // Handle exceptions
        if (ex.Number == 2627 || ex.Number == 2601)
        {
                MessageBox.Show("Error: A customer cannot have two accounts of the same type.", "Duplicate Account Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}



        private void DeleteAccount_Click(object sender, EventArgs e)
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
                        using (SqlCommand deleteCommand = new SqlCommand("DeleteAccount", conn))
                        {
                            deleteCommand.CommandType = CommandType.StoredProcedure;
                            deleteCommand.Parameters.AddWithValue("@acnumber", selectedAccountId);

                            deleteCommand.ExecuteNonQuery();

                            MessageBox.Show("Account deleted successfully.");

                            // Remove the selected row from the DataGridView
                            RemoveSelectedRow();

                            // Refresh the account table (optional)
                            DisplayAccountsInDataGridView();
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
            if (Accounts.SelectedRows.Count > 0)
            {
                int selectedIndex = Accounts.SelectedRows[0].Index;
                Accounts.Rows.RemoveAt(selectedIndex);
            }
        }
    }
}
