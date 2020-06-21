using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Print3D
{
    public partial class FormPrint3D : System.Windows.Forms.Form
    {
        private IconButton currentbtn;
        private Panel lefBorderBtn;
        private System.Windows.Forms.Form currentChildForm;
        private bool flag = true;


        public FormPrint3D()
        {
            InitializeComponent();
            lefBorderBtn = new Panel();
            lefBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(lefBorderBtn);
            // form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColor
        {   
            public static Color color1 = Color.Yellow;
            public static Color color2 = Color.Orange;
            public static Color color3 = Color.Orchid;
            public static Color color4 = Color.GhostWhite;
            public static Color color5 = Color.BlueViolet;
            public static Color color6 = Color.Red;
            public static Color color7 = Color.Khaki;



        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //left button
                lefBorderBtn.BackColor = color;
                lefBorderBtn.Location = new Point(0, currentbtn.Location.Y);
                lefBorderBtn.Visible = true;
                lefBorderBtn.BringToFront();

                iconPictureBoxH.IconChar = currentbtn.IconChar;
                iconPictureBoxH.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentbtn != null)
            {
                if (flag)
                {
                    currentbtn.BackColor = Color.MidnightBlue;
                    currentbtn.ForeColor = Color.Gainsboro;
                    currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentbtn.IconColor = Color.Gainsboro;
                    currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
                else if (!flag)
                {
                    currentbtn.BackColor = Color.FromArgb(11, 7, 17); ;
                    currentbtn.ForeColor = Color.Gainsboro;
                    currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentbtn.IconColor = Color.Gainsboro;
                    currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentbtn.ImageAlign = ContentAlignment.MiddleLeft;

                }
            }

        }
        private void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDekstop.Controls.Add(childForm);
            panelDekstop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTextH.Text = childForm.Text;


        }
        //Переход на форму "Ошибки печати"
        private void iconButtonError_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new FormIconButtonError());
            labelTextH.Text = "Ошибки печати";
        }
        //Переход на форму "Random"
        private void iconButtonRnd_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            OpenChildForm(new FormIconButtonRnd());
            labelTextH.Text = "Random";

        }
        //Переход на форму "Распознавание"
        private void iconButtonNew_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
            OpenChildForm(new FormDetection());
            labelTextH.Text = "Распознавание";
        }
        //Переход на форму "Помощь"
        private void iconButtonHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
            OpenChildForm(new FormIconButtonHelp());
            labelTextH.Text = "Помощь";
        }
        //Темная тема
        private void iconButtonColor_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                iconButtonColor.BackColor = Color.FromArgb(11, 7, 17);
                iconButtonHelp.BackColor = Color.FromArgb(11, 7, 17);
                iconButtonRnd.BackColor = Color.FromArgb(11, 7, 17);
                iconButtonError.BackColor = Color.FromArgb(11, 7, 17);
                iconButtonNew.BackColor = Color.FromArgb(11, 7, 17);

                ActivateButton(sender, RGBColor.color6);
                panelMenu.BackColor = Color.FromArgb(11, 7, 17);
                panel.BackColor = Color.FromArgb(11, 7, 17);
                panelLogo.BackColor = Color.FromArgb(11, 7, 17);
                panelShadow.BackColor = Color.FromArgb(11, 7, 17);
                iconButtonExit.BackColor = Color.FromArgb(11, 7, 17);

                iconButtonMin.BackColor = Color.FromArgb(11, 7, 17);

                iconButtonMin.ForeColor = Color.FromArgb(11, 7, 17);
                iconButtonExit.ForeColor = Color.FromArgb(11, 7, 17);
                panelDekstop.BackColor = Color.FromArgb(23, 21, 32);
                iconPictureBoxH.BackColor = Color.FromArgb(11, 7, 17);
                flag = false;
            }
            else
            {

                iconButtonColor.BackColor = Color.MidnightBlue;
                iconButtonHelp.BackColor = Color.MidnightBlue;
                iconButtonRnd.BackColor = Color.MidnightBlue;
                iconButtonError.BackColor = Color.MidnightBlue;

                iconButtonNew.BackColor = Color.MidnightBlue;
                ActivateButton(sender, RGBColor.color7);
                panelMenu.BackColor = Color.MidnightBlue;
                panel.BackColor = Color.MidnightBlue;
                panelLogo.BackColor = Color.MidnightBlue;
                panelShadow.BackColor = Color.MidnightBlue;
                iconButtonExit.BackColor = Color.MidnightBlue;
                iconPictureBoxH.BackColor = Color.MidnightBlue;
                iconButtonMin.BackColor = Color.MidnightBlue;

                iconButtonMin.ForeColor = Color.MidnightBlue;
                iconButtonExit.ForeColor = Color.MidnightBlue;
                panelDekstop.BackColor = Color.FromArgb(10, 10, 105);
                flag = true;

            }
        }
        private void Reset()
        {
            DisableButton();
            lefBorderBtn.Visible = false;
            iconPictureBoxH.IconChar = IconChar.Home;
            iconPictureBoxH.IconColor = Color.DarkOrchid;
            labelTextH.Text = "Главное меню";
        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

  
       

       

        private void FormPrint3D_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            notifyIcon.ContextMenuStrip = contextMenuStrip1;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }
    
        

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void pictureBoxDom_Click(object sender, EventArgs e)
        {
            try
            {
                currentChildForm.Close();
                Reset();
            }
            catch
            {

            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
