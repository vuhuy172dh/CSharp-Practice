using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh2
{
    public partial class Liked : Form
    {
        public Liked()
        {
            InitializeComponent();
            Load_liked();
        }

        private void Load_liked()
        {
            foreach (string s in Dataframe.Liked)
            {
                if (s != "")
                {
                    DataRow row = Dataframe.DataSet.Select("Name='" + s + "'")[0];
                    HistoryItem item = cv2.LikedItemRead(row);
                    flowLikedList.Controls.Add(item);

                    item.btnViewClick += Item_Click;
                    item.btnLikeClick += Like_Click;
                }
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            HistoryItem item = (HistoryItem)sender;
            string s = "Name='" + item.lblName.Text + "'";
            DataRow row = Dataframe.DataSet.Select(s)[0];
            if (Dataframe.History.Contains(item.lblName.Text) == false)
            {
                Dataframe.History.Add(item.lblName.Text);
            }
            int idx = Dataframe.DataSet.Rows.IndexOf(row);
            int view = Convert.ToInt32(row["View"]) + 1;
            string date = DateTime.Now.ToString();
            Dataframe.DataSet.Rows[idx]["View"] = view;
            item.lblSoLanXem.Text = view.ToString();
            Dataframe.DataSet.Rows[idx]["Date"] = date;

            OpenChildForm(new products(row));
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.Show();
        }

        private void Like_Click(object sender, EventArgs e)
        {
            HistoryItem item = (HistoryItem)sender;
            item.btnLike.Image = global::thuchanh2.Properties.Resources.like;
            item.lblLike.Text = "Thích";
            string s = "Name='" + item.lblName.Text + "'";
            DataRow row = Dataframe.DataSet.Select(s)[0];
            int idx = Dataframe.DataSet.Rows.IndexOf(row);
            Dataframe.DataSet.Rows[idx]["Liked"] = 0;
            Dataframe.Liked.Remove(item.lblName.Text);
            flowLikedList.Controls.Remove(item);
        }
    }
}
