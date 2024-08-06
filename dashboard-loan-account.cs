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
    public partial class dashboard_loan_account : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public dashboard_loan_account()
        {
            InitializeComponent();
            DisplayBalance();
            DisplayTotalTransactions();
            DisplayLoanAmount();
            DisplayTransactionsInDataGridView();
        }

        public void RefreshControl()
        {
            DisplayBalance();
            DisplayTotalTransactions();
            DisplayTransactionsInDataGridView();
            DisplayLoanAmount();

        }

        private void DisplayLoanAmount()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();

                    // Fetch balance for the specific account number
                    string balanceQuery = "SELECT loan_amount FROM loan WHERE acnumber = @AccountNumber";
                    using (SqlCommand LoanCommand = new SqlCommand(balanceQuery, sqlCon))
                    {
                        LoanCommand.Parameters.AddWithValue("@AccountNumber", Form1.accountID);
                        object result = LoanCommand.ExecuteScalar();

                        if (result != null)
                        {
                            // Display account balance
                            decimal loan = Convert.ToDecimal(result);
                            Loan_lbl.Text = $"{loan:C}";
                        }
                        else
                        {
                            // Handle the case where the balance is not found
                            Loan_lbl.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayTransactionsInDataGridView()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM trandetails WHERE acnumber = @AccountNumber";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@AccountNumber", Form1.accountID);

                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    // Clear existing columns
                    Transactions.Columns.Clear();

                    // Manually add columns
                    DataGridViewTextBoxColumn TnumberColumn = new DataGridViewTextBoxColumn();
                    TnumberColumn.DataPropertyName = "tnumber";  // Replace with the actual column name
                    TnumberColumn.HeaderText = "T. Number";
                    Transactions.Columns.Add(TnumberColumn);

                    DataGridViewTextBoxColumn AccNumberColumn = new DataGridViewTextBoxColumn();
                    AccNumberColumn.DataPropertyName = "acnumber";  // Replace with the actual column name
                    AccNumberColumn.HeaderText = "Acc. Number";
                    Transactions.Columns.Add(AccNumberColumn);

                    DataGridViewTextBoxColumn dotColumn = new DataGridViewTextBoxColumn();
                    dotColumn.DataPropertyName = "dot";  // Replace with the actual column name
                    dotColumn.HeaderText = "T. Date";
                    Transactions.Columns.Add(dotColumn);

                    DataGridViewTextBoxColumn TmediumColumn = new DataGridViewTextBoxColumn();
                    TmediumColumn.DataPropertyName = "medium_of_transaction";  // Replace with the actual column name
                    TmediumColumn.HeaderText = "Tran. Medium";
                    Transactions.Columns.Add(TmediumColumn);

                    DataGridViewTextBoxColumn TtypeColumn = new DataGridViewTextBoxColumn();
                    TtypeColumn.DataPropertyName = "transaction_type";  // Replace with the actual column name
                    TtypeColumn.HeaderText = "Type";
                    Transactions.Columns.Add(TtypeColumn);


                    DataGridViewTextBoxColumn TAmountColumn = new DataGridViewTextBoxColumn();
                    TAmountColumn.DataPropertyName = "transaction_amount";  // Replace with the actual column name
                    TAmountColumn.HeaderText = "Amount";
                    Transactions.Columns.Add(TAmountColumn);




                    // Set DataSource
                    Transactions.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayBalance()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();

                    // Fetch balance for the specific account number
                    string balanceQuery = "SELECT opening_balance FROM account WHERE acnumber = @AccountNumber";
                    using (SqlCommand balanceCommand = new SqlCommand(balanceQuery, sqlCon))
                    {
                        balanceCommand.Parameters.AddWithValue("@AccountNumber", Form1.accountID);
                        object result = balanceCommand.ExecuteScalar();

                        if (result != null)
                        {
                            // Display account balance
                            decimal balance = Convert.ToDecimal(result);
                            Balance_lbl.Text = $"{balance:C}";
                        }
                        else
                        {
                            // Handle the case where the balance is not found
                            Balance_lbl.Text = "Account Balance not available";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayTotalTransactions()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();

                    // Fetch total transactions for the specific account number
                    string totalTransactionsQuery = "SELECT COUNT(*) FROM trandetails WHERE acnumber = @AccountNumber";
                    using (SqlCommand totalTransactionsCommand = new SqlCommand(totalTransactionsQuery, sqlCon))
                    {
                        totalTransactionsCommand.Parameters.AddWithValue("@AccountNumber", Form1.accountID);
                        object result = totalTransactionsCommand.ExecuteScalar();

                        if (result != null)
                        {
                            // Display total transactions
                            int totalTransactions = Convert.ToInt32(result);
                            TotalTransactions_lbl.Text = $"{totalTransactions}";
                        }
                        else
                        {
                            // Handle the case where total transactions are not found
                            TotalTransactions_lbl.Text = "Total Transactions not available";
                        }
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
