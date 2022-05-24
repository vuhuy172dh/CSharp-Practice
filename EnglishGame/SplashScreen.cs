using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh3
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphic = e.Graphics;

            //khai báo các tọa độ và kích thước
            Point p = new Point(0, 0);
            Point p2 = new Point(Width, Height);
            Size size = new Size(Width, Height);
            //tạo brush gradient 
            LinearGradientBrush myBrush = new LinearGradientBrush(p, p2, Color.Cyan, Color.White);
            //Khai báo hình ellipse làm hình dạng của Form
            Rectangle r1 = new Rectangle(p, size);

            //tô hình ellipse với brush vừa định nghĩa
            myGraphic.FillEllipse(myBrush, r1);
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenChildForm(new game());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
