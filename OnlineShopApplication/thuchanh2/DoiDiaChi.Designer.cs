namespace thuchanh2
{
    partial class DoiDiaChi
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
            this.pnlDoiDiaChi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuThayDoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDoiDiaChi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDoiDiaChi
            // 
            this.pnlDoiDiaChi.BackColor = System.Drawing.Color.White;
            this.pnlDoiDiaChi.Controls.Add(this.btnHuy);
            this.pnlDoiDiaChi.Controls.Add(this.btnLuuThayDoi);
            this.pnlDoiDiaChi.Controls.Add(this.textBoxDiaChi);
            this.pnlDoiDiaChi.Controls.Add(this.label1);
            this.pnlDoiDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoiDiaChi.Location = new System.Drawing.Point(0, 0);
            this.pnlDoiDiaChi.Name = "pnlDoiDiaChi";
            this.pnlDoiDiaChi.Size = new System.Drawing.Size(665, 130);
            this.pnlDoiDiaChi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa Chi Mới:";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxDiaChi.BorderRadius = 8;
            this.textBoxDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDiaChi.DefaultText = "";
            this.textBoxDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDiaChi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.textBoxDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDiaChi.Location = new System.Drawing.Point(93, 30);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.PasswordChar = '\0';
            this.textBoxDiaChi.PlaceholderText = "";
            this.textBoxDiaChi.SelectedText = "";
            this.textBoxDiaChi.Size = new System.Drawing.Size(542, 36);
            this.textBoxDiaChi.TabIndex = 1;
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLuuThayDoi.BorderRadius = 10;
            this.btnLuuThayDoi.BorderThickness = 1;
            this.btnLuuThayDoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuThayDoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuThayDoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuThayDoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuThayDoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(496, 72);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(139, 37);
            this.btnLuuThayDoi.TabIndex = 2;
            this.btnLuuThayDoi.Text = "Lưu Thay Đổi";
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.BorderThickness = 1;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(395, 72);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 37);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // DoiDiaChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 130);
            this.Controls.Add(this.pnlDoiDiaChi);
            this.MaximumSize = new System.Drawing.Size(681, 169);
            this.MinimumSize = new System.Drawing.Size(681, 169);
            this.Name = "DoiDiaChi";
            this.Text = "DoiDiaChi";
            this.pnlDoiDiaChi.ResumeLayout(false);
            this.pnlDoiDiaChi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoiDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuuThayDoi;
    }
}