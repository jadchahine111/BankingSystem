
namespace Bankingsys
{
    partial class pay_load_account
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
            this.label2 = new System.Windows.Forms.Label();
            this.Clear3 = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.pay_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Clear3);
            this.panel1.Controls.Add(this.Pay);
            this.panel1.Controls.Add(this.pay_amount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(181, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 344);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pay";
            // 
            // Clear3
            // 
            this.Clear3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Clear3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear3.Location = new System.Drawing.Point(306, 238);
            this.Clear3.Name = "Clear3";
            this.Clear3.Size = new System.Drawing.Size(136, 44);
            this.Clear3.TabIndex = 15;
            this.Clear3.Text = "Clear";
            this.Clear3.UseVisualStyleBackColor = false;
            this.Clear3.Click += new System.EventHandler(this.Clear3_Click);
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pay.Location = new System.Drawing.Point(103, 239);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(130, 43);
            this.Pay.TabIndex = 14;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // pay_amount
            // 
            this.pay_amount.Location = new System.Drawing.Point(265, 142);
            this.pay_amount.Multiline = true;
            this.pay_amount.Name = "pay_amount";
            this.pay_amount.Size = new System.Drawing.Size(177, 26);
            this.pay_amount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(103, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // pay_load_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "pay_load_account";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(889, 675);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear3;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.TextBox pay_amount;
        private System.Windows.Forms.Label label5;
    }
}
