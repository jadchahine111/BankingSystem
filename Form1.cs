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
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-V215HNN;Initial Catalog=BankingSys;Integrated Security=True");
        public static string accountID = "";
        public Form1()
        {
            InitializeComponent();
            accountID = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '•';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Login or password is empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connect.ConnectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("dbo.ValidateLogin", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Add parameters
                            command.Parameters.AddWithValue("@InputUsername", login_username.Text);
                            command.Parameters.AddWithValue("@InputPassword", login_password.Text);

                            // Add OUTPUT parameter
                            SqlParameter isValidParam = new SqlParameter("@IsValid", SqlDbType.Int);
                            isValidParam.Direction = ParameterDirection.Output;
                            command.Parameters.Add(isValidParam);

                            // Execute the stored procedure
                            command.ExecuteNonQuery();

                            // Retrieve the value of @IsValid after executing the stored procedure
                            int isValid = Convert.ToInt32(isValidParam.Value);

                            switch (isValid)
                            {
                                case 1:
                                    MessageBox.Show("Login successful for a Personal Account!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    accountID = login_username.Text;
                                    // Create an instance of the dashboard_personal_account user control
                                    personnal_account dashboard_personal_account1 = new personnal_account();
                                    dashboard_personal_account1.Show();
                                    this.Hide();
                                    break;

                                case 2:
                                    MessageBox.Show("Login successful as admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    admin adminForm = new admin();
                                    adminForm.Show();
                                    this.Hide();
                                    break;
                                case 3:
                                    MessageBox.Show("Login successful for a Loan Account (Active)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    accountID = login_username.Text;
                                    loan_account loanAccountForm = new loan_account();
                                    loanAccountForm.Show();
                                    this.Hide();
                                    break;
                                case 4:
                                    MessageBox.Show("Personal account inactive. Kindly contact administrator of your branch", "Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    // Handle inactive personal account case
                                    break;
                                case 5:
                                    MessageBox.Show("Loan account inactive. Kindly contact administrator of your branch", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    // Handle inactive loan account case
                                    break;
                                case 6:
                                    MessageBox.Show("Sub-admin page under construction", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Handle inactive loan account case
                                    break;
                                default:
                                    MessageBox.Show("Invalid username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
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
}
    

