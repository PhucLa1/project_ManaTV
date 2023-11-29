using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace project_ManaTV.Views.FuncFrm.ProductView.Product
{
    public partial class CameraScanner : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public CameraScanner()
        {
            InitializeComponent();
        }

        private void CameraScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cboCamera.Items.Add(device.Name);
            }
            cboCamera.SelectedIndex = 0;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            picCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void picCamera_Click(object sender, EventArgs e)
        {

        }

        private void CameraScanner_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            if(videoCaptureDevice.IsRunning) videoCaptureDevice.Stop();
            
        }

        public event EventHandler<string> BarcodeScanned;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picCamera.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)picCamera.Image);
                if (result != null)
                {
                    string barcodeText = result.Text;
                    txtBarcode.Text = barcodeText;

                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning) videoCaptureDevice.Stop();

                    BarcodeScanned?.Invoke(this, barcodeText);
                    this.Close();
                }
            }
        }
    }
}
