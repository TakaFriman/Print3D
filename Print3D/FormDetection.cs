using Module.AForge.Extensions;
using Module.AForge.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Print3D
{
    public partial class FormDetection : Form
    {
        public CaptureDevice CurrCaptureDevice { get; set; }
        public bool ActivateColorTracking = false;
        public bool ShowOrjinalOrProcessImage = true;
        public bool MultiOrSingleTracking = true;
        public int Red;
        public int Green;
        public int Blue;
        public FormDetection()
        {
            InitializeComponent();
        }
        public void NewFramEventHandler(object sender, Bitmap bitmap)
        {
            try
            {
                if (!ActivateColorTracking)
                {
                    var clone = (Bitmap)bitmap.Clone();
                    pbOrjinalimage.Image = clone;
                    return;
                }

                if (ShowOrjinalOrProcessImage)
                {
                    var processedOrjinalBitmap = bitmap.FindObjectsOnOrjinal(penColor: Color.Red, filterColor: Color.FromArgb(Red, Green, Blue), multiple: MultiOrSingleTracking);
                    pbOrjinalimage.Image = processedOrjinalBitmap;
                    return;
                }

                var filteredBitmap = bitmap.EuclideanFilter(Color.FromArgb(Red, Green, Blue));
                var processedFilteredBitmap = filteredBitmap.FindObjectsOnFiltered(Color.Red, multiple: MultiOrSingleTracking);
                pbOrjinalimage.Image = processedFilteredBitmap;

            }
            catch
            {
                //ignored
            }
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrCaptureDevice != null && CurrCaptureDevice.IsRunning())
                CurrCaptureDevice.Dispose();
            CurrCaptureDevice = null;

            var frmSetCamera = new FormCamera();
            if (frmSetCamera.ShowDialog() != DialogResult.OK) return;

            if (CurrCaptureDevice != null)
            {
                // ReSharper disable once DelegateSubtraction
                CurrCaptureDevice.NewFramEventHandler -= NewFramEventHandler;
                CurrCaptureDevice.NewFramEventHandler += NewFramEventHandler;
            }
            startToolStripMenuItem_Click(null, null);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrCaptureDevice == null)
            {
                MessageBox.Show("Выберите камеру!", "Ошибка!");
                return;
            }
            CurrCaptureDevice.StartCapture();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrCaptureDevice == null)
            {
                MessageBox.Show("Выберите камеру!", "Ошибка!");
                return;
            }
            CurrCaptureDevice.StopCapture();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrCaptureDevice == null)
            {
                MessageBox.Show("Выберите камеру!", "Ошибка!");
                return;
            }
            CurrCaptureDevice.StopCapture();
            pbOrjinalimage.Image = null;
            pbOrjinalimage.BackColor = Color.Gainsboro;
        }

        private void showOrjinalOrProcessImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrjinalOrProcessImage = showOrjinalOrProcessImageToolStripMenuItem.Checked;
        }

        private void multiOrSingleTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiOrSingleTracking = multiOrSingleTrackingToolStripMenuItem.Checked;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (CurrCaptureDevice != null && CurrCaptureDevice.IsRunning())
            {
                try
                {
                    CurrCaptureDevice.StopCapture();
                    CurrCaptureDevice = null;
                }
                catch
                {
                    // ignored
                }
            }

            base.OnClosing(e);
        }

        private void colorTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSetColor = (FormColor)Application.OpenForms["FormColor"];
            frmSetColor?.Focus();

            if (frmSetColor != null) return;
            frmSetColor = new FormColor();
            frmSetColor.Show();
        }
    }
}
