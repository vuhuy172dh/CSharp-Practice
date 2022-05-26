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
    public partial class SplashScreen : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        public SplashScreen()
        {
            InitializeComponent();
            player.URL = Application.StartupPath + "//sound//" + "intro_music.mp3";
            if (DataFrame.click)
            {
                player.controls.play();
                btnSound.Image = global::thuchanh3.Properties.Resources.volume;
                btnSound.HoverState.Image = global::thuchanh3.Properties.Resources.volume;
                btnSound.PressedState.Image = global::thuchanh3.Properties.Resources.mute;
            }
            else
            {
                player.controls.stop();
                btnSound.Image = global::thuchanh3.Properties.Resources.mute;
                btnSound.HoverState.Image = global::thuchanh3.Properties.Resources.mute;
                btnSound.PressedState.Image = global::thuchanh3.Properties.Resources.volume;
            } 
                
                
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
            OpenChildForm(new TopicSelect());
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(DataFrame.readSaveGame().Rows[0]["row"].ToString());
            string name = DataFrame.readSaveGame().Rows[0]["name"].ToString();
            int score = Int32.Parse(DataFrame.readSaveGame().Rows[0]["score"].ToString());
            OpenChildForm(new game(i, name));
            this.Hide();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            DataFrame.click = !DataFrame.click;
            Console.WriteLine(DataFrame.click);
            if(DataFrame.click == false)
            {
                player.controls.stop();
                btnSound.Image = global::thuchanh3.Properties.Resources.mute;
                btnSound.HoverState.Image = global::thuchanh3.Properties.Resources.mute;
                btnSound.PressedState.Image = global::thuchanh3.Properties.Resources.volume;
            }
            else
            {
                player.controls.play();
                btnSound.Image = global::thuchanh3.Properties.Resources.volume;
                btnSound.HoverState.Image = global::thuchanh3.Properties.Resources.volume;
                btnSound.PressedState.Image = global::thuchanh3.Properties.Resources.mute;
            }
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Rank());
            this.Hide();
        }
    }
}
