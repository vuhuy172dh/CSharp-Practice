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
        string dt;
        public game(int row, string data)
        {
            InitializeComponent();
            Load_data(row, data);
            i = row;
            dt = data;
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void Load_data(int row, string name)
        {
            /*foreach(DataRow dr in DataFrame.ReadItem().Rows)
            {
                string path = Application.StartupPath + "\\image\\" + dr["Name"].ToString() + "jpg";
                Image image = cv2.imread(path);
                Image resized = cv2.resize(image,new Size(picBox.Width,picBox.Height));
                picBox.Image = resized;
            }*/
            DataRow dr = DataFrame.ReadItem(name).Rows[row];
            string path = Application.StartupPath + "\\image\\" + dr["Name"].ToString() + ".jpg";
            Image image = cv2.imread(path);
            Image resized = cv2.resize(image, new Size(picBox.Width, picBox.Height));
            picBox.Image = resized;
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            int count_data = DataFrame.ReadItem(dt).Rows.Count;
            if (i < count_data - 1)
            {
                i++;
            }
            else
            {
                DataFrame.writeRank(correct, dt, " " + DateTime.Now.ToString());
                if(DataFrame.score.Contains(correct) == false)
                {
                    DataFrame.score.Add(correct);
                }
                EndGame endGame = new EndGame();
                endGame.lblScore.Text = correct.ToString() + "/" + count_data.ToString();
                OpenChildForm(endGame);
                this.Hide();
            }
            textBoxAnswer.Clear();
            textBoxAnswer.Enabled = true;
            btnSound.Visible = false;
            lblAnswer.Visible = false;
            Load_data(i, dt);
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = Application.StartupPath + "//sound//" + DataFrame.ReadItem(dt).Rows[i]["Name"].ToString() +".mp3";
            player.controls.play();
        }
        int correct = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string answer = DataFrame.ReadItem(dt).Rows[i]["Name"].ToString();
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
            DataFrame.writeExcel(i, dt, correct);
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is SplashScreen)
                {
                    oForm.Show();
                }
            }
            this.Hide();
        }
    }
}
