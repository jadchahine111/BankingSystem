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
    public partial class TransactionOverview : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public TransactionOverview()
        {
            InitializeComponent();
            DisplayTransactionsInDataGridView();
        }
        public void RefreshControl()
        {
            DisplayTransactionsInDataGridView();
        }
        private void DisplayTransactionsInDataGridView()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connect.ConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM trandetails", sqlCon);
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
    }
}
