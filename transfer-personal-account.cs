using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Bankingsys
{
    public partial class transfer_personal_account : UserControl
    {
        private SqlConnection connect;

        public transfer_personal_account()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        }




        private void Clear3_Click(object sender, EventArgs e)
        {
            transfers_accID.Clear();
            transfer_amount.Clear();

        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            // Get the destination account ID and transfer amount from textboxes
            string destinationAccountId = transfers_accID.Text;
            decimal transferAmount;

            // Check if the transfer amount is a valid decimal value
            if (!decimal.TryParse(transfer_amount.Text, out transferAmount))
            {
                MessageBox.Show("Invalid transfer amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the transfer amount is invalid
            }

            // Check if the destination account ID is the same as the signed-in account ID
            if (destinationAccountId == Form1.accountID)
            {
                MessageBox.Show("Cannot transfer to the same account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the destination account is the same as the signed-in account
            }

            // Check if the destination account ID exists in the accounts table
            if (!IsAccountExists(destinationAccountId))
            {
                MessageBox.Show("Destination account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the destination account does not exist
            }

            try
            {
                // Call the Transfer2 stored procedure with the source account ID (accountID), destination account ID, and transfer amount
                using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("Transfer2", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@source_acnumber", Form1.accountID);
                        command.Parameters.AddWithValue("@destination_acnumber", destinationAccountId);
                        command.Parameters.AddWithValue("@transfer_amount", transferAmount);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        // Inform the user that the transfer was successful
                        MessageBox.Show("Transfer successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Helper method to check if an account exists in the accounts table
        private bool IsAccountExists(string accountId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
                {
                    connection.Open();

                    // Check if the account ID exists in the accounts table
                    string query = "SELECT COUNT(*) FROM account WHERE acnumber = @AccountId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountId", accountId);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Return true if the account ID exists, false otherwise
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false in case of an exception
            }
        }

    }
}