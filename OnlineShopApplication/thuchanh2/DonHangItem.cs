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
    public partial class DonHangItem : UserControl
    {
        public DonHangItem()
        {
            InitializeComponent();
        }

        public event EventHandler btnHuyClick;
        public event EventHandler btnXemChiTietClick;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(btnHuyClick != null) 
                btnHuyClick(this, e);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(btnXemChiTiet != null)  
                btnXemChiTietClick(this, e);
        }
    }
}
