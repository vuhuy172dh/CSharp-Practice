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
        int i;
        public game(int row)
        {
            InitializeComponent();
            Load_data(row);
            i = row;
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int count_data = DataFrame.ReadItem("fruit").Rows.Count;
        private void Load_data(int row)
        {
            /*foreach(DataRow dr in DataFrame.ReadItem().Rows)
            {
                string path = Application.StartupPath + "\\image\\" + dr["Name"].ToString() + "jpg";
                Image image = cv2.imread(path);
                Image resized = cv2.resize(image,new Size(picBox.Width,picBox.Height));
                picBox.Image = resized;
            }*/
            DataRow dr = DataFrame.ReadItem("fruit").Rows[row];
            string path = Application.StartupPath + "\\image\\" + dr["Name"].ToString() + ".jpg";
            Image image = cv2.imread(path);
            Image resized = cv2.resize(image, new Size(picBox.Width, picBox.Height));
            picBox.Image = resized;
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i < count_data - 1)
            {
                i++;
            }
            else
            {
                EndGame endGame = new EndGame();
                endGame.lblAnswer.Text = correct.ToString() + "/" + count_data.ToString();
                OpenChildForm(endGame);
                this.Hide();
            }
            textBoxAnswer.Clear();
            textBoxAnswer.Enabled = true;
            btnSound.Visible = false;
            lblAnswer.Visible = false;
            Load_data(i);
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = Application.StartupPath + "//sound//" + DataFrame.ReadItem("fruit").Rows[i]["Name"].ToString() +".mp3";
            player.controls.play();
        }
        int correct = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string answer = DataFrame.ReadItem("fruit").Rows[i]["Name"].ToString();
            textBoxAnswer.Enabled = false;
            if(textBoxAnswer.Text == answer)
            {
                correct++;
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("incorrect");
                lblAnswer.Text = "Correct answer is: " + answer;
                lblAnswer.Visible = true;
            }
            btnSound.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DataFrame.writeExcel(i);
            OpenChildForm(new SplashScreen());
            this.Visible = false;
            this.Hide();
        }
    }
}
