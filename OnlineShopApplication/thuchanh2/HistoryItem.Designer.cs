namespace thuchanh2
{
    partial class HistoryItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSlx = new System.Windows.Forms.Label();
            this.lblNx = new System.Windows.Forms.Label();
            this.lblSoLanXem = new System.Windows.Forms.Label();
            this.lblNgayXem = new System.Windows.Forms.Label();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.lblLike = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.btnLike = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlSoLuongMua = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoLuongMua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.pnlSoLuongMua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(106, 3);
            this.lblName.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Brown;
            this.lblGia.Location = new System.Drawing.Point(106, 51);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(36, 22);
            this.lblGia.TabIndex = 5;
            this.lblGia.Text = "Giá";
            // 
            // lblSlx
            // 
            this.lblSlx.AutoSize = true;
            this.lblSlx.Enabled = false;
            this.lblSlx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSlx.Location = new System.Drawing.Point(106, 73);
            this.lblSlx.Name = "lblSlx";
            this.lblSlx.Size = new System.Drawing.Size(69, 15);
            this.lblSlx.TabIndex = 6;
            this.lblSlx.Text = "Số lần xem";
            // 
            // lblNx
            // 
            this.lblNx.AutoSize = true;
            this.lblNx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNx.Location = new System.Drawing.Point(107, 97);
            this.lblNx.Name = "lblNx";
            this.lblNx.Size = new System.Drawing.Size(62, 15);
            this.lblNx.TabIndex = 7;
            this.lblNx.Text = "Ngày xem";
            // 
            // lblSoLanXem
            // 
            this.lblSoLanXem.AutoSize = true;
            this.lblSoLanXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLanXem.Location = new System.Drawing.Point(184, 73);
            this.lblSoLanXem.Name = "lblSoLanXem";
            this.lblSoLanXem.Size = new System.Drawing.Size(14, 15);
            this.lblSoLanXem.TabIndex = 8;
            this.lblSoLanXem.Text = "0";
            // 
            // lblNgayXem
            // 
            this.lblNgayXem.AutoSize = true;
            this.lblNgayXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayXem.Location = new System.Drawing.Point(184, 97);
            this.lblNgayXem.Name = "lblNgayXem";
            this.lblNgayXem.Size = new System.Drawing.Size(14, 15);
            this.lblNgayXem.TabIndex = 9;
            this.lblNgayXem.Text = "0";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BorderColor = System.Drawing.Color.Brown;
            this.btnView.BorderRadius = 10;
            this.btnView.BorderThickness = 1;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnView.FillColor = System.Drawing.Color.Transparent;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnView.ForeColor = System.Drawing.Color.Brown;
            this.btnView.Location = new System.Drawing.Point(385, 42);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(116, 31);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLike.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLike.Location = new System.Drawing.Point(441, 85);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(37, 15);
            this.lblLike.TabIndex = 12;
            this.lblLike.Text = "Thích";
            this.lblLike.Click += new System.EventHandler(this.lblLike_Click);
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(3, 3);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(97, 109);
            this.picItem.TabIndex = 0;
            this.picItem.TabStop = false;
            // 
            // btnLike
            // 
            this.btnLike.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLike.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLike.Image = global::thuchanh2.Properties.Resources.like;
            this.btnLike.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLike.ImageRotate = 0F;
            this.btnLike.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLike.Location = new System.Drawing.Point(406, 79);
            this.btnLike.Name = "btnLike";
            this.btnLike.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLike.Size = new System.Drawing.Size(29, 29);
            this.btnLike.TabIndex = 14;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // pnlSoLuongMua
            // 
            this.pnlSoLuongMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnlSoLuongMua.BorderRadius = 3;
            this.pnlSoLuongMua.BorderThickness = 1;
            this.pnlSoLuongMua.Controls.Add(this.lblSoLuongMua);
            this.pnlSoLuongMua.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnlSoLuongMua.CustomizableEdges.BottomLeft = false;
            this.pnlSoLuongMua.CustomizableEdges.BottomRight = false;
            this.pnlSoLuongMua.CustomizableEdges.TopRight = false;
            this.pnlSoLuongMua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnlSoLuongMua.Location = new System.Drawing.Point(74, 87);
            this.pnlSoLuongMua.Name = "pnlSoLuongMua";
            this.pnlSoLuongMua.Size = new System.Drawing.Size(26, 25);
            this.pnlSoLuongMua.TabIndex = 15;
            this.pnlSoLuongMua.Visible = false;
            // 
            // lblSoLuongMua
            // 
            this.lblSoLuongMua.AutoSize = true;
            this.lblSoLuongMua.Location = new System.Drawing.Point(3, 7);
            this.lblSoLuongMua.Name = "lblSoLuongMua";
            this.lblSoLuongMua.Size = new System.Drawing.Size(18, 13);
            this.lblSoLuongMua.TabIndex = 0;
            this.lblSoLuongMua.Text = "x1";
            // 
            // HistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlSoLuongMua);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblLike);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblNgayXem);
            this.Controls.Add(this.lblSoLanXem);
            this.Controls.Add(this.lblNx);
            this.Controls.Add(this.lblSlx);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picItem);
            this.MaximumSize = new System.Drawing.Size(516, 116);
            this.MinimumSize = new System.Drawing.Size(516, 116);
            this.Name = "HistoryItem";
            this.Size = new System.Drawing.Size(516, 116);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.pnlSoLuongMua.ResumeLayout(false);
            this.pnlSoLuongMua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblGia;
        public System.Windows.Forms.Label lblSlx;
        public System.Windows.Forms.Label lblNx;
        public System.Windows.Forms.Label lblSoLanXem;
        public System.Windows.Forms.Label lblNgayXem;
        public Guna.UI2.WinForms.Guna2Button btnView;
        public System.Windows.Forms.PictureBox picItem;
        public System.Windows.Forms.Label lblLike;
        public Guna.UI2.WinForms.Guna2ImageButton btnLike;
        public Guna.UI2.WinForms.Guna2Panel pnlSoLuongMua;
        public System.Windows.Forms.Label lblSoLuongMua;
    }
}
