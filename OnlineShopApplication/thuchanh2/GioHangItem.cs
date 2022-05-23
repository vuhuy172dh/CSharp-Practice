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
    public partial class GioHangItem : UserControl
    {
        public GioHangItem()
        {
            InitializeComponent();
        }

        public event EventHandler btnDelClick;
        public event EventHandler btnIncreaseClick;
        public event EventHandler btnDecreaseClick;

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(btnDelClick != null)
                btnDelClick(this, e);
        }

        private void btnDecrese_Click(object sender, EventArgs e)
        {
            if(btnDecreaseClick != null)
                btnDecreaseClick(this, e);  
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if(btnIncreaseClick != null)
                btnIncreaseClick(this, e);
        }
    }
}
