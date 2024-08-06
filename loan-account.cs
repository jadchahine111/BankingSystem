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
    public partial class loan_account : Form
    {
        private SqlConnection connect;

        public loan_account()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
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
                            label4.Text = $"{firstName}";
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

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard_loan_account2.RefreshControl();
            dashboard_loan_account2.Visible = true;
            pay_load_account2.Visible = false;
            info_loan_account2.Visible = false;
        }

        private void TransactionOverview_btn_Click(object sender, EventArgs e)
        {
            dashboard_loan_account2.Visible = false;
            pay_load_account2.Visible = true;
            info_loan_account2.Visible = false;
        }

        private void AddBranch_btn_Click(object sender, EventArgs e)
        {
            dashboard_loan_account2.Visible = false;
            pay_load_account2.Visible = false;
            info_loan_account2.Visible = true;
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
    }
}
