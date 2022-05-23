using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace thuchanh2
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
            Load_data(Dataframe.UserData);
        }

        private void Load_data(DataTable table)
        {
            foreach (DataRow dr in table.Rows)
            {
                lblNamUser.Text = dr["Name"].ToString();
                lblSoDienThoai.Text = dr["Phone"].ToString();
                lblDiaChi.Text = dr["Address"].ToString();
            }

            Load_data_giohang();
        }

        int tamtinh = 0;
        private void Load_data_giohang()
        {
            foreach (string s in Dataframe.ChoseItem)
            {
                if (s != "")
                {
                    DataRow row = Dataframe.DataSet.Select("Name='" + s + "'")[0];
                    GioHangItem item = cv2.ChoseItemRead(row);
                    
                    flowHang.Controls.Add(item);

                    tamtinh += Int32.Parse(item.lblGiaSau.Text.Remove(item.lblGiaSau.Text.Length - 1));

                    item.btnDelClick += Del_Click;
                    item.btnIncreaseClick += Increase_Click;
                    item.btnDecreaseClick += Decrease_Click;
                }
            }
            
            lblTamTinh.Text = tamtinh.ToString() + "đ";
            lblGiamGia.Text = Dataframe.UserData.Rows[0]["discount"].ToString() + "đ";
            lblTongTien.Text = (Int32.Parse(lblTamTinh.Text.Remove(lblTamTinh.Text.Length - 1)) - Int32.Parse(lblGiamGia.Text.Remove(lblGiamGia.Text.Length -1))).ToString() + "đ";
        }

        private void Del_Click(object sender, EventArgs e)
        {
            GioHangItem item = (GioHangItem)sender;
            Dataframe.ChoseItem.Remove(item.lblNamItem.Text);

            tamtinh -= Int32.Parse(item.lblGiaSau.Text.Remove(item.lblGiaSau.Text.Length - 1));
            lblTamTinh.Text = tamtinh.ToString() + "đ";
            lblTongTien.Text = (Int32.Parse(lblTamTinh.Text.Remove(lblTamTinh.Text.Length-1)) - Int32.Parse(lblGiamGia.Text.Remove(lblGiamGia.Text.Length-1))).ToString() + "đ";
            flowHang.Controls.Remove(item);
        }

        private void Decrease_Click(object sender, EventArgs e)
        {
            GioHangItem item = (GioHangItem)sender;
            if (Int32.Parse(item.lblSoluong.Text) > 1)
                item.lblSoluong.Text = (Int32.Parse(item.lblSoluong.Text) - 1).ToString();
            if (Int32.Parse(item.lblSoluong.Text) >= 10)
            {
                item.lblSoluong.Location = new System.Drawing.Point(44, 6);
            }
            string s = "Name='" + item.lblNamItem.Text + "'";
            DataRow row = Dataframe.DataSet.Select(s)[0];
            item.lblGiaSau.Text = (Int32.Parse(row["Price"].ToString()) * Int32.Parse(item.lblSoluong.Text)).ToString() + "đ";
            tamtinh -= Int32.Parse(item.lblGiaGoc.Text.Remove(item.lblGiaSau.Text.Length - 1));
            if(Int32.Parse(item.lblSoluong.Text) != 1)
                lblTamTinh.Text = tamtinh.ToString() + "đ";
            lblTongTien.Text = (Int32.Parse(lblTamTinh.Text.Remove(lblTamTinh.Text.Length-1)) - Int32.Parse(lblGiamGia.Text.Remove(lblGiamGia.Text.Length-1))).ToString() + "đ";
            int idx = Dataframe.DataSet.Rows.IndexOf(row);
            int so_luong_mua = Int32.Parse(item.lblSoluong.Text);
            Dataframe.DataSet.Rows[idx]["Số lượng mua"] = so_luong_mua;
        }

        private void Increase_Click(object sender, EventArgs e) 
        {
            GioHangItem item = (GioHangItem)sender;
            item.lblSoluong.Text = (Int32.Parse(item.lblSoluong.Text) + 1).ToString();
            if (Int32.Parse(item.lblSoluong.Text) >= 10)
            {
                item.lblSoluong.Location = new System.Drawing.Point(44, 6);
            }
            string s = "Name='" + item.lblNamItem.Text + "'";
            DataRow row = Dataframe.DataSet.Select(s)[0];
            item.lblGiaSau.Text = (Int32.Parse(row["Price"].ToString()) * Int32.Parse(item.lblSoluong.Text)).ToString() + "đ";
            tamtinh += Int32.Parse(item.lblGiaSau.Text.Remove(item.lblGiaGoc.Text.Length - 1));
            lblTamTinh.Text = tamtinh.ToString() + "đ";
            lblTongTien.Text = (Int32.Parse(lblTamTinh.Text.Remove(lblTamTinh.Text.Length-1)) - Int32.Parse(lblGiamGia.Text.Remove(lblGiamGia.Text.Length-1))).ToString() + "đ";
            int idx = Dataframe.DataSet.Rows.IndexOf(row);
            int so_luong_mua = Int32.Parse(item.lblSoluong.Text);
            Dataframe.DataSet.Rows[idx]["Số lượng mua"] = so_luong_mua;
        }

        private void btnChonKhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiscountForm(true));
            this.Close();
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.Show();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            List<int> soluong = new List<int>();
            List<string> giasau = new List<string>();
            foreach(GioHangItem item in flowHang.Controls)
            {
                soluong.Add(Int32.Parse(item.lblSoluong.Text));
                giasau.Add(item.lblGiaSau.Text);
            }

            Console.WriteLine(giasau);
            Random rnd = new Random();
            int maDonhang = rnd.Next(1000, 9999);
            while (Dataframe.RandomMa.Contains(maDonhang) == true)
            {
                maDonhang = rnd.Next(1000, 9999);
            }
            Dataframe.RandomMa.Add(maDonhang);
            Dataframe.writeExcel(maDonhang.ToString(), Dataframe.ChoseItem, soluong, giasau,lblTamTinh.Text, lblGiamGia.Text, lblTongTien.Text, DateTime.Now.ToString());

            string qrData = maDonhang.ToString();
            string qrFileName = maDonhang.ToString();
            string path = Application.StartupPath + "//qr//";
            //create barcodewriter object
            BarcodeWriter barcodeW = new BarcodeWriter();
            //specify barcode format --> QR
            barcodeW.Format = BarcodeFormat.QR_CODE;

            barcodeW.Write(qrData).Save(path + qrFileName + ".png");
        }

        private void btnDoiDiaChi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoiDiaChi());
            this.Close();
        }

        
    }
}
