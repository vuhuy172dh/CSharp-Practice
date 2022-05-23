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
    public partial class DoiDiaChi : Form
    {
        public DoiDiaChi()
        {
            InitializeComponent();
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if(textBoxDiaChi.Text.Length != 0)
            {
                Dataframe.UserData.Rows[0]["Address"] = textBoxDiaChi.Text;
                OpenChildForm(new GioHang());
                this.Close();
            }
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GioHang());
            this.Close();
        }
    }
}
