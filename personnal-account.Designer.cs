
namespace Bankingsys
{
    partial class personnal_account
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.accName_label = new System.Windows.Forms.Label();
            this.AddBranch_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout_btn1 = new System.Windows.Forms.Button();
            this.TransactionOverview_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.info_personal_account1 = new Bankingsys.info_personal_account();
            this.transfer_personal_account1 = new Bankingsys.transfer_personal_account();
            this.dashboard_personal_account1 = new Bankingsys.dashboard_personal_account();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.accName_label);
            this.panel2.Controls.Add(this.AddBranch_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.logout_btn1);
            this.panel2.Controls.Add(this.TransactionOverview_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 677);
            this.panel2.TabIndex = 2;
            // 
            // accName_label
            // 
            this.accName_label.AutoSize = true;
            this.accName_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accName_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accName_label.Location = new System.Drawing.Point(113, 201);
            this.accName_label.Name = "accName_label";
            this.accName_label.Size = new System.Drawing.Size(83, 29);
            this.accName_label.TabIndex = 10;
            this.accName_label.Text = "Name";
            // 
            // AddBranch_btn
            // 
            this.AddBranch_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddBranch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBranch_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBranch_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBranch_btn.Location = new System.Drawing.Point(-10, 415);
            this.AddBranch_btn.Name = "AddBranch_btn";
            this.AddBranch_btn.Size = new System.Drawing.Size(349, 62);
            this.AddBranch_btn.TabIndex = 9;
            this.AddBranch_btn.Text = "Account Information";
            this.AddBranch_btn.UseVisualStyleBackColor = false;
            this.AddBranch_btn.Click += new System.EventHandler(this.AddBranch_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Management System";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(330, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 805);
            this.panel3.TabIndex = 2;
            // 
            // logout_btn1
            // 
            this.logout_btn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.logout_btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_btn1.Location = new System.Drawing.Point(12, 620);
            this.logout_btn1.Name = "logout_btn1";
            this.logout_btn1.Size = new System.Drawing.Size(113, 43);
            this.logout_btn1.TabIndex = 8;
            this.logout_btn1.Text = "logout";
            this.logout_btn1.UseVisualStyleBackColor = false;
            this.logout_btn1.Click += new System.EventHandler(this.logout_btn1_Click);
            // 
            // TransactionOverview_btn
            // 
            this.TransactionOverview_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TransactionOverview_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransactionOverview_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionOverview_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransactionOverview_btn.Location = new System.Drawing.Point(-10, 347);
            this.TransactionOverview_btn.Name = "TransactionOverview_btn";
            this.TransactionOverview_btn.Size = new System.Drawing.Size(349, 62);
            this.TransactionOverview_btn.TabIndex = 7;
            this.TransactionOverview_btn.Text = "Transfer";
            this.TransactionOverview_btn.UseVisualStyleBackColor = false;
            this.TransactionOverview_btn.Click += new System.EventHandler(this.TransactionOverview_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboard_btn.Location = new System.Drawing.Point(-10, 279);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(349, 62);
            this.dashboard_btn.TabIndex = 5;
            this.dashboard_btn.Text = "Overview/Transactions";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 110);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(92, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome,";
            // 
            // info_personal_account1
            // 
            this.info_personal_account1.Location = new System.Drawing.Point(324, -1);
            this.info_personal_account1.Name = "info_personal_account1";
            this.info_personal_account1.Size = new System.Drawing.Size(889, 675);
            this.info_personal_account1.TabIndex = 3;
            // 
            // transfer_personal_account1
            // 
            this.transfer_personal_account1.Location = new System.Drawing.Point(324, -1);
            this.transfer_personal_account1.Name = "transfer_personal_account1";
            this.transfer_personal_account1.Size = new System.Drawing.Size(889, 675);
            this.transfer_personal_account1.TabIndex = 4;
            // 
            // dashboard_personal_account1
            // 
            this.dashboard_personal_account1.Location = new System.Drawing.Point(324, 0);
            this.dashboard_personal_account1.Name = "dashboard_personal_account1";
            this.dashboard_personal_account1.Size = new System.Drawing.Size(889, 675);
            this.dashboard_personal_account1.TabIndex = 5;
            // 
            // personnal_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 677);
            this.Controls.Add(this.dashboard_personal_account1);
            this.Controls.Add(this.transfer_personal_account1);
            this.Controls.Add(this.info_personal_account1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "personnal_account";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personnal_account";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddBranch_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logout_btn1;
        private System.Windows.Forms.Button TransactionOverview_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accName_label;
        private info_personal_account info_personal_account1;
        private transfer_personal_account transfer_personal_account1;
        private dashboard_personal_account dashboard_personal_account1;
    }
}