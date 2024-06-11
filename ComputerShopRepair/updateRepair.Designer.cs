namespace ComputerShopRepair
{
    partial class updateRepair
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
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.requestDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.gobackLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.requestDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusCombo
            // 
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "Approved",
            "Denied"});
            this.statusCombo.Location = new System.Drawing.Point(265, 176);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(458, 28);
            this.statusCombo.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 64;
            this.label7.Text = "Status";
            // 
            // requestDgv
            // 
            this.requestDgv.AllowUserToAddRows = false;
            this.requestDgv.AllowUserToDeleteRows = false;
            this.requestDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDgv.Location = new System.Drawing.Point(110, 343);
            this.requestDgv.Name = "requestDgv";
            this.requestDgv.ReadOnly = true;
            this.requestDgv.RowTemplate.Height = 28;
            this.requestDgv.Size = new System.Drawing.Size(782, 288);
            this.requestDgv.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(110, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 77);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Repair Requests";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(632, 254);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(118, 51);
            this.backBtn.TabIndex = 67;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(265, 254);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(118, 51);
            this.submitBtn.TabIndex = 66;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            // 
            // gobackLink
            // 
            this.gobackLink.AutoSize = true;
            this.gobackLink.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gobackLink.LinkColor = System.Drawing.Color.RoyalBlue;
            this.gobackLink.Location = new System.Drawing.Point(825, 310);
            this.gobackLink.Name = "gobackLink";
            this.gobackLink.Size = new System.Drawing.Size(67, 19);
            this.gobackLink.TabIndex = 68;
            this.gobackLink.TabStop = true;
            this.gobackLink.Text = "Logout";
            // 
            // updateRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 689);
            this.Controls.Add(this.gobackLink);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.statusCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.requestDgv);
            this.Controls.Add(this.panel1);
            this.Name = "updateRepair";
            this.Text = "updateRepair";
            ((System.ComponentModel.ISupportInitialize)(this.requestDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView requestDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.LinkLabel gobackLink;
    }
}