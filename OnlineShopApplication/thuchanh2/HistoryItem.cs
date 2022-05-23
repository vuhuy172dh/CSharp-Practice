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
    public partial class HistoryItem : UserControl
    {
        public HistoryItem()
        {
            InitializeComponent();
        }

        public event EventHandler btnViewClick;
        public event EventHandler btnLikeClick;

        private void btnView_Click(object sender, EventArgs e)
        {
            if (btnViewClick != null)
                this.btnViewClick(this, e);
        }

        

        private void lblLike_Click(object sender, EventArgs e)
        {
            if (btnLikeClick != null)
                this.btnLikeClick(this, e);
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (btnLikeClick != null)
                this.btnLikeClick(this, e);
        }
    }
}
