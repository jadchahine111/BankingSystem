
namespace Bankingsys
{
    partial class AddBranch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.branch_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.branch_Delete = new System.Windows.Forms.Button();
            this.branch_Clear = new System.Windows.Forms.Button();
            this.branch_Update = new System.Windows.Forms.Button();
            this.branch_Add = new System.Windows.Forms.Button();
            this.branch_city = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Branches = new System.Windows.Forms.DataGridView();
            this.branch_table_bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_table_bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_table_bcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Branches)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.branch_name);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.branch_Delete);
            this.panel2.Controls.Add(this.branch_Clear);
            this.panel2.Controls.Add(this.branch_Update);
            this.panel2.Controls.Add(this.branch_Add);
            this.panel2.Controls.Add(this.branch_city);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 189);
            this.panel2.TabIndex = 3;
            // 
            // branch_name
            // 
            this.branch_name.Location = new System.Drawing.Point(104, 23);
            this.branch_name.Multiline = true;
            this.branch_name.Name = "branch_name";
            this.branch_name.Size = new System.Drawing.Size(232, 35);
            this.branch_name.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "Name";
            // 
            // branch_Delete
            // 
            this.branch_Delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.branch_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.branch_Delete.Location = new System.Drawing.Point(666, 100);
            this.branch_Delete.Name = "branch_Delete";
            this.branch_Delete.Size = new System.Drawing.Size(144, 55);
            this.branch_Delete.TabIndex = 16;
            this.branch_Delete.Text = "Delete";
            this.branch_Delete.UseVisualStyleBackColor = false;
            this.branch_Delete.Click += new System.EventHandler(this.branch_Delete_Click);
            // 
            // branch_Clear
            // 
            this.branch_Clear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.branch_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.branch_Clear.Location = new System.Drawing.Point(450, 100);
            this.branch_Clear.Name = "branch_Clear";
            this.branch_Clear.Size = new System.Drawing.Size(151, 55);
            this.branch_Clear.TabIndex = 15;
            this.branch_Clear.Text = "Clear";
            this.branch_Clear.UseVisualStyleBackColor = false;
            this.branch_Clear.Click += new System.EventHandler(this.branch_Clear_Click);
            // 
            // branch_Update
            // 
            this.branch_Update.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.branch_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.branch_Update.Location = new System.Drawing.Point(226, 100);
            this.branch_Update.Name = "branch_Update";
            this.branch_Update.Size = new System.Drawing.Size(154, 55);
            this.branch_Update.TabIndex = 14;
            this.branch_Update.Text = "Update";
            this.branch_Update.UseVisualStyleBackColor = false;
            this.branch_Update.Click += new System.EventHandler(this.branch_Update_Click);
            // 
            // branch_Add
            // 
            this.branch_Add.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.branch_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.branch_Add.Location = new System.Drawing.Point(20, 100);
            this.branch_Add.Name = "branch_Add";
            this.branch_Add.Size = new System.Drawing.Size(143, 55);
            this.branch_Add.TabIndex = 13;
            this.branch_Add.Text = "Add";
            this.branch_Add.UseVisualStyleBackColor = false;
            this.branch_Add.Click += new System.EventHandler(this.branch_Add_Click);
            // 
            // branch_city
            // 
            this.branch_city.Location = new System.Drawing.Point(581, 23);
            this.branch_city.Multiline = true;
            this.branch_city.Name = "branch_city";
            this.branch_city.Size = new System.Drawing.Size(231, 35);
            this.branch_city.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(503, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "City";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Branches);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 417);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Data";
            // 
            // Branches
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.Branches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Branches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Branches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branch_table_bid,
            this.branch_table_bname,
            this.branch_table_bcity});
            this.Branches.Location = new System.Drawing.Point(20, 51);
            this.Branches.MultiSelect = false;
            this.Branches.Name = "Branches";
            this.Branches.ReadOnly = true;
            this.Branches.RowHeadersVisible = false;
            this.Branches.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.Branches.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.Branches.RowTemplate.Height = 28;
            this.Branches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Branches.Size = new System.Drawing.Size(792, 341);
            this.Branches.TabIndex = 3;
            this.Branches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Branch_CellClick);
            // 
            // branch_table_bid
            // 
            this.branch_table_bid.HeaderText = "Branch ID";
            this.branch_table_bid.MinimumWidth = 8;
            this.branch_table_bid.Name = "branch_table_bid";
            this.branch_table_bid.ReadOnly = true;
            this.branch_table_bid.Width = 150;
            // 
            // branch_table_bname
            // 
            this.branch_table_bname.HeaderText = "Name";
            this.branch_table_bname.MinimumWidth = 8;
            this.branch_table_bname.Name = "branch_table_bname";
            this.branch_table_bname.ReadOnly = true;
            this.branch_table_bname.Width = 150;
            // 
            // branch_table_bcity
            // 
            this.branch_table_bcity.HeaderText = "City";
            this.branch_table_bcity.MinimumWidth = 8;
            this.branch_table_bcity.Name = "branch_table_bcity";
            this.branch_table_bcity.ReadOnly = true;
            this.branch_table_bcity.Width = 150;
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBranch";
            this.Size = new System.Drawing.Size(889, 675);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Branches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox branch_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button branch_Delete;
        private System.Windows.Forms.Button branch_Clear;
        private System.Windows.Forms.Button branch_Update;
        private System.Windows.Forms.Button branch_Add;
        private System.Windows.Forms.TextBox branch_city;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Branches;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_table_bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_table_bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_table_bcity;
    }
}
