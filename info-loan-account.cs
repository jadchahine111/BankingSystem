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
    public partial class info_loan_account : UserControl
    {
        private SqlConnection connect;

        public info_loan_account()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
            DisplayAccID();
            DisplayCustID();
            DisplayBID();
            DisplayAOD();
            DisplayType();
        }

        public void RefreshControl()
        {
            DisplayAccID();
            DisplayCustID();
            DisplayBID();
            DisplayAOD();
            DisplayType();
        }

        private void DisplayAccID()
        {
            try
            {
                connect.Open();

                // Query to get the account ID based on the provided account ID
                string query = "SELECT acnumber FROM account WHERE acnumber = @AccountId";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@AccountId", Form1.accountID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve account ID from the database
                            string accID = reader["acnumber"].ToString();

                            // Set the text of the label or perform any other actions
                            info_accID.Text = $"{accID}";
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


        private void DisplayCustID()
        {
            try
            {
                connect.Open();

                // Query to get the customer's name based on the account ID
                string query = "SELECT custid FROM account WHERE acnumber = @AccountId";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@AccountId", Form1.accountID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve customer's name from the database
                            string custID = reader["custid"].ToString();


                            // Set the text of the label or perform any other actions
                            info_custID.Text = $"{custID}";
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

        private void DisplayBID()
        {
            try
            {
                connect.Open();

                // Query to get the customer's name based on the account ID
                string query = @"
            SELECT branch.bname
            FROM account
            INNER JOIN branch ON account.bid = branch.bid
            WHERE account.acnumber = @AccountId";
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@AccountId", Form1.accountID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve customer's name from the database
                            string bname = reader["bname"].ToString();


                            // Set the text of the label or perform any other actions
                            info_branch.Text = $"{bname}";
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

        private void DisplayAOD()
        {
            try
            {
                connect.Open();

                // Query to get the customer's name based on the account ID
                string query = "SELECT aod FROM account WHERE acnumber = @AccountId";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@AccountId", Form1.accountID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve customer's name from the database
                            string aod = reader["aod"].ToString();


                            // Set the text of the label or perform any other actions
                            info_aod.Text = $"{aod}";
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

        private void DisplayType()
        {
            try
            {
                connect.Open();

                // Query to get the customer's name based on the account ID
                string query = "SELECT atype FROM account WHERE acnumber = @AccountId";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@AccountId", Form1.accountID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve customer's name from the database
                            string atype = reader["atype"].ToString();


                            // Set the text of the label or perform any other actions
                            info_type.Text = $"{atype}";
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


    }
}
