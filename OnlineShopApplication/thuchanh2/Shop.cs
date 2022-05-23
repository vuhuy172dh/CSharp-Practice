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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            Load_data(Dataframe.DataSet);
            pnlUserMenu.Visible = false;
        }

        private void Load_data(DataTable table)
        {
            foreach(DataRow dr in table.Rows)
            {
                ShowItem item = cv2.ItemRead(dr);
                flowListItem.Controls.Add(item);

                item.btnViewClick += Item_Click;
                item.pctMouseHover += Item_Hover;
                item.pctMouseLeave += Item_MouseLeave;
            }
        }

       
        private void btnFood_Click(object sender, EventArgs e)
        {
            //change ui
            btnFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(194)))), ((int)(((byte)(190)))));
            btnTech.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(194)))), ((int)(((byte)(190)))));
            btnCloths.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(194)))), ((int)(((byte)(190)))));
            pnlHomeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(194)))), ((int)(((byte)(190)))));
            string path = Application.StartupPath + "\\food.png";
            picBoxHome.Image = cv2.imread(path);
            lblShownHome1.Text = "Fresh Food";
            lblShownHome2.Text = "for Your";
            lblShownHome3.Text = "Kitchen";
            //load data for Food
            DataTable table = Dataframe.DataSet;
            flowListItem.Controls.Clear();  
            foreach(DataRow dr in table.Rows)
            {
                if(dr["Type"].ToString() == "Food")
                {
                    ShowItem item = cv2.ItemRead(dr);
                    item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(194)))), ((int)(((byte)(190)))));
                    flowListItem.Controls.Add(item);

                    item.btnViewClick += Item_Click;
                    item.pctMouseHover += Item_Hover;
                    item.pctMouseLeave += Item_MouseLeave;
                }
                
            }
            
        }

        private void btnTech_Click(object sender, EventArgs e)
        {
            //change ui
            btnFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            btnTech.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            btnCloths.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            pnlHomeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            string path = Application.StartupPath + "\\technology.png";
            picBoxHome.Image = cv2.imread(path);
            lblShownHome1.Text = "Morden";
            lblShownHome2.Text = "Technology for";
            lblShownHome3.Text = "Your Life";
            //Load data for techs
            DataTable table = Dataframe.DataSet;
            flowListItem.Controls.Clear();
            foreach (DataRow dr in table.Rows)
            {
                if(dr["Type"].ToString() == "Tech")
                {
                    ShowItem item = cv2.ItemRead(dr);
                    item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
                    flowListItem.Controls.Add(item);

                    item.btnViewClick += Item_Click;
                    item.pctMouseHover += Item_Hover;
                    item.pctMouseLeave += Item_MouseLeave;
                }
            }

        }

        private void btnCloths_Click(object sender, EventArgs e)
        {
            //change ui
            btnFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            btnTech.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            btnCloths.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            pnlHomeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            string path = Application.StartupPath + "\\cloths.png";
            picBoxHome.Image = cv2.imread(path);
            lblShownHome1.Text = "Wonderful";
            lblShownHome2.Text = "Fashion for";
            lblShownHome3.Text = "Your Style";
            //Load data for cloths
            DataTable table = Dataframe.DataSet;
            flowListItem.Controls.Clear();
            foreach (DataRow dr in table.Rows)
            {
                if(dr["Type"].ToString() == "Cloth")
                {
                    ShowItem item = cv2.ItemRead(dr);
                    item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
                    flowListItem.Controls.Add(item);

                    item.btnViewClick += Item_Click;
                    item.pctMouseHover += Item_Hover;
                    item.pctMouseLeave += Item_MouseLeave;
                }
                
            }
        }

        private void Item_Hover(object sender, EventArgs e)
        {
            ShowItem item = (ShowItem)sender;
            item.btnView.Visible = true;
            item.btnView.FillColor = item.BackColor;
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            ShowItem item = (ShowItem)sender;
            item.btnView.Visible = false;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ShowItem item = (ShowItem)sender;
            string s = "Name='" + item.lblName.Text + "'";
            DataRow row = Dataframe.DataSet.Select(s)[0];
            if(Dataframe.History.Contains(item.lblName.Text) == false)
            {
                Dataframe.History.Add(item.lblName.Text);
            }
            int idx = Dataframe.DataSet.Rows.IndexOf(row);
            int view = Convert.ToInt32(row["View"]) + 1;
            string date = DateTime.Now.ToString();
            Dataframe.DataSet.Rows[idx]["View"] = view;
            Dataframe.DataSet.Rows[idx]["Date"] = date;

            OpenChildForm(new products(row));
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if( activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.Show();
        }

       
        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            pnlUserMenu.Visible = !pnlUserMenu.Visible;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInfor());
            pnlUserMenu.Visible = false;
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HistoryList());
            pnlUserMenu.Visible = false;
        }

        private void btnDaThich_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Liked());
            pnlUserMenu.Visible = false;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonHangCuaToi());
            pnlUserMenu.Visible = false;
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GioHang());
            pnlUserMenu.Visible = false;
        }

        private void btnMaGiamGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiscountForm(false));
            pnlUserMenu.Visible = false;
        }

        private void textboxSearch_IconLeftClick(object sender, EventArgs e)
        {
            DataTable table = SearchTable(textboxSearch.Text);
            flowListItem.Controls.Clear();
            Load_data(table);
        }

        private DataTable SearchTable(string s)
        {
            DataTable res = Dataframe.new_DataItem();
            foreach (DataRow row in Dataframe.DataSet.Rows)
            {
                string name = row["Name"].ToString();
                if (name.Contains(s))
                    res.ImportRow(row);
            }

            return res;
        }
    }
}
