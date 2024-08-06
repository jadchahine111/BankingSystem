
namespace Bankingsys
{
    partial class TransactionOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Transactions = new System.Windows.Forms.DataGridView();
            this.transactions_table_tnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactions_table_acnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_table_dot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_table_MediumOfTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_table_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_table_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Transactions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 620);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Overview";
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
            this.Transactions.Location = new System.Drawing.Point(20, 64);
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
            this.Transactions.Size = new System.Drawing.Size(793, 538);
            this.Transactions.TabIndex = 2;
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
            // TransactionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TransactionOverview";
            this.Size = new System.Drawing.Size(889, 675);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactions_table_tnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactions_table_acnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_table_dot;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_table_MediumOfTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_table_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_table_amount;
    }
}
