namespace thuchanh2
{
    partial class ShowItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowItem));
            this.picBoxShowItem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDaBan = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblDaBanContent = new System.Windows.Forms.Label();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxShowItem
            // 
            this.picBoxShowItem.BackColor = System.Drawing.Color.Transparent;
            this.picBoxShowItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picBoxShowItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxShowItem.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShowItem.Image")));
            this.picBoxShowItem.ImageRotate = 0F;
            this.picBoxShowItem.Location = new System.Drawing.Point(0, 0);
            this.picBoxShowItem.Name = "picBoxShowItem";
            this.picBoxShowItem.Size = new System.Drawing.Size(164, 130);
            this.picBoxShowItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxShowItem.TabIndex = 0;
            this.picBoxShowItem.TabStop = false;
           
            this.picBoxShowItem.MouseHover += new System.EventHandler(this.picBoxShowItem_MouseHover);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(119, 122);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(8, 8);
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            
            this.lblName.MouseHover += new System.EventHandler(this.lblName_MouseHover);
            // 
            // lblDaBan
            // 
            this.lblDaBan.AutoSize = true;
            this.lblDaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDaBan.Location = new System.Drawing.Point(4, 155);
            this.lblDaBan.Name = "lblDaBan";
            this.lblDaBan.Size = new System.Drawing.Size(47, 15);
            this.lblDaBan.TabIndex = 3;
            this.lblDaBan.Text = "Đã bán";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGia.Location = new System.Drawing.Point(3, 170);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(36, 22);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Giá";
            // 
            // lblDaBanContent
            // 
            this.lblDaBanContent.AutoSize = true;
            this.lblDaBanContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDaBanContent.Location = new System.Drawing.Point(57, 155);
            this.lblDaBanContent.Name = "lblDaBanContent";
            this.lblDaBanContent.Size = new System.Drawing.Size(14, 15);
            this.lblDaBanContent.TabIndex = 5;
            this.lblDaBanContent.Text = "0";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BorderColor = System.Drawing.Color.Azure;
            this.btnView.BorderRadius = 10;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(23, 48);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(116, 31);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnView.MouseLeave += new System.EventHandler(this.btnView_MouseLeave);
            // 
            // ShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblDaBanContent);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblDaBan);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.picBoxShowItem);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ShowItem";
            this.Size = new System.Drawing.Size(164, 196);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox picBoxShowItem;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblDaBan;
        public System.Windows.Forms.Label lblGia;
        public System.Windows.Forms.Label lblDaBanContent;
        public Guna.UI2.WinForms.Guna2Button btnView;
    }
}
