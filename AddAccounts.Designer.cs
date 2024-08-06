
namespace Bankingsys
{
    partial class AddAccounts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Accounts = new System.Windows.Forms.DataGridView();
            this.account_table_acnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_table_custID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_table_bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_table_openingbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_table_aod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_table_atype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_table_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_table_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.account_bid = new System.Windows.Forms.ComboBox();
            this.account_custid = new System.Windows.Forms.ComboBox();
            this.account_status = new System.Windows.Forms.ComboBox();
            this.account_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteAccount = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.UpdateAccount = new System.Windows.Forms.Button();
            this.AddAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.account_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.account_openingbalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accounts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Accounts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 333);
            this.panel1.TabIndex = 0;
            // 
            // Accounts
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Accounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account_table_acnumber,
            this.account_table_custID,
            this.account_table_bid,
            this.account_table_openingbalance,
            this.account_table_aod,
            this.account_table_atype,
            this.account_table_status,
            this.account_table_password});
            this.Accounts.Location = new System.Drawing.Point(20, 51);
            this.Accounts.MultiSelect = false;
            this.Accounts.Name = "Accounts";
            this.Accounts.ReadOnly = true;
            this.Accounts.RowHeadersVisible = false;
            this.Accounts.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Accounts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Accounts.RowTemplate.Height = 28;
            this.Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Accounts.Size = new System.Drawing.Size(792, 268);
            this.Accounts.TabIndex = 2;
            this.Accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Accounts_CellClick);
            // 
            // account_table_acnumber
            // 
            this.account_table_acnumber.HeaderText = "Account Num";
            this.account_table_acnumber.MinimumWidth = 8;
            this.account_table_acnumber.Name = "account_table_acnumber";
            this.account_table_acnumber.ReadOnly = true;
            this.account_table_acnumber.Width = 150;
            // 
            // account_table_custID
            // 
            this.account_table_custID.HeaderText = "CustID";
            this.account_table_custID.MinimumWidth = 8;
            this.account_table_custID.Name = "account_table_custID";
            this.account_table_custID.ReadOnly = true;
            this.account_table_custID.Width = 150;
            // 
            // account_table_bid
            // 
            this.account_table_bid.HeaderText = "BranchID";
            this.account_table_bid.MinimumWidth = 8;
            this.account_table_bid.Name = "account_table_bid";
            this.account_table_bid.ReadOnly = true;
            this.account_table_bid.Width = 150;
            // 
            // account_table_openingbalance
            // 
            this.account_table_openingbalance.HeaderText = "Openingbalance";
            this.account_table_openingbalance.MinimumWidth = 8;
            this.account_table_openingbalance.Name = "account_table_openingbalance";
            this.account_table_openingbalance.ReadOnly = true;
            this.account_table_openingbalance.Width = 150;
            // 
            // account_table_aod
            // 
            this.account_table_aod.HeaderText = "Creation Date";
            this.account_table_aod.MinimumWidth = 8;
            this.account_table_aod.Name = "account_table_aod";
            this.account_table_aod.ReadOnly = true;
            this.account_table_aod.Width = 150;
            // 
            // account_table_atype
            // 
            this.account_table_atype.HeaderText = "Type";
            this.account_table_atype.MinimumWidth = 8;
            this.account_table_atype.Name = "account_table_atype";
            this.account_table_atype.ReadOnly = true;
            this.account_table_atype.Width = 150;
            // 
            // account_table_status
            // 
            this.account_table_status.HeaderText = "Status";
            this.account_table_status.MinimumWidth = 8;
            this.account_table_status.Name = "account_table_status";
            this.account_table_status.ReadOnly = true;
            this.account_table_status.Width = 150;
            // 
            // account_table_password
            // 
            this.account_table_password.HeaderText = "Password";
            this.account_table_password.MinimumWidth = 8;
            this.account_table_password.Name = "account_table_password";
            this.account_table_password.ReadOnly = true;
            this.account_table_password.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.account_bid);
            this.panel2.Controls.Add(this.account_custid);
            this.panel2.Controls.Add(this.account_status);
            this.panel2.Controls.Add(this.account_type);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.DeleteAccount);
            this.panel2.Controls.Add(this.Clear);
            this.panel2.Controls.Add(this.UpdateAccount);
            this.panel2.Controls.Add(this.AddAccount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.account_password);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.account_openingbalance);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 279);
            this.panel2.TabIndex = 1;
            // 
            // account_bid
            // 
            this.account_bid.FormattingEnabled = true;
            this.account_bid.Location = new System.Drawing.Point(185, 76);
            this.account_bid.Name = "account_bid";
            this.account_bid.Size = new System.Drawing.Size(232, 28);
            this.account_bid.TabIndex = 23;
            // 
            // account_custid
            // 
            this.account_custid.FormattingEnabled = true;
            this.account_custid.Location = new System.Drawing.Point(185, 23);
            this.account_custid.Name = "account_custid";
            this.account_custid.Size = new System.Drawing.Size(232, 28);
            this.account_custid.TabIndex = 22;
            // 
            // account_status
            // 
            this.account_status.FormattingEnabled = true;
            this.account_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.account_status.Location = new System.Drawing.Point(580, 72);
            this.account_status.Name = "account_status";
            this.account_status.Size = new System.Drawing.Size(232, 28);
            this.account_status.TabIndex = 21;
            // 
            // account_type
            // 
            this.account_type.FormattingEnabled = true;
            this.account_type.Items.AddRange(new object[] {
            "Personal",
            "Loan"});
            this.account_type.Location = new System.Drawing.Point(581, 20);
            this.account_type.Name = "account_type";
            this.account_type.Size = new System.Drawing.Size(231, 28);
            this.account_type.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(432, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Account Type";
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteAccount.Location = new System.Drawing.Point(668, 191);
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Size = new System.Drawing.Size(144, 55);
            this.DeleteAccount.TabIndex = 16;
            this.DeleteAccount.Text = "Delete";
            this.DeleteAccount.UseVisualStyleBackColor = false;
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(452, 191);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(151, 55);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // UpdateAccount
            // 
            this.UpdateAccount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UpdateAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateAccount.Location = new System.Drawing.Point(228, 191);
            this.UpdateAccount.Name = "UpdateAccount";
            this.UpdateAccount.Size = new System.Drawing.Size(154, 55);
            this.UpdateAccount.TabIndex = 14;
            this.UpdateAccount.Text = "Update";
            this.UpdateAccount.UseVisualStyleBackColor = false;
            this.UpdateAccount.Click += new System.EventHandler(this.UpdateAccount_Click);
            // 
            // AddAccount
            // 
            this.AddAccount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddAccount.Location = new System.Drawing.Point(22, 191);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(143, 55);
            this.AddAccount.TabIndex = 13;
            this.AddAccount.Text = "Add";
            this.AddAccount.UseVisualStyleBackColor = false;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(447, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // account_password
            // 
            this.account_password.Location = new System.Drawing.Point(581, 125);
            this.account_password.Multiline = true;
            this.account_password.Name = "account_password";
            this.account_password.Size = new System.Drawing.Size(231, 35);
            this.account_password.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(460, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status";
            // 
            // account_openingbalance
            // 
            this.account_openingbalance.Location = new System.Drawing.Point(185, 120);
            this.account_openingbalance.Multiline = true;
            this.account_openingbalance.Name = "account_openingbalance";
            this.account_openingbalance.Size = new System.Drawing.Size(232, 35);
            this.account_openingbalance.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opening Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(41, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer ID";
            // 
            // AddAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddAccounts";
            this.Size = new System.Drawing.Size(889, 675);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accounts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox account_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox account_openingbalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteAccount;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button UpdateAccount;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox account_status;
        private System.Windows.Forms.ComboBox account_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox account_custid;
        private System.Windows.Forms.DataGridView Accounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_table_acnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_table_custID;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_table_bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_table_openingbalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_table_aod;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_table_atype;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_table_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_table_password;
        private System.Windows.Forms.ComboBox account_bid;
    }
}
