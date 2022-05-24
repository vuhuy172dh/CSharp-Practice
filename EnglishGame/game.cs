using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace thuchanh3
{
    public partial class game : Form
    {
        

        public game()
        {
            InitializeComponent();
            Load_data();
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int count_data = DataFrame.ReadItem().Rows.Count;
        int i = 0;
        private void Load_data()
        {
            /*foreach(DataRow dr in DataFrame.ReadItem().Rows)
            {
                string path = Application.StartupPath + "\\image\\" + dr["Name"].ToString() + "jpg";
                Image image = cv2.imread(path);
                Image resized = cv2.resize(image,new Size(picBox.Width,picBox.Height));
                picBox.Image = resized;
            }*/
            DataRow dr = DataFrame.ReadItem().Rows[i];
            string path = Application.StartupPath + "\\image\\" + dr["Name"].ToString() + ".jpg";
            Image image = cv2.imread(path);
            Image resized = cv2.resize(image, new Size(picBox.Width, picBox.Height));
            picBox.Image = resized;
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            Console.WriteLine(count_data);
            if(i < count_data-1)
            {
                i++;
            }
            else
            {
                Application.Exit();
            }
            Load_data();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = Application.StartupPath + "//sound//" + "apple.mp3";
            player.controls.play();
        }
    }
}
