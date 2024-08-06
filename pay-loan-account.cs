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
    public partial class pay_load_account : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public pay_load_account()
        {
            InitializeComponent();
        }

        private void Clear3_Click(object sender, EventArgs e)
        {
            pay_amount.Clear();
        }
        private void Pay_Click(object sender, EventArgs e)
        {
            // Check if the payment amount is a valid decimal value
            if (!decimal.TryParse(pay_amount.Text, out decimal paymentAmount) || paymentAmount <= 0)
            {
                MessageBox.Show("Invalid payment amount. Please enter a valid numeric value greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the payment amount is invalid
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("LoanPayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@acnumber", Form1.accountID);
                        command.Parameters.AddWithValue("@payment_amount", paymentAmount);

                        // Add OUTPUT parameter for excess amount
                        SqlParameter excessAmountParam = new SqlParameter("@excess_amount", SqlDbType.Decimal);
                        excessAmountParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(excessAmountParam);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        // Check if the excess amount is DBNull.Value
                        decimal excessAmount = excessAmountParam.Value == DBNull.Value ? 0 : Convert.ToDecimal(excessAmountParam.Value);

                        // Display appropriate messages
                        if (excessAmount > 0)
                        {
                            MessageBox.Show($"Required Payment successful! Excess amount of {excessAmount:C} wasn't deducted. Remaining loan amount is now 0.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Clear the textbox
                        pay_amount.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                {
                    MessageBox.Show("No Loans to pay. Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 50001)
                {
                    MessageBox.Show("Insufficient funds. Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







    }
}
