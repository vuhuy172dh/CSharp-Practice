using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh2
{
    class cv2
    {
        public static Image imread(string path)
        {
            Image result = Image.FromFile(path);

            return result;
        }

        public static ShowItem ItemRead(DataRow row)
        {
            ShowItem result = new ShowItem();  
            result.lblName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png";
            Image image = Image.FromFile(path);
            result.picBoxShowItem.Image = image;
            result.lblDaBanContent.Text = row["Sold"].ToString();
            result.lblGia.Text = row["Price"].ToString();

            return result;
        }

        public static Discount DiscountItemRead(DataRow row, bool check)
        {
            Discount result = new Discount();
            result.lblDisCountName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\discount.png";
            Image image = cv2.imread(path);
            Image resized = cv2.resize(image, new Size(result.picDiscount.Width, result.picDiscount.Height));
            result.picDiscount.Image = resized;
            result.lblDiscription.Text = row["Discription"].ToString();
            result.lblHSD.Text = row["HSD"].ToString();
            result.lblMaContent.Text = row["Mã"].ToString();
            result.lblDieuKienContent.Text = row["Điều kiện"].ToString();
            if(check == true)
                result.btnDung.Visible = true;
            return result;
        }

        public static HistoryItem HistoryItemRead(DataRow row)
        {
            HistoryItem result = new HistoryItem();
            result.lblName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png";
            Image pic = cv2.imread(path);
            Image resized = cv2.resize(pic, new Size(result.picItem.Width, result.picItem.Height));
            result.picItem.Image = resized;
            result.lblGia.Text = row["Price"].ToString();
            result.lblSoLanXem.Text = row["View"].ToString();
            result.lblNgayXem.Text = row["Date"].ToString();
            if (row["Liked"].ToString() == "0")
            {
                result.btnLike.Image = global::thuchanh2.Properties.Resources.like;
            }
            else
            {
                result.btnLike.Image = global::thuchanh2.Properties.Resources.heart_red;
                result.lblLike.Text = "Đã thích";
            }

            return result;
        }

        public static HistoryItem GiaoHangThanhCongItemRead(DataRow row)
        {
            HistoryItem result = new HistoryItem();
            result.lblName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png";
            Image pic = cv2.imread(path);
            Image resized = cv2.resize(pic, new Size(result.picItem.Width, result.picItem.Height));
            result.picItem.Image = resized;
            result.lblGia.Text = row["Price"].ToString();
            result.pnlSoLuongMua.Visible = true;
            result.lblSoLuongMua.Visible = true;
            result.lblSoLuongMua.Text = "x" + row["Số lượng mua"].ToString();
            result.btnLike.Visible = false;
            result.lblLike.Visible = false;
            result.lblSlx.Visible = false;
            result.lblNx.Visible = false;
            result.lblNgayXem.Visible = false;  
            result.lblSoLanXem.Visible = false;
            result.lblNgayXem.Visible = false;
            return result;
        }

        public static HistoryItem LikedItemRead(DataRow row)
        {
            HistoryItem result = new HistoryItem();
            result.lblName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png";
            Image pic = cv2.imread(path);
            Image resized = cv2.resize(pic, new Size(result.picItem.Width, result.picItem.Height));
            result.picItem.Image = resized;
            result.lblGia.Text = row["Price"].ToString();
            result.lblSoLanXem.Visible = false;
            result.lblNgayXem.Visible = false;
            result.lblSlx.Visible = false;
            result.lblNx.Visible = false;
            if(row["Liked"].ToString() == "0")
            {
                result.btnLike.Image = global::thuchanh2.Properties.Resources.like;
            }else
            {
                result.btnLike.Image = global::thuchanh2.Properties.Resources.heart_red;
                result.lblLike.Text = "Đã thích";
            }

            return result;
        }

        public static GioHangItem ChoseItemRead(DataRow row)
        {
            GioHangItem res = new GioHangItem();
            res.lblNamItem.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png";
            Image pic = cv2.imread(path);
            Image resized = cv2.resize(pic, new Size(res.picItem.Width, res.picItem.Height));
            res.picItem.Image = resized;
            res.lblGiaGoc.Text = row["Price"].ToString() + "đ";
            res.lblSoluong.Text = row["Số lượng mua"].ToString();
            res.lblGiaSau.Text = (Int32.Parse(row["Price"].ToString()) * Int32.Parse(res.lblSoluong.Text)).ToString() + "đ";
            //res.lblGiaSau.Text = (Int32.Parse(row["Price"].ToString()) * Int32.Parse(res.lblSoluong.Text)).ToString() + "đ";
            return res;
        }

        public static GioHangItem DonHangItemRead(DataRow row)
        {
            GioHangItem res = new GioHangItem();
            res.lblNamItem.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image1.png";
            Image pic = cv2.imread(path);
            Image resized = cv2.resize(pic, new Size(res.picItem.Width, res.picItem.Height));
            res.picItem.Image = resized;
            res.lblGiaGoc.Visible = false;
            res.pnlButtonSoluong.Visible = false;
            res.btnDel.Visible = false;
            res.lblNumb.Text = row["Số lượng"].ToString();
            res.lblGiaSau.Text = row["Giá sau"].ToString();
            return res;
        }

        public static Image resize_width(Image img, int width)
        {
            int w = width;
            Double ratio = Convert.ToDouble(w) / img.Width;
            int h = Convert.ToInt32(ratio * img.Height);

            Image result = resize(img, new Size(w, h));

            return result;
        }

        public static Image resize(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, size);
            return (Image)bm;
        }
    }
}
