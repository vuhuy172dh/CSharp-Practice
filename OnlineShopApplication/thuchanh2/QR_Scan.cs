using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace thuchanh2
{
    public partial class QR_Scan : Form
    {
        public QR_Scan()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInforCollection;
        VideoCaptureDevice captureDevice;

        private void QR_Scan_Load(object sender, EventArgs e)
        {
            filterInforCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInforCollection)
                comboBoxCamera.Items.Add(filterInfo.Name);
            comboBoxCamera.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInforCollection[comboBoxCamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void QR_Scan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(captureDevice != null)
            {
                if (captureDevice.IsRunning == true)
                    captureDevice.Stop();
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(picBoxCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                //Image img = cv2.imread(Application.StartupPath + "//qr//Untitled.png");
                Result result = barcodeReader.Decode((Bitmap)picBoxCamera.Image);
                if(result != null)
                {
                    textBoxMaDon.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    
                } 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler xemChiTietClick;

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(xemChiTietClick != null)
                xemChiTietClick(this, e);
        }
    }
}
