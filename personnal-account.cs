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
    // Inside your personnal_account class
    public partial class personnal_account : Form
    {
        private SqlConnection connect;

        public personnal_account()
        {
            InitializeComponent();

            // Set the private variable to the provided account ID

            // Initialize the SqlConnection here or pass it as a parameter
            connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");

            // Call the method to display customer name
            DisplayCustomerName();
        }

        private void DisplayCustomerName()
        {
            try
            {
                connect.Open();

                // Query to get the customer's name based on the account ID
                string query = "SELECT fname, mname, ltname FROM customer WHERE custid = (SELECT custid FROM account WHERE acnumber = @AccountId)";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@AccountId", Form1.accountID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve customer's name from the database
                            string firstName = reader["fname"].ToString();
                            string middleName = reader["mname"].ToString();
                            string lastName = reader["ltname"].ToString();

                            // Set the text of the label or perform any other actions
                            accName_label.Text = $"{firstName}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void logout_btn1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard_personal_account1.RefreshControl();
            dashboard_personal_account1.Visible = true;
            transfer_personal_account1.Visible = false;
            info_personal_account1.Visible = false;
        }

        private void TransactionOverview_btn_Click(object sender, EventArgs e)
        {
            dashboard_personal_account1.Visible = false;
            transfer_personal_account1.Visible = true;
            info_personal_account1.Visible = false;
        }

        private void AddBranch_btn_Click(object sender, EventArgs e)
        {
            info_personal_account1.RefreshControl();
            dashboard_personal_account1.Visible = false;
            transfer_personal_account1.Visible = false;
            info_personal_account1.Visible = true;
        }
    }

}
