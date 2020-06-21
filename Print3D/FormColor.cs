using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print3D
{
    public partial class FormColor : Form
    {
        private readonly FormDetection mainForm = (FormDetection)Application.OpenForms["FormDetection"];

        public FormColor()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            chkActivePassive.Checked = mainForm.ActivateColorTracking;
            redTrackBar.Value = mainForm.Red;
            greenTrackBar.Value = mainForm.Green;
            blueTrackBar.Value = mainForm.Blue;
            int R = redTrackBar.Value;
            int G = greenTrackBar.Value;
            int B = blueTrackBar.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkActivePassive_CheckedChanged(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                mainForm.ActivateColorTracking = chkActivePassive.Checked;
            });
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                mainForm.Red = redTrackBar.Value;
                labelRed.Text = redTrackBar.Value.ToString();
            }
           );
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {

                mainForm.Green = greenTrackBar.Value;
                labelGreen.Text = greenTrackBar.Value.ToString();
            });
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                mainForm.Blue = blueTrackBar.Value;
                labelBlue.Text = blueTrackBar.Value.ToString();

            });
        }

        private void FormColor_Load(object sender, EventArgs e)
        {
            labelRed.Text = redTrackBar.Value.ToString();
            labelGreen.Text = greenTrackBar.Value.ToString();
            labelBlue.Text = blueTrackBar.Value.ToString();
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            int R = redTrackBar.Value;
            int G = greenTrackBar.Value;
            int B = blueTrackBar.Value;
            panelColor.BackColor = Color.FromArgb(R, G, B);
        }
    }
}
