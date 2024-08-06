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
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public Dashboard()
        {
            InitializeComponent();
            UpdateTotalAccountsLabel();
            UpdateTotalLoansLabel();
            UpdateTotalTransactionsLabel();
        }

        public void RefreshControl()
        {
            UpdateTotalAccountsLabel();
            UpdateTotalLoansLabel();
            UpdateTotalTransactionsLabel();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTotalAccountsLabel()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("EXEC CalculateTotalAccounts", connection))
                    {
                        // Execute the query
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int totalAccounts = Convert.ToInt32(result);
                            TotalAccounts_lbl.Text = totalAccounts.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error retrieving total accounts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalLoansLabel()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("EXEC CalculateTotalLoans", connection))
                    {
                       
                        object result= command.ExecuteScalar();

                        if (result != null)
                        {
                            int totalLoans = Convert.ToInt32(result);
                            TotalLoans_lbl.Text = totalLoans.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error retrieving total loans.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalTransactionsLabel()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("EXEC CalculateTotalTransactions", connection))
                    {

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int totalTransactions = Convert.ToInt32(result);
                            TotalTransactions_lbl.Text = totalTransactions.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error retrieving total transactions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
