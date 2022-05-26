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
using WMPLib;

namespace thuchanh3
{
    public partial class TopicSelect : Form
    {
        //WindowsMediaPlayer player = new WindowsMediaPlayer();
        public TopicSelect()
        {
            InitializeComponent();
            /*if(DataFrame.click == true)
            {
                player.URL = Application.StartupPath + "//sound//" + "intro_music.mp3";
                player.controls.play();
            }   */ 
        }

        private void TopicSelect_Paint(object sender, PaintEventArgs e)
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
            this.Close();
            DataFrame.resume = false;
            OpenChildForm(new game(0, "fruit"));
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            this.Close();
            DataFrame.resume = false;
            OpenChildForm(new game(0, "animal"));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form oForm in Application.OpenForms)
            {
                if(oForm is SplashScreen)
                {
                    oForm.Show();
                    break;
                }
            }    
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            this.Close();
            DataFrame.resume = false;
            OpenChildForm(new game(0, "vehicle"));
        }
    }
}
