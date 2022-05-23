namespace thuchanh2
{
    partial class DonHangCuaToi
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
            this.btnQRSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDangXuLy = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCenter = new Guna.UI2.WinForms.Guna2Panel();
            this.flowDonHang = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQRSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.btnDangXuLy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnQRSearch
            // 
            this.btnQRSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnQRSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQRSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQRSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQRSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQRSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQRSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnQRSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQRSearch.ForeColor = System.Drawing.Color.Black;
            this.btnQRSearch.Image = global::thuchanh2.Properties.Resources.search;
            this.btnQRSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnQRSearch.Location = new System.Drawing.Point(698, 12);
            this.btnQRSearch.Name = "btnQRSearch";
            this.btnQRSearch.Size = new System.Drawing.Size(63, 36);
            this.btnQRSearch.TabIndex = 4;
            this.btnQRSearch.Text = "QR";
            this.btnQRSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQRSearch.Click += new System.EventHandler(this.btnQRSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::thuchanh2.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(663, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSearch.BorderColor = System.Drawing.Color.Wheat;
            this.textBoxSearch.BorderRadius = 8;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FillColor = System.Drawing.Color.Wheat;
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Location = new System.Drawing.Point(412, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(245, 36);
            this.textBoxSearch.TabIndex = 2;
            // 
            // btnDangXuLy
            // 
            this.btnDangXuLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuLy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuLy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuLy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuLy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuLy.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuLy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuLy.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuLy.Location = new System.Drawing.Point(12, 6);
            this.btnDangXuLy.Name = "btnDangXuLy";
            this.btnDangXuLy.Size = new System.Drawing.Size(180, 45);
            this.btnDangXuLy.TabIndex = 1;
            this.btnDangXuLy.Text = "Đang Xử Lý";
            this.btnDangXuLy.Click += new System.EventHandler(this.btnDangXuLy_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.flowDonHang);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 54);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(791, 396);
            this.pnlCenter.TabIndex = 1;
            // 
            // flowDonHang
            // 
            this.flowDonHang.AutoScroll = true;
            this.flowDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDonHang.Location = new System.Drawing.Point(0, 0);
            this.flowDonHang.Name = "flowDonHang";
            this.flowDonHang.Size = new System.Drawing.Size(791, 396);
            this.flowDonHang.TabIndex = 0;
            // 
            // DonHangCuaToi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(807, 489);
            this.MinimumSize = new System.Drawing.Size(807, 489);
            this.Name = "DonHangCuaToi";
            this.Text = "DonHangCuaToi";
            this.panel1.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDangXuLy;
        private System.Windows.Forms.FlowLayoutPanel flowDonHang;
        public Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        public Guna.UI2.WinForms.Guna2Button btnQRSearch;
        public Guna.UI2.WinForms.Guna2Button btnSearch;
        public Guna.UI2.WinForms.Guna2Panel pnlCenter;
    }
}