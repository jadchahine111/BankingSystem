
namespace Bankingsys
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        /// 


        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label TotalAccounts_lbl;
        private System.Windows.Forms.Label TotalTransactions_lbl;
        private System.Windows.Forms.Label TotalLoans_lbl;



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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            TotalAccounts_lbl = new System.Windows.Forms.Label();
            TotalLoans_lbl = new System.Windows.Forms.Label();
            this.TotalTransactions_lbl = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(71, 96);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 24);
            label1.TabIndex = 1;
            label1.Text = "Total Accounts";
            // 
            // TotalAccounts_lbl
            // 
            TotalAccounts_lbl.AutoSize = true;
            TotalAccounts_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TotalAccounts_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            TotalAccounts_lbl.Location = new System.Drawing.Point(206, 26);
            TotalAccounts_lbl.Name = "TotalAccounts_lbl";
            TotalAccounts_lbl.Size = new System.Drawing.Size(23, 24);
            TotalAccounts_lbl.TabIndex = 2;
            TotalAccounts_lbl.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(110, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(124, 24);
            label3.TabIndex = 4;
            label3.Text = "Total Loans";
            label3.Click += new System.EventHandler(this.label3_Click);
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
            // TotalLoans_lbl
            // 
            TotalLoans_lbl.AutoSize = true;
            TotalLoans_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TotalLoans_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            TotalLoans_lbl.Location = new System.Drawing.Point(211, 26);
            TotalLoans_lbl.Name = "TotalLoans_lbl";
            TotalLoans_lbl.Size = new System.Drawing.Size(23, 24);
            TotalLoans_lbl.TabIndex = 5;
            TotalLoans_lbl.Text = "0";
            // 
            // TotalTransactions_lbl
            // 
            TotalTransactions_lbl.AutoSize = true;
            TotalTransactions_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TotalTransactions_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            TotalTransactions_lbl.Location = new System.Drawing.Point(213, 26);
            TotalTransactions_lbl.Name = "TotalTransactions_lbl";
            TotalTransactions_lbl.Size = new System.Drawing.Size(23, 24);
            TotalTransactions_lbl.TabIndex = 5;
            TotalTransactions_lbl.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(19, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 219);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(TotalTransactions_lbl);
            this.panel5.Controls.Add(label4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(539, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 134);
            this.panel5.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(14, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(TotalLoans_lbl);
            this.panel4.Controls.Add(label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(283, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 134);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(19, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(TotalAccounts_lbl);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(33, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 134);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(19, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 364);
            this.panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(889, 675);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}
