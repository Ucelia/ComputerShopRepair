namespace ComputerShopRepair
{
    partial class sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDgv = new System.Windows.Forms.DataGridView();
            this.gobackLink = new System.Windows.Forms.LinkLabel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(102, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 77);
            this.panel1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUZ Ltd Shop Sales";
            // 
            // orderDgv
            // 
            this.orderDgv.AllowUserToAddRows = false;
            this.orderDgv.AllowUserToDeleteRows = false;
            this.orderDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDgv.Location = new System.Drawing.Point(102, 182);
            this.orderDgv.Name = "orderDgv";
            this.orderDgv.ReadOnly = true;
            this.orderDgv.RowTemplate.Height = 28;
            this.orderDgv.Size = new System.Drawing.Size(742, 323);
            this.orderDgv.TabIndex = 64;
            // 
            // gobackLink
            // 
            this.gobackLink.AutoSize = true;
            this.gobackLink.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackLink.LinkColor = System.Drawing.Color.RoyalBlue;
            this.gobackLink.Location = new System.Drawing.Point(427, 610);
            this.gobackLink.Name = "gobackLink";
            this.gobackLink.Size = new System.Drawing.Size(187, 19);
            this.gobackLink.TabIndex = 65;
            this.gobackLink.TabStop = true;
            this.gobackLink.Text = "<Go to previous Page";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logoutBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(457, 556);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(118, 51);
            this.logoutBtn.TabIndex = 68;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 653);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.gobackLink);
            this.Controls.Add(this.orderDgv);
            this.Controls.Add(this.panel1);
            this.Name = "sales";
            this.Text = "sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderDgv;
        private System.Windows.Forms.LinkLabel gobackLink;
        private System.Windows.Forms.Button logoutBtn;
    }
}