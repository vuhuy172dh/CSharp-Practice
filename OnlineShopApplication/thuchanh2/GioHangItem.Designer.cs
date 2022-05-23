namespace thuchanh2
{
    partial class GioHangItem
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
            this.lblNamItem = new System.Windows.Forms.Label();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.pnlButtonSoluong = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.btnIncrease = new Guna.UI2.WinForms.Guna2Button();
            this.btnDecrese = new Guna.UI2.WinForms.Guna2Button();
            this.lblGiaSau = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.lblNumb = new System.Windows.Forms.Label();
            this.pnlButtonSoluong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamItem
            // 
            this.lblNamItem.AutoSize = true;
            this.lblNamItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNamItem.Location = new System.Drawing.Point(122, 18);
            this.lblNamItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamItem.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblNamItem.Name = "lblNamItem";
            this.lblNamItem.Size = new System.Drawing.Size(45, 19);
            this.lblNamItem.TabIndex = 1;
            this.lblNamItem.Text = "Name";
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaGoc.Location = new System.Drawing.Point(329, 41);
            this.lblGiaGoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaGoc.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(26, 19);
            this.lblGiaGoc.TabIndex = 2;
            this.lblGiaGoc.Text = "0đ";
            // 
            // pnlButtonSoluong
            // 
            this.pnlButtonSoluong.BorderColor = System.Drawing.Color.Gray;
            this.pnlButtonSoluong.BorderThickness = 1;
            this.pnlButtonSoluong.Controls.Add(this.lblSoluong);
            this.pnlButtonSoluong.Controls.Add(this.btnIncrease);
            this.pnlButtonSoluong.Controls.Add(this.btnDecrese);
            this.pnlButtonSoluong.Location = new System.Drawing.Point(442, 37);
            this.pnlButtonSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtonSoluong.Name = "pnlButtonSoluong";
            this.pnlButtonSoluong.Size = new System.Drawing.Size(103, 27);
            this.pnlButtonSoluong.TabIndex = 12;
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoluong.Location = new System.Drawing.Point(44, 4);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(16, 18);
            this.lblSoluong.TabIndex = 2;
            this.lblSoluong.Text = "1";
            // 
            // btnIncrease
            // 
            this.btnIncrease.BorderColor = System.Drawing.Color.DimGray;
            this.btnIncrease.BorderThickness = 1;
            this.btnIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncrease.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncrease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncrease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncrease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncrease.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIncrease.FillColor = System.Drawing.Color.Transparent;
            this.btnIncrease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIncrease.ForeColor = System.Drawing.Color.Black;
            this.btnIncrease.Image = global::thuchanh2.Properties.Resources.add;
            this.btnIncrease.Location = new System.Drawing.Point(72, 0);
            this.btnIncrease.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(31, 27);
            this.btnIncrease.TabIndex = 1;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrese
            // 
            this.btnDecrese.BorderColor = System.Drawing.Color.DimGray;
            this.btnDecrese.BorderThickness = 1;
            this.btnDecrese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrese.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrese.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrese.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrese.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrese.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDecrese.FillColor = System.Drawing.Color.Transparent;
            this.btnDecrese.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecrese.ForeColor = System.Drawing.Color.Black;
            this.btnDecrese.Image = global::thuchanh2.Properties.Resources.dash;
            this.btnDecrese.Location = new System.Drawing.Point(0, 0);
            this.btnDecrese.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecrese.Name = "btnDecrese";
            this.btnDecrese.Size = new System.Drawing.Size(31, 27);
            this.btnDecrese.TabIndex = 0;
            this.btnDecrese.Click += new System.EventHandler(this.btnDecrese_Click);
            // 
            // lblGiaSau
            // 
            this.lblGiaSau.AutoSize = true;
            this.lblGiaSau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaSau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lblGiaSau.Location = new System.Drawing.Point(584, 41);
            this.lblGiaSau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaSau.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblGiaSau.Name = "lblGiaSau";
            this.lblGiaSau.Size = new System.Drawing.Size(26, 19);
            this.lblGiaSau.TabIndex = 13;
            this.lblGiaSau.Text = "0đ";
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Image = global::thuchanh2.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(680, 28);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(32, 34);
            this.btnDel.TabIndex = 14;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(27, 2);
            this.picItem.Margin = new System.Windows.Forms.Padding(2);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(90, 100);
            this.picItem.TabIndex = 0;
            this.picItem.TabStop = false;
            // 
            // lblNumb
            // 
            this.lblNumb.AutoSize = true;
            this.lblNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumb.Location = new System.Drawing.Point(101, 84);
            this.lblNumb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumb.Name = "lblNumb";
            this.lblNumb.Size = new System.Drawing.Size(16, 18);
            this.lblNumb.TabIndex = 15;
            this.lblNumb.Text = "1";
            // 
            // GioHangItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNumb);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblGiaSau);
            this.Controls.Add(this.pnlButtonSoluong);
            this.Controls.Add(this.lblGiaGoc);
            this.Controls.Add(this.lblNamItem);
            this.Controls.Add(this.picItem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GioHangItem";
            this.Size = new System.Drawing.Size(734, 105);
            this.pnlButtonSoluong.ResumeLayout(false);
            this.pnlButtonSoluong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblSoluong;
        public Guna.UI2.WinForms.Guna2Button btnIncrease;
        public Guna.UI2.WinForms.Guna2Button btnDecrese;
        public System.Windows.Forms.PictureBox picItem;
        public System.Windows.Forms.Label lblNamItem;
        public System.Windows.Forms.Label lblGiaGoc;
        public Guna.UI2.WinForms.Guna2Panel pnlButtonSoluong;
        public System.Windows.Forms.Label lblGiaSau;
        public System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Label lblNumb;
    }
}
