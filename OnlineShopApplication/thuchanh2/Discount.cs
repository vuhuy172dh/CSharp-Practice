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
    public partial class Discount : UserControl
    {
        public Discount()
        {
            InitializeComponent();
        }

        public event EventHandler btnApDungClick;
        public event EventHandler btnCoppyClick;


        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (btnCoppyClick != null)
                btnCoppyClick(this, e); 
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            if (btnApDungClick != null) 
                btnApDungClick(this, e);    
        }
    }
}
