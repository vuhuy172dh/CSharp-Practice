using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh3
{
    public partial class Rank : Form
    {
        public Rank()
        {
            InitializeComponent();
            Load_data();
        }

        private void Load_data()
        {
            DataFrame.score.Sort();
            DataFrame.score.Reverse();
            foreach (int i in DataFrame.score)
            {
                RankItem item = new RankItem();
                item.lblName.Text = DataFrame.readRank(i).Rows[0]["name"].ToString();
                item.lblScore.Text = i.ToString();
                item.lblDate.Text = DataFrame.readRank(i).Rows[0]["date"].ToString();
                flowRank.Controls.Add(item);
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is SplashScreen)
                {
                    oForm.Show();
                    break;
                }
            }
        }
    }
}
