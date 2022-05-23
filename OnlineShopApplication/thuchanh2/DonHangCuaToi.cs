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
    public partial class DonHangCuaToi : Form
    {
        public DonHangCuaToi()
        {
            InitializeComponent();
            Load_data();
        }

        private void Load_data()
        {
            flowDonHang.Controls.Clear();
            foreach (int s in Dataframe.RandomMa)
            {
                DonHangItem donHangItem = new DonHangItem();
                int row = Dataframe.ReadDonHangExcel(s).Rows.Count;
                string tongcong = "";
                string ngaydat = "";
                string madon = "";
                for (int i = 0; i < row; i++)
                {

                    DataRow dataRow = Dataframe.ReadDonHangExcel(s).Rows[i];
                    if (i == 0)
                    {
                        tongcong = dataRow["Tổng cộng"].ToString();
                        ngaydat = dataRow["Ngày đặt"].ToString();
                        madon = dataRow["Mã đơn hàng"].ToString();
                    }
                    GioHangItem item = cv2.DonHangItemRead(dataRow);
                    donHangItem.flowHang.Controls.Add(item);
                }
                donHangItem.lblMaDonContent.Text = madon;
                donHangItem.lblNgayDat.Text = ngaydat;
                donHangItem.lblTongTien.Text = tongcong;
                flowDonHang.Controls.Add(donHangItem);

                donHangItem.btnHuyClick += Huy_Click;
                donHangItem.btnXemChiTietClick += XemChiTiet_Click;
            }
        }

        private void btnDangXuLy_Click(object sender, EventArgs e)
        {
            Load_data();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            DonHangItem item = (DonHangItem)sender;
            Dataframe.RandomMa.Remove(Int32.Parse(item.lblMaDonContent.Text));
            //Dataframe.deleteSheet(Int32.Parse(item.lblMaDonContent.Text));
            flowDonHang.Controls.Remove(item);
        }

        private void XemChiTiet_Click(object sender, EventArgs e)
        {
            DonHangItem item = (DonHangItem)sender;
            OpenChildForm(new XemChiTietDonHang(Int32.Parse(item.lblMaDonContent.Text)), pnlCenter);   
        }


        private Form activeForm;
        private void OpenChildForm(Form childForm, Panel pnl)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl.Controls.Add(childForm);
            pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach(int s in Dataframe.RandomMa)
            {
                if (s.ToString() == textBoxSearch.Text)
                {
                    Load_data_search(s);
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                Load_data();
            }
        }

        private void Load_data_search(int s)
        {
            flowDonHang.Controls.Clear();
            DonHangItem donHangItem = new DonHangItem();
            int row = Dataframe.ReadDonHangExcel(s).Rows.Count;
            string tongcong = "";
            string ngaydat = "";
            string madon = "";
            for (int i = 0; i < row; i++)
            {

                DataRow dataRow = Dataframe.ReadDonHangExcel(s).Rows[i];
                if (i == 0)
                {
                    tongcong = dataRow["Tổng cộng"].ToString();
                    ngaydat = dataRow["Ngày đặt"].ToString();
                    madon = dataRow["Mã đơn hàng"].ToString();
                }
                GioHangItem item = cv2.DonHangItemRead(dataRow);
                donHangItem.flowHang.Controls.Add(item);
            }
            donHangItem.lblMaDonContent.Text = madon;
            donHangItem.lblNgayDat.Text = ngaydat;
            donHangItem.lblTongTien.Text = tongcong;
            
            flowDonHang.Controls.Add(donHangItem);
            donHangItem.btnHuyClick += Huy_Click;
            donHangItem.btnXemChiTietClick += XemChiTiet_Click;
        }

        private void btnQRSearch_Click(object sender, EventArgs e)
        {
            QR_Scan qr_scan = new QR_Scan();
            OpenChildForm(qr_scan, pnlCenter);
            //qr_scan.Show();

            qr_scan.xemChiTietClick += XemChiTiet2_Click;
        }

        private void XemChiTiet2_Click(object sender, EventArgs e)
        {
            QR_Scan qr_scan = (QR_Scan)sender;
            OpenChildForm(new XemChiTietDonHang(Int32.Parse(qr_scan.textBoxMaDon.Text)), pnlCenter);
        }
    }
}
