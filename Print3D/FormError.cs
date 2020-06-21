using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Print3D
{
    public partial class FormError : Form
    {
        public FormError(string name, string text)
        {
            InitializeComponent();
            richTextBoxText.Text = text;
            labelName.Text = name;
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            try
            {
                if (labelName.Text == "Внешние провисания")
                {
                    pictureBoxImage.Image = new Bitmap(@"App.jpeg");

                }
                if (labelName.Text == "Волнистость")
                {
                    pictureBoxImage.Image = new Bitmap(@"Waviness.jpeg");

                }
                if (labelName.Text == "«Вскип», «Подутость»")
                {
                    pictureBoxImage.Image = new Bitmap(@"Boil.jpeg");

                }
                if (labelName.Text == "Коробление")
                {
                    pictureBoxImage.Image = new Bitmap(@"Distortion.jpeg");

                }
                if (labelName.Text == "Недоэкструзия")
                {
                    pictureBoxImage.Image = new Bitmap(@"Underextrusion.jpeg");


                }
                if (labelName.Text == "Недостаточное заполнение")
                {
                    pictureBoxImage.Image = new Bitmap(@"Underfill.jpeg");

                }
                if (labelName.Text == "Неслойность")
                {
                    pictureBoxImage.Image = new Bitmap(@"NotLayered.jpeg");

                }
                if (labelName.Text == "Несоблюдение осей")
                {
                    pictureBoxImage.Image = new Bitmap(@"NonСompliance.jpeg");

                }
                if (labelName.Text == "Перекос")
                {
                    pictureBoxImage.Image = new Bitmap(@"Sag.jpeg");

                }
                if (labelName.Text == "Пропущенный слой")
                {
                    pictureBoxImage.Image = new Bitmap(@"SkippedLayer.jpeg");

                }
                if (labelName.Text == "Просечки")
                {
                    pictureBoxImage.Image = new Bitmap(@"Punchings.jpeg");

                }
                if (labelName.Text == "«Пушистость»")
                {
                    pictureBoxImage.Image = new Bitmap(@"Downiness.jpeg");

                }
                if (labelName.Text == "Рыхлота")
                {
                    pictureBoxImage.Image = new Bitmap(@"Looseness.jpeg");

                }
                if (labelName.Text == "Слоистость нижнего слоя")
                {
                    pictureBoxImage.Image = new Bitmap(@"Stratification.jpeg");

                }
                if (labelName.Text == "«Слоновья нога»")
                {
                    pictureBoxImage.Image = new Bitmap(@"ElephantLeg.jpeg");

                }
                if (labelName.Text == "Царапины")
                {
                    pictureBoxImage.Image = new Bitmap(@"Scratches.jpeg");

                }
            }
            catch
            {

            }
        }
    }
}
