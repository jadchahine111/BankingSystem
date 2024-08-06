
namespace Bankingsys
{
    partial class dashboard_personal_account
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label Balance;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TotalTransactions_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Balance_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Transactions = new System.Windows.Forms.DataGridView();
            this.transactions_table_tnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactions_table_acnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_table_dot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_table_MediumOfTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_table_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_table_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            Balance = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(42, 96);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(194, 24);
            label4.TabIndex = 4;
            label4.Text = "Total Transactions";
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Balance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Balance.Location = new System.Drawing.Point(139, 96);
            Balance.Name = "Balance";
            Balance.Size = new System.Drawing.Size(90, 24);
            Balance.TabIndex = 1;
            Balance.Text = "Balance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(26, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 219);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.TotalTransactions_lbl);
            this.panel5.Controls.Add(label4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(467, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 134);
            this.panel5.TabIndex = 2;
            // 
            // TotalTransactions_lbl
            // 
            this.TotalTransactions_lbl.AutoSize = true;
            this.TotalTransactions_lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTransactions_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalTransactions_lbl.Location = new System.Drawing.Point(186, 28);
            this.TotalTransactions_lbl.Name = "TotalTransactions_lbl";
            this.TotalTransactions_lbl.Size = new System.Drawing.Size(64, 22);
            this.TotalTransactions_lbl.TabIndex = 5;
            this.TotalTransactions_lbl.Text = "label5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.Balance_lbl);
            this.panel3.Controls.Add(Balance);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(84, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 134);
            this.panel3.TabIndex = 0;
            // 
            // Balance_lbl
            // 
            this.Balance_lbl.AutoSize = true;
            this.Balance_lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Balance_lbl.Location = new System.Drawing.Point(121, 28);
            this.Balance_lbl.Name = "Balance_lbl";
            this.Balance_lbl.Size = new System.Drawing.Size(64, 22);
            this.Balance_lbl.TabIndex = 4;
            this.Balance_lbl.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.Transactions);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(26, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 382);
            this.panel2.TabIndex = 2;
            // 
            // Transactions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Transactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactions_table_tnumber,
            this.transactions_table_acnumber,
            this.transaction_table_dot,
            this.transaction_table_MediumOfTransaction,
            this.transaction_table_type,
            this.transaction_table_amount});
            this.Transactions.Location = new System.Drawing.Point(20, 54);
            this.Transactions.MultiSelect = false;
            this.Transactions.Name = "Transactions";
            this.Transactions.ReadOnly = true;
            this.Transactions.RowHeadersVisible = false;
            this.Transactions.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Transactions.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Transactions.RowTemplate.Height = 28;
            this.Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Transactions.Size = new System.Drawing.Size(787, 311);
            this.Transactions.TabIndex = 3;
            // 
            // transactions_table_tnumber
            // 
            this.transactions_table_tnumber.HeaderText = "T. Number";
            this.transactions_table_tnumber.MinimumWidth = 8;
            this.transactions_table_tnumber.Name = "transactions_table_tnumber";
            this.transactions_table_tnumber.ReadOnly = true;
            this.transactions_table_tnumber.Width = 150;
            // 
            // transactions_table_acnumber
            // 
            this.transactions_table_acnumber.HeaderText = "Acc. Number";
            this.transactions_table_acnumber.MinimumWidth = 8;
            this.transactions_table_acnumber.Name = "transactions_table_acnumber";
            this.transactions_table_acnumber.ReadOnly = true;
            this.transactions_table_acnumber.Width = 150;
            // 
            // transaction_table_dot
            // 
            this.transaction_table_dot.HeaderText = "T. Date";
            this.transaction_table_dot.MinimumWidth = 8;
            this.transaction_table_dot.Name = "transaction_table_dot";
            this.transaction_table_dot.ReadOnly = true;
            this.transaction_table_dot.Width = 150;
            // 
            // transaction_table_MediumOfTransaction
            // 
            this.transaction_table_MediumOfTransaction.HeaderText = "Tran. Medium";
            this.transaction_table_MediumOfTransaction.MinimumWidth = 8;
            this.transaction_table_MediumOfTransaction.Name = "transaction_table_MediumOfTransaction";
            this.transaction_table_MediumOfTransaction.ReadOnly = true;
            this.transaction_table_MediumOfTransaction.Width = 150;
            // 
            // transaction_table_type
            // 
            this.transaction_table_type.HeaderText = "Type";
            this.transaction_table_type.MinimumWidth = 8;
            this.transaction_table_type.Name = "transaction_table_type";
            this.transaction_table_type.ReadOnly = true;
            this.transaction_table_type.Width = 150;
            // 
            // transaction_table_amount
            // 
            this.transaction_table_amount.HeaderText = "Amount";
            this.transaction_table_amount.MinimumWidth = 8;
            this.transaction_table_amount.Name = "transaction_table_amount";
            this.transaction_table_amount.ReadOnly = true;
            this.transaction_table_amount.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction History";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(14, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard_personal_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard_personal_account";
            this.Size = new System.Drawing.Size(889, 675);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactions_table_tnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactions_table_acnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_table_dot;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_table_MediumOfTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_table_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_table_amount;
        private System.Windows.Forms.Label TotalTransactions_lbl;
        private System.Windows.Forms.Label Balance_lbl;
    }
}
