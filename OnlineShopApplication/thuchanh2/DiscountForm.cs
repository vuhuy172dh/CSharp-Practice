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
    public partial class DiscountForm : Form
    {
        public DiscountForm(bool check)
        {
            InitializeComponent();
            Load_data(Dataframe.DiscountData, check);
            
            if (check == true)
            {
                textBoxSearch.Visible = true;
                btnTimKiem.Visible = true;
            }    
        }

        private void Load_data(DataTable table, bool Check)
        {
            foreach (DataRow dr in table.Rows)
            {
                /*Console.WriteLine(Check);*/
                Discount item = cv2.DiscountItemRead(dr,Check);

                item.btnApDungClick += ApDung_Click;
                item.btnCoppyClick += Coppy_Click;


                flowDiscount.Controls.Add(item);
            }
        }

        private void Coppy_Click(object sender, EventArgs e)
        {
            Discount item = (Discount)sender;
            Clipboard.SetText(item.lblMaContent.Text);
        }

        private void ApDung_Click(object sender, EventArgs e)
        {
            Discount item = (Discount)sender;
            string s = "Name='" + item.lblDisCountName.Text + "'";
            DataRow row = Dataframe.DiscountData.Select(s)[0];
            int dis = Int32.Parse(row["discount"].ToString());
            Dataframe.UserData.Rows[0]["Discount"] = dis;
            OpenChildForm(new GioHang());
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

        

        private DataTable SearchTable(string s)
        {
            DataTable res = Dataframe.new_DataItem();
            foreach (DataRow row in Dataframe.DataSet.Rows)
            {
                string name = row["Name"].ToString();
                if (name == s)
                    res.ImportRow(row);
            }

            return res;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool check = false;
            
            foreach (DataRow row in Dataframe.DiscountData.Rows)
            {
                if(row["Mã"].ToString() == textBoxSearch.Text)
                {
                    check = true;
                    Discount item = cv2.DiscountItemRead(row, true);

                    item.btnApDungClick += ApDung_Click;
                    item.btnCoppyClick += Coppy_Click;

                    flowDiscount.Controls.Clear();
                    flowDiscount.Controls.Add(item);
                    break;
                }
            }
            
        }
    }
}
