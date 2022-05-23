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
    public partial class DonHang : UserControl
    {
        List<string> row;
        public DonHang(List<string> dr)
        {
            InitializeComponent();
            row = dr;
            Load_Data();
        }

        private void Load_Data()
        {
            foreach (string s in row)
            {
                if (s != "")
                {
                    DataRow row = Dataframe.DataSet.Select("Name='" + s + "'")[0];
                    HistoryItem item = cv2.GiaoHangThanhCongItemRead(row);
                    flowGiaoHangThanhCong.Controls.Add(item);

                }
            }
        }
    }
}
