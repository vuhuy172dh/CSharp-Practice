namespace thuchanh3
{
    partial class EndGame
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
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnTopic = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuit.FillColor = System.Drawing.Color.Transparent;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Location = new System.Drawing.Point(254, 289);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(71, 45);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAnswer.Location = new System.Drawing.Point(144, 51);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(87, 21);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Your score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScore.Location = new System.Drawing.Point(177, 84);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 21);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(96, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your rank";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRank.Location = new System.Drawing.Point(221, 119);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(19, 21);
            this.lblRank.TabIndex = 9;
            this.lblRank.Text = "0";
            // 
            // btnTopic
            // 
            this.btnTopic.BackColor = System.Drawing.Color.Transparent;
            this.btnTopic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopic.FillColor = System.Drawing.Color.Transparent;
            this.btnTopic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTopic.ForeColor = System.Drawing.Color.Black;
            this.btnTopic.Location = new System.Drawing.Point(42, 289);
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.Size = new System.Drawing.Size(94, 45);
            this.btnTopic.TabIndex = 10;
            this.btnTopic.Text = "Topic";
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 434);
            this.Controls.Add(this.btnTopic);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EndGame_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Button btnQuit;
        public System.Windows.Forms.Label lblAnswer;
        public System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblRank;
        public Guna.UI2.WinForms.Guna2Button btnTopic;
    }
}