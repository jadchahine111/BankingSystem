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
    public partial class admin_money : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public admin_money()
        {
            InitializeComponent();
            PopulateAccountIDsComboBox1();
            PopulateAccountIDsComboBox2();
            PopulateAccountIDsComboBox3();
            PopulateAccountIDsComboBox4();
            PopulateAccountIDsComboBox5();
        }

        public void RefreshControl()
        {
            PopulateAccountIDsComboBox1();
            PopulateAccountIDsComboBox2();
            PopulateAccountIDsComboBox3();
            PopulateAccountIDsComboBox4();
            PopulateAccountIDsComboBox5();

        }

        private void PopulateAccountIDsComboBox1()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT acnumber FROM account";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            money_accId1.Items.Clear();

                            // Add each custID to the ComboBox
                            while (reader.Read())
                            {
                                string acnumber = reader["acnumber"].ToString();
                                money_accId1.Items.Add(acnumber);
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

        private void PopulateAccountIDsComboBox2()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT acnumber FROM account WHERE atype = 'Personal'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            money_accId2.Items.Clear();

                            // Add each custID to the ComboBox
                            while (reader.Read())
                            {
                                string acnumber = reader["acnumber"].ToString();
                                money_accId2.Items.Add(acnumber);
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

        private void PopulateAccountIDsComboBox3()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT acnumber FROM account WHERE atype = 'Personal'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            money_accId3.Items.Clear();

                            // Add each custID to the ComboBox
                            while (reader.Read())
                            {
                                string acnumber = reader["acnumber"].ToString();
                                money_accId3.Items.Add(acnumber);
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

        private void PopulateAccountIDsComboBox4()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect.ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT acnumber FROM account";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            money_accId4.Items.Clear();

                            // Add each custID to the ComboBox
                            while (reader.Read())
                            {
                                string acnumber = reader["acnumber"].ToString();
                                money_accId4.Items.Add(acnumber);
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

        private void PopulateAccountIDsComboBox5()
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
                            money_accId5.Items.Clear();

                            // Add each custID to the ComboBox
                            while (reader.Read())
                            {
                                string acnumber = reader["acnumber"].ToString();
                                money_accId5.Items.Add(acnumber);
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

        private void Clear1_Click(object sender, EventArgs e)
        {
            money_accId1.Text = "";
            money_mot1.Text = "";
            money_amount1.Clear();
        }

        private void Clear2_Click(object sender, EventArgs e)
        {
            money_accId2.Text = "";
            money_mot2.Text = "";
            money_amount2.Clear();
        }

        private void Clear3_Click(object sender, EventArgs e)
        {
            money_accId3.Text = "";
            money_accId4.Text = "";
            money_amount3.Clear();

        }

        private void Clear4_Click(object sender, EventArgs e)
        {
            money_accId5.Text = "";
            money_mot4.Text = "";
            money_amount4.Clear();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Check if an item is selected in the combobox
                    if (money_accId1.SelectedItem != null)
                    {
                        // Assuming you have selected values from your comboboxes and textbox
                        string acnumber = money_accId1.SelectedItem.ToString();
                        string medium_of_transaction = money_mot1.SelectedItem?.ToString();
                        decimal transaction_amount;

                        if (decimal.TryParse(money_amount1.Text, out transaction_amount))
                        {
                            // Build the T-SQL command with EXEC
                            command.CommandText = "EXEC Deposit @acnumber, @medium_of_transaction, @transaction_amount";

                            // Set parameters
                            command.Parameters.AddWithValue("@acnumber", acnumber);
                            command.Parameters.AddWithValue("@medium_of_transaction", medium_of_transaction);
                            command.Parameters.AddWithValue("@transaction_amount", transaction_amount);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Deposit successful.");

                                money_accId1.Text = "";  // Deselect item
                                money_mot1.Text = "";    // Deselect item
                                money_amount1.Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid amount. Please enter a valid numeric amount.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an account before making a transaction.");
                    }
                }
            }
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Check if an item is selected in the combobox
                    if (money_accId2.SelectedItem != null)
                    {
                        // Assuming you have selected values from your comboboxes and textbox
                        string acnumber = money_accId2.SelectedItem.ToString();
                        string medium_of_transaction = money_mot2.SelectedItem?.ToString();
                        decimal transaction_amount;

                        if (decimal.TryParse(money_amount2.Text, out transaction_amount))
                        {
                            // Check if the withdrawal amount is greater than the account balance
                            decimal currentBalance = GetCurrentBalance(acnumber);

                            if (transaction_amount > currentBalance)
                            {
                                MessageBox.Show("Withdrawal amount exceeds the account balance. Please enter a valid amount.");
                                return; // Exit the function
                            }

                            // Build the T-SQL command with EXEC
                            command.CommandText = "EXEC Withdraw @acnumber, @medium_of_transaction, @transaction_amount";

                            // Set parameters
                            command.Parameters.AddWithValue("@acnumber", acnumber);
                            command.Parameters.AddWithValue("@medium_of_transaction", medium_of_transaction);
                            command.Parameters.AddWithValue("@transaction_amount", transaction_amount);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Withdrawal successful.");

                                // Clear the fields after a successful withdrawal
                                money_accId2.Text = "";  // Deselect item
                                money_mot2.Text = "";    // Deselect item
                                money_amount2.Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid amount. Please enter a valid numeric amount.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an account before making a transaction.");
                    }
                }
            }
        }

        // Helper method to get the current account balance
        private decimal GetCurrentBalance(string acnumber)
        {
            decimal balance = 0;

            using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT opening_balance FROM account WHERE acnumber = @acnumber", connection))
                {
                    command.Parameters.AddWithValue("@acnumber", acnumber);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        balance = Convert.ToDecimal(result);
                    }
                }
            }

            return balance;
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Check if both source and destination accounts are selected
                    if (money_accId3.SelectedItem != null && money_accId4.SelectedItem != null)
                    {
                        // Assuming you have selected values from your comboboxes and textbox
                        string source_acnumber = money_accId3.SelectedItem.ToString();
                        string destination_acnumber = money_accId4.SelectedItem.ToString();
                        decimal transfer_amount;

                        // Check if the source and destination accounts are different
                        if (source_acnumber == destination_acnumber)
                        {
                            MessageBox.Show("Source and destination accounts cannot be the same.");
                            return; // Exit the function
                        }

                        if (decimal.TryParse(money_amount3.Text, out transfer_amount))
                        {
                            // Check if the transfer amount is greater than 0
                            if (transfer_amount <= 0)
                            {
                                MessageBox.Show("Invalid transfer amount. Please enter a valid amount.");
                                return; // Exit the function
                            }

                            // Build the T-SQL command with EXEC
                            command.CommandText = "EXEC Transfer @source_acnumber, @destination_acnumber, @transfer_amount";

                            // Set parameters
                            command.Parameters.AddWithValue("@source_acnumber", source_acnumber);
                            command.Parameters.AddWithValue("@destination_acnumber", destination_acnumber);
                            command.Parameters.AddWithValue("@transfer_amount", transfer_amount);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Transfer successful.");

                                // Clear the fields after a successful transfer
                                money_accId3.SelectedIndex = -1;  // Deselect source account
                                money_accId4.SelectedIndex = -1;  // Deselect destination account
                                money_amount3.Clear();
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 50000) // Custom error number indicating a specific business rule violation
                                {
                                    MessageBox.Show("Transfer failed. " + ex.Message);
                                }
                                else
                                {
                                    MessageBox.Show("Error: " + ex.Message);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid amount. Please enter a valid numeric amount.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select both source and destination accounts before making a transfer.");
                    }
                }
            }
        }



        private void Pay_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Check if an item is selected in the combobox
                    if (money_accId5.SelectedItem != null)
                    {
                        // Assuming you have selected values from your comboboxes and textbox
                        string acnumber = money_accId5.SelectedItem.ToString();
                        string payment_method = money_mot4.SelectedItem?.ToString();
                        decimal payment_amount;
                        decimal excess_amount = 0;

                        if (decimal.TryParse(money_amount4.Text, out payment_amount))
                        {
                            // Check if the payment amount is greater than 0
                            if (payment_amount <= 0)
                            {
                                MessageBox.Show("Invalid payment amount. Please enter a valid amount.");
                                return; // Exit the function
                            }

                            // Build the T-SQL command with EXEC
                            command.CommandText = "EXEC LoanPayment2 @acnumber, @payment_amount, @payment_method, @excess_amount OUTPUT";

                            // Set parameters
                            command.Parameters.AddWithValue("@acnumber", acnumber);
                            command.Parameters.AddWithValue("@payment_amount", payment_amount);
                            command.Parameters.AddWithValue("@payment_method", payment_method); // Added this line

                            // Output parameter for excess amount
                            command.Parameters.Add("@excess_amount", SqlDbType.Decimal).Direction = ParameterDirection.Output;

                            try
                            {
                                command.ExecuteNonQuery();

                                // Retrieve the excess amount from the output parameter
                                excess_amount = (decimal)command.Parameters["@excess_amount"].Value;

                                // Display a message based on whether there is an excess amount
                                if (excess_amount > 0)
                                {
                                    MessageBox.Show($"Loan paid successfully. Excess amount of {excess_amount:C} deposited in your account.");
                                }
                                else
                                {
                                    MessageBox.Show("Loan paid successfully.");
                                }

                                // Clear the fields after a successful loan payment
                                money_accId5.Text = ""; // Deselect item
                                money_mot4.Text = "";   // Deselect item
                                money_amount4.Clear();
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 51001)
                                {
                                    MessageBox.Show("No loan amount to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (ex.Number == 51002)
                                {
                                    MessageBox.Show("Insufficient funds in the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        else
                        {
                            MessageBox.Show("Invalid amount. Please enter a valid numeric amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an account before making a transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }







    }
}
