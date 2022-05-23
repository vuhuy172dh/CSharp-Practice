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
    public partial class HistoryList : Form
    {
        public HistoryList()
        {
            InitializeComponent();
            Load_History();
        }

        private void Load_History()
        {
            foreach (string s in Dataframe.History)
            {
                if(s != "")
                {
                    DataRow row = Dataframe.DataSet.Select("Name='" + s + "'")[0];
                    HistoryItem item = cv2.HistoryItemRead(row);
                    flowHistoryList.Controls.Add(item);

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
            string s = "Name='" + item.lblName.Text + "'";
            DataRow row = Dataframe.DataSet.Select(s)[0];
            int idx = Dataframe.DataSet.Rows.IndexOf(row);
            if(Dataframe.DataSet.Rows[idx]["Liked"].ToString() == "0")
            {
                item.btnLike.Image = global::thuchanh2.Properties.Resources.heart_red;
                item.lblLike.Text = "Đã Thích";
                Dataframe.DataSet.Rows[idx]["Liked"] = 1;
                if(Dataframe.Liked.Contains(item.lblName.Text) == false)
                    Dataframe.Liked.Add(item.lblName.Text); 
            }
            else
            {
                Dataframe.DataSet.Rows[idx]["Liked"] = 0;
                item.lblLike.Text = "Thích";
                item.btnLike.Image = global::thuchanh2.Properties.Resources.like;
                if(Dataframe.Liked.Contains(item.lblName.Text) == true)
                {
                    Dataframe.Liked.Remove(item.lblName.Text);
                }
            }
           
        } 
    }
}
