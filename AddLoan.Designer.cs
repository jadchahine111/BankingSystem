
namespace Bankingsys
{
    partial class AddLoan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.loan_accId = new System.Windows.Forms.ComboBox();
            this.loan_Delete = new System.Windows.Forms.Button();
            this.loan_Clear = new System.Windows.Forms.Button();
            this.loan_Update = new System.Windows.Forms.Button();
            this.loan_Add = new System.Windows.Forms.Button();
            this.loan_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Loans = new System.Windows.Forms.DataGridView();
            this.loan_table_acnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loan_table_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loans)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.loan_accId);
            this.panel2.Controls.Add(this.loan_Delete);
            this.panel2.Controls.Add(this.loan_Clear);
            this.panel2.Controls.Add(this.loan_Update);
            this.panel2.Controls.Add(this.loan_Add);
            this.panel2.Controls.Add(this.loan_amount);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 209);
            this.panel2.TabIndex = 5;
            // 
            // loan_accId
            // 
            this.loan_accId.FormattingEnabled = true;
            this.loan_accId.Location = new System.Drawing.Point(159, 43);
            this.loan_accId.Name = "loan_accId";
            this.loan_accId.Size = new System.Drawing.Size(232, 28);
            this.loan_accId.TabIndex = 23;
            // 
            // loan_Delete
            // 
            this.loan_Delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.loan_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loan_Delete.Location = new System.Drawing.Point(668, 122);
            this.loan_Delete.Name = "loan_Delete";
            this.loan_Delete.Size = new System.Drawing.Size(144, 55);
            this.loan_Delete.TabIndex = 16;
            this.loan_Delete.Text = "Delete";
            this.loan_Delete.UseVisualStyleBackColor = false;
            this.loan_Delete.Click += new System.EventHandler(this.loan_Delete_Click);
            // 
            // loan_Clear
            // 
            this.loan_Clear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.loan_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loan_Clear.Location = new System.Drawing.Point(462, 122);
            this.loan_Clear.Name = "loan_Clear";
            this.loan_Clear.Size = new System.Drawing.Size(151, 55);
            this.loan_Clear.TabIndex = 15;
            this.loan_Clear.Text = "Clear";
            this.loan_Clear.UseVisualStyleBackColor = false;
            this.loan_Clear.Click += new System.EventHandler(this.loan_Clear_Click);
            // 
            // loan_Update
            // 
            this.loan_Update.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.loan_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loan_Update.Location = new System.Drawing.Point(228, 122);
            this.loan_Update.Name = "loan_Update";
            this.loan_Update.Size = new System.Drawing.Size(154, 55);
            this.loan_Update.TabIndex = 14;
            this.loan_Update.Text = "Update";
            this.loan_Update.UseVisualStyleBackColor = false;
            this.loan_Update.Click += new System.EventHandler(this.loan_Update_Click);
            // 
            // loan_Add
            // 
            this.loan_Add.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.loan_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loan_Add.Location = new System.Drawing.Point(20, 122);
            this.loan_Add.Name = "loan_Add";
            this.loan_Add.Size = new System.Drawing.Size(143, 55);
            this.loan_Add.TabIndex = 13;
            this.loan_Add.Text = "Add";
            this.loan_Add.UseVisualStyleBackColor = false;
            this.loan_Add.Click += new System.EventHandler(this.loan_Add_Click);
            // 
            // loan_amount
            // 
            this.loan_amount.Location = new System.Drawing.Point(580, 36);
            this.loan_amount.Multiline = true;
            this.loan_amount.Name = "loan_amount";
            this.loan_amount.Size = new System.Drawing.Size(232, 35);
            this.loan_amount.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(457, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Loans);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 401);
            this.panel1.TabIndex = 4;
            // 
            // Loans
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Loans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Loans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Loans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Loans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loan_table_acnumber,
            this.loan_table_amount});
            this.Loans.Location = new System.Drawing.Point(20, 62);
            this.Loans.MultiSelect = false;
            this.Loans.Name = "Loans";
            this.Loans.ReadOnly = true;
            this.Loans.RowHeadersVisible = false;
            this.Loans.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Loans.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Loans.RowTemplate.Height = 28;
            this.Loans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Loans.Size = new System.Drawing.Size(792, 315);
            this.Loans.TabIndex = 2;
            this.Loans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Loans_CellClick);
            // 
            // loan_table_acnumber
            // 
            this.loan_table_acnumber.HeaderText = "Acc. Number";
            this.loan_table_acnumber.MinimumWidth = 8;
            this.loan_table_acnumber.Name = "loan_table_acnumber";
            this.loan_table_acnumber.ReadOnly = true;
            this.loan_table_acnumber.Width = 150;
            // 
            // loan_table_amount
            // 
            this.loan_table_amount.HeaderText = "Loan Amount";
            this.loan_table_amount.MinimumWidth = 8;
            this.loan_table_amount.Name = "loan_table_amount";
            this.loan_table_amount.ReadOnly = true;
            this.loan_table_amount.Width = 150;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loans Data";
            // 
            // AddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddLoan";
            this.Size = new System.Drawing.Size(889, 675);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Loans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loan_Delete;
        private System.Windows.Forms.Button loan_Clear;
        private System.Windows.Forms.Button loan_Update;
        private System.Windows.Forms.Button loan_Add;
        private System.Windows.Forms.TextBox loan_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Loans;
        private System.Windows.Forms.ComboBox loan_accId;
        private System.Windows.Forms.DataGridViewTextBoxColumn loan_table_acnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn loan_table_amount;
    }
}
