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
    public partial class ShowItem : UserControl
    {
        public ShowItem()
        {
            InitializeComponent();
        }

        public event EventHandler btnViewClick;
        public event EventHandler pctMouseHover;
        public event EventHandler pctMouseLeave;
        
        private void picBoxShowItem_MouseHover(object sender, EventArgs e)
        {
            if(this.pctMouseHover != null)
                this.pctMouseHover(this, e); 
        }

        private void lblName_MouseHover(object sender, EventArgs e)
        {
            if(this.pctMouseHover != null) 
                this.pctMouseHover(this,e);
        }

        private void btnView_MouseLeave(object sender, EventArgs e)
        {
            if(this.pctMouseLeave!= null)
                this.pctMouseLeave(this,e);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(this.btnViewClick != null)
                this.btnViewClick(this, e);
        }
    }
}
