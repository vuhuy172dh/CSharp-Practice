using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh2
{
    public partial class products : Form
    {
        DataRow row;
        public products(DataRow dr)
        {
            InitializeComponent();
            row = dr;
        }

        private void products_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            Load_Image();
            Load_Name();
        }

        private void Load_Image()
        {
            Image pic1 = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png");
            Image pic2 = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image2.png");
            Image pic3 = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png");
            Image resized = cv2.resize(pic1, new Size(picBoxShow.Width, picBoxShow.Height));
            Image resized_1 = cv2.resize(pic1, new Size(picBoxShow1.Width, picBoxShow1.Height));
            Image resized_2 = cv2.resize(pic2, new Size(picBoxShow2.Width, picBoxShow2.Height));
            Image resized_3 = cv2.resize(pic3, new Size(picBoxShow3.Width, picBoxShow3.Height));
            picBoxShow.Image = resized;
            picBoxShow1.Image = resized_1;
            picBoxShow2.Image = resized_2;
            picBoxShow3.Image = resized_3;
        }

        private void Load_Name()
        {
            lblProductName.Text = row["Name"].ToString();
            if(lblProductName.Height > 39)
            {
                pnlInfor.Location = new System.Drawing.Point(381, 81);
            }
            lblPrice.Text = row["Price"].ToString();
            lblDaBanContent.Text = row["Sold"].ToString();
            lblThuongHieu.Text = row["Thương hiệu"].ToString();
            lblXuatXuThuongHieu.Text = row["Xuất xứ thương hiệu"].ToString();
            lblXuatXu.Text = row["Xuất xứ"].ToString();
            if(row["Liked"].ToString() == "0")
            {
                btnLike.Image = global::thuchanh2.Properties.Resources.like;
            }
            else
            {
                btnLike.Image = global::thuchanh2.Properties.Resources.heart_red;
            }
            lblDiaChi.Text = Dataframe.UserData.Rows[0]["Address"].ToString();
            if(lblDiaChi.Height > 39)
            {
                pnlSoLuong.Location = new System.Drawing.Point(1, 290);
                pnlDiaChi.Size = new System.Drawing.Size(496, 110);
               
            }
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\describe.txt";
            string s = File.ReadAllText(path);
            lblMoTa.Text = s;
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            lblSoluong.Text = (Int32.Parse(lblSoluong.Text) + 1).ToString();
            if(Int32.Parse(lblSoluong.Text) >= 10)
            {
                lblSoluong.Location = new System.Drawing.Point(44, 6);
            }
            string s = "Name='" + lblProductName.Text + "'";
            DataRow row = Dataframe.DataSet.Select(s)[0];
            int idx = Dataframe.DataSet.Rows.IndexOf(row);
            int so_luong_mua = Int32.Parse(lblSoluong.Text);
            Dataframe.DataSet.Rows[idx]["Số lượng mua"] = so_luong_mua;
        }

        private void btnDecrese_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(lblSoluong.Text) > 1)
                lblSoluong.Text = (Int32.Parse(lblSoluong.Text) - 1).ToString();
            if(Int32.Parse(lblSoluong.Text) >= 10)
            {
                lblSoluong.Location = new System.Drawing.Point(44, 6);
            }
            string s = "Name='" + lblProductName.Text + "'";
            DataRow row = Dataframe.DataSet.Select(s)[0];
            int idx = Dataframe.DataSet.Rows.IndexOf(row);
            int so_luong_mua = Int32.Parse(lblSoluong.Text);
            Dataframe.DataSet.Rows[idx]["Số lượng mua"] = so_luong_mua;
        }

        private void picBoxShow1_Click(object sender, EventArgs e)
        {
            Image pic = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png");
            Image resized = cv2.resize(pic, new Size(picBoxShow.Width, picBoxShow.Height));
            picBoxShow.Image = resized;
        }

        private void picBoxShow2_Click(object sender, EventArgs e)
        {
            Image pic = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image2.png");
            Image resized = cv2.resize(pic, new Size(picBoxShow.Width, picBoxShow.Height));
            picBoxShow.Image = resized;
        }

        private void picBoxShow3_Click(object sender, EventArgs e)
        {
            Image pic = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image3.png");
            Image resized = cv2.resize(pic, new Size(picBoxShow.Width, picBoxShow.Height));
            picBoxShow.Image = resized;
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (row["Liked"].ToString() == "0")
            {
                this.btnLike.Image = global::thuchanh2.Properties.Resources.heart_red;
                string s = "Name='" + lblProductName.Text + "'";
                DataRow row = Dataframe.DataSet.Select(s)[0];
                int idx = Dataframe.DataSet.Rows.IndexOf(row);
                Dataframe.DataSet.Rows[idx]["Liked"] = 1;
                if (Dataframe.Liked.Contains(lblProductName.Text) == false)
                {
                    Dataframe.Liked.Add(lblProductName.Text);
                }
            }
            else if (row["Liked"].ToString() == "1")
            {
                this.btnLike.Image = global::thuchanh2.Properties.Resources.like;
                string s = "Name='" + lblProductName.Text + "'";
                DataRow row = Dataframe.DataSet.Select(s)[0];
                int idx = Dataframe.DataSet.Rows.IndexOf(row);
                Dataframe.DataSet.Rows[idx]["Liked"] = 0;
                Dataframe.Liked.Remove(lblProductName.Text);
            }

        }

        private void btnChonMua_Click(object sender, EventArgs e)
        {
            if (Dataframe.ChoseItem.Contains(lblProductName.Text) == false)
            {
                Dataframe.ChoseItem.Add(lblProductName.Text);
            }
            else
            {
                DataRow row = Dataframe.DataSet.Select("Name='" + lblProductName.Text + "'")[0];
                int soluongmua = Int32.Parse(row["Số lượng mua"].ToString()) + 1;
                row["Số lượng mua"] = soluongmua;
            }
            
        }
    }
}
