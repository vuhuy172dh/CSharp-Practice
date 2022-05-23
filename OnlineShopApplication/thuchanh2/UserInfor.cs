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
    public partial class UserInfor : Form
    {
        public UserInfor()
        {
            InitializeComponent();
            Load_data(Dataframe.UserData);
            pictureBox1.Image = cv2.imread(Dataframe.imageLocation);
        }

        private void Load_data(DataTable table)
        {
            foreach (DataRow dr in table.Rows)
            {
                textBoxName.Text = dr["Name"].ToString();
                textBoxNickname.Text = dr["Nickname"].ToString();
                lblEmail.Text = dr["Email"].ToString();
                lblSoDienThoai.Text = dr["Phone"].ToString();
                textBoxNgaysinh.Text = dr["Ngày sinh"].ToString();
                textBoxGioitinh.Text = dr["Giới tính"].ToString();
                textBoxQuoctich.Text = dr["Quốc tịch"].ToString();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All Files (*.*)|*.*";

            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Dataframe.imageLocation = dialog.FileName;

                pictureBox1.Image = cv2.imread(Dataframe.imageLocation);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonHangCuaToi());
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

        private void label12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Liked());
            this.Close();
        }
    }
}
