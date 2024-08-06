
namespace Bankingsys
{
    partial class transfer_personal_account
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear3 = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.transfer_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.transfers_accID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.transfers_accID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Clear3);
            this.panel1.Controls.Add(this.Transfer);
            this.panel1.Controls.Add(this.transfer_amount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(154, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 368);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(51, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 27);
            this.label9.TabIndex = 25;
            this.label9.Text = "Account ID (dest)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Transfer";
            // 
            // Clear3
            // 
            this.Clear3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Clear3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear3.Location = new System.Drawing.Point(306, 269);
            this.Clear3.Name = "Clear3";
            this.Clear3.Size = new System.Drawing.Size(136, 44);
            this.Clear3.TabIndex = 15;
            this.Clear3.Text = "Clear";
            this.Clear3.UseVisualStyleBackColor = false;
            this.Clear3.Click += new System.EventHandler(this.Clear3_Click);
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Transfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Transfer.Location = new System.Drawing.Point(103, 269);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(130, 43);
            this.Transfer.TabIndex = 14;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = false;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // transfer_amount
            // 
            this.transfer_amount.Location = new System.Drawing.Point(306, 178);
            this.transfer_amount.Multiline = true;
            this.transfer_amount.Name = "transfer_amount";
            this.transfer_amount.Size = new System.Drawing.Size(177, 36);
            this.transfer_amount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(98, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // transfers_accID
            // 
            this.transfers_accID.Location = new System.Drawing.Point(306, 101);
            this.transfers_accID.Multiline = true;
            this.transfers_accID.Name = "transfers_accID";
            this.transfers_accID.Size = new System.Drawing.Size(177, 36);
            this.transfers_accID.TabIndex = 26;
            // 
            // transfer_personal_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "transfer_personal_account";
            this.Size = new System.Drawing.Size(889, 675);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear3;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.TextBox transfer_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox transfers_accID;
    }
}
