namespace ComputerShopRepair
{
    partial class customerRequest
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.orderDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compModelCombo = new System.Windows.Forms.ComboBox();
            this.repairBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logoutBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(731, 272);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(118, 51);
            this.logoutBtn.TabIndex = 67;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.orderBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.orderBtn.ForeColor = System.Drawing.Color.White;
            this.orderBtn.Location = new System.Drawing.Point(731, 123);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(118, 51);
            this.orderBtn.TabIndex = 66;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // orderDgv
            // 
            this.orderDgv.AllowUserToAddRows = false;
            this.orderDgv.AllowUserToDeleteRows = false;
            this.orderDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDgv.Location = new System.Drawing.Point(107, 362);
            this.orderDgv.Name = "orderDgv";
            this.orderDgv.ReadOnly = true;
            this.orderDgv.RowTemplate.Height = 28;
            this.orderDgv.Size = new System.Drawing.Size(742, 258);
            this.orderDgv.TabIndex = 63;
            this.orderDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDgv_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(110, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 77);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUZ Ltd Shop Services";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(107, 161);
            this.fullNameBox.Multiline = true;
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(319, 46);
            this.fullNameBox.TabIndex = 71;
            this.fullNameBox.TextChanged += new System.EventHandler(this.fullNameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 70;
            this.label4.Text = "Full Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Computer Model";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // compModelCombo
            // 
            this.compModelCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compModelCombo.FormattingEnabled = true;
            this.compModelCombo.Items.AddRange(new object[] {
            "HP",
            "Dell",
            "Azus"});
            this.compModelCombo.Location = new System.Drawing.Point(107, 276);
            this.compModelCombo.Name = "compModelCombo";
            this.compModelCombo.Size = new System.Drawing.Size(319, 40);
            this.compModelCombo.TabIndex = 72;
            this.compModelCombo.SelectedIndexChanged += new System.EventHandler(this.compModelCombo_SelectedIndexChanged);
            // 
            // repairBtn
            // 
            this.repairBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.repairBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.repairBtn.ForeColor = System.Drawing.Color.White;
            this.repairBtn.Location = new System.Drawing.Point(731, 195);
            this.repairBtn.Name = "repairBtn";
            this.repairBtn.Size = new System.Drawing.Size(118, 51);
            this.repairBtn.TabIndex = 74;
            this.repairBtn.Text = "Repair";
            this.repairBtn.UseVisualStyleBackColor = false;
            this.repairBtn.Click += new System.EventHandler(this.repairBtn_Click);
            // 
            // customerRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 642);
            this.Controls.Add(this.repairBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compModelCombo);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.orderDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.label4);
            this.Name = "customerRequest";
            this.Text = "customerRequest";
            this.Load += new System.EventHandler(this.customerRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView orderDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox compModelCombo;
        private System.Windows.Forms.Button repairBtn;
    }
}