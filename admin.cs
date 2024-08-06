using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankingsys
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
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

        private void addCustomers1_Load(object sender, EventArgs e)
        {

        }

        private void addCustomers1_Load_1(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.RefreshControl();
            dashboard1.Visible = true;
            addCustomers1.Visible = false;
            addAccounts1.Visible = false;
            transactionOverview1.Visible = false;
            addLoan1.Visible = false;
            addBranch1.Visible = false;
            admin_money1.Visible = false;
        }

        private void AddCustomers_btn_Click(object sender, EventArgs e)
        {
            addCustomers1.RefreshControl();
            dashboard1.Visible = false;
            addCustomers1.Visible = true;
            addAccounts1.Visible = false;
            transactionOverview1.Visible = false;
            addLoan1.Visible = false;
            addBranch1.Visible = false;
            admin_money1.Visible = false;

        }

        private void AddAccounts_btn_Click(object sender, EventArgs e)
        {
            addAccounts1.RefreshControl();
            dashboard1.Visible = false;
            addCustomers1.Visible = false;
            addAccounts1.Visible = true;
            transactionOverview1.Visible = false;
            addLoan1.Visible = false;
            addBranch1.Visible = false;
            admin_money1.Visible = false;

        }

        private void TransactionOverview_btn_Click(object sender, EventArgs e)
        {
            transactionOverview1.RefreshControl();
            dashboard1.Visible = false;
            addCustomers1.Visible = false;
            addAccounts1.Visible = false;
            transactionOverview1.Visible = true;
            addLoan1.Visible = false;
            addBranch1.Visible = false;
            admin_money1.Visible = false;
        }

        private void AddLoan_btn_Click(object sender, EventArgs e)
        {
            addLoan1.RefreshControl();
            dashboard1.Visible = false;
            addCustomers1.Visible = false;
            addAccounts1.Visible = false;
            transactionOverview1.Visible = false;
            addLoan1.Visible = true;
            addBranch1.Visible = false;
            admin_money1.Visible = false;
        }

        private void AddBranch_btn_Click(object sender, EventArgs e)
        {
            addBranch1.RefreshControl();
            dashboard1.Visible = false;
            addCustomers1.Visible = false;
            addAccounts1.Visible = false;
            transactionOverview1.Visible = false;
            addLoan1.Visible = false;
            addBranch1.Visible = true;
            admin_money1.Visible = false;
        }

        private void Money_btn_Click(object sender, EventArgs e)
        {
            admin_money1.RefreshControl();
            dashboard1.Visible = false;
            addCustomers1.Visible = false;
            addAccounts1.Visible = false;
            transactionOverview1.Visible = false;
            addLoan1.Visible = false;
            addBranch1.Visible = false;
            admin_money1.Visible = true;
        }
    }
}
