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
    public partial class XemChiTietDonHang : Form
    {
        public XemChiTietDonHang(int ma)
        {
            InitializeComponent();
            Load_data_user(Dataframe.UserData);
            Load_data_tien(ma);
        }

        private void Load_data_user(DataTable table)
        {
            foreach (DataRow dr in table.Rows)
            {
                lblDiaChiNguoiNhan.Text = dr["Address"].ToString();
            }
        }

        private void Load_data_tien(int ma)
        {   
            int row = Dataframe.ReadDonHangExcel(ma).Rows.Count;
            string tongtien = "";
            string tamtinh = "";
            string giamgia = "";
            string ngaydat = "";
            Image pic = cv2.imread(Application.StartupPath + "//qr//" + ma.ToString() + ".png");
            Image resized = cv2.resize(pic, new Size(picBoxMaVach.Width, picBoxMaVach.Height));
            for (int i = 0; i < row; i++)
            {
                DataRow dataRow = Dataframe.ReadDonHangExcel(ma).Rows[i];
                GioHangItem item = cv2.DonHangItemRead(dataRow);
                if (i == 0)
                {
                    tongtien = dataRow["Tổng cộng"].ToString();
                    tamtinh = dataRow["Tạm tính"].ToString();
                    giamgia = dataRow["Giảm giá"].ToString();
                    ngaydat = dataRow["Ngày đặt"].ToString();
                }
                
                flowHang.Controls.Add(item);
            }
            picBoxMaVach.Image = resized;
            lblMaDonHang.Text = ma.ToString();
            lblNgayDat.Text = ngaydat;
            lblTongTien.Text = tongtien;
            lblTamTinh.Text = tamtinh;
            lblGiamGia.Text = giamgia;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            report rp = new report();
            rp.Load_data();
            rp.Show();

        }
    }
}
