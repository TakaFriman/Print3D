using Module.AForge;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Print3D
{
    public partial class FormCamera : Form
    {
        private readonly CaptureDeviceManager captureDeviceManager;
        public FormCamera()
        {
            InitializeComponent();
            captureDeviceManager = new CaptureDeviceManager();
            LoadCaptureDevices();
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedValue = cbCaptureDevices.SelectedValue;
                if (selectedValue == null) return;

                LoadDeviceResolutions(selectedValue.ToString());
            }
            catch
            {

            }
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            var mainForm = (FormDetection)Application.OpenForms["FormDetection"];
            if (mainForm == null)
            {
                MessageBox.Show(@"Не может достичь главной формы", @"Ошибка");
                return;
            }

            var deviceSignature = cbCaptureDevices.SelectedValue;
            var deviceResolution = cbVideoResolutions.SelectedIndex;

            if (deviceSignature == null || deviceResolution == -1)
            {
                MessageBox.Show(@"Недостижимое разрешение устройства.", @"Ошибка");
                return;
            }

            var currDevice = captureDeviceManager.GetCaptureDevices().FirstOrDefault(i => i.DeviceSignature.Equals(deviceSignature));
            if (currDevice == null)
            {
                MessageBox.Show(@"Недостижимое устройство.", @"Ошибка");
                return;
            }

            currDevice.Resolution = deviceResolution;
            mainForm.CurrCaptureDevice = currDevice;

            DialogResult = DialogResult.OK;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void LoadCaptureDevices()
        {
            try
            {
                var captureDevices = captureDeviceManager.GetCaptureDevices();
                if (captureDevices == null || !captureDevices.Any()) return;

                cbCaptureDevices.DisplayMember = "Name";
                cbCaptureDevices.ValueMember = "DeviceSignature";
                cbCaptureDevices.DataSource = captureDevices;

                if (cbCaptureDevices.Items.Count > 0)
                    cbCaptureDevices.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Не удается загрузить камеру. Ошибка : {ex.InnerException?.Message}");
            }
        }
            private void LoadDeviceResolutions(string deviceSignature)
            {
                try
                {
                    cbVideoResolutions.Items.Clear();
                    foreach (var reso in captureDeviceManager.GetDeviceResolutions(deviceSignature))
                    {
                        cbVideoResolutions.Items.Add(reso);
                    }

                    if (cbVideoResolutions.Items.Count > 0)
                        cbVideoResolutions.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Разрешение камеры не может быть загруженным. Ошибка : {ex.InnerException?.Message}");
                }
            }

        }
    }

