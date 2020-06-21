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
    public partial class FormIconButtonRnd : Form
    {
        public FormIconButtonRnd()
        {
            InitializeComponent();
        }
        string[] mas = { "Отклеивание от платформы", "Изгибание платформы", "Слои поплыли", "Несоблюдение вертикали", "Слои не ложатся ровно друг на друга", "Предметы круглой формы не получились круглыми", "Несоблюдение параллельности", "Появились дырки на внешнем слое", "Толстые нижние слои", "Несхожие слои в основании", "Пластик между двумя деталями", " Изменились цвета у краёв детали", " Дефекты по краям", "Провисание пластика на детали", "Четко выраженный нижний слой", "Толстые линии нижнего слоя", "Дырки в печати", " Проблемы со слоями", "Дефекты на поверхности детали", " Стенки не соединяются между собой", "Пустоты в стенках", "Царапинны на поверхности и неравномерность по цвету", "Неправильное заполнение детали", "Печать поддержек происходит там, где их не должно быть", "Модель как будто покрыта \"волосами\"", "\"Сопли\"", "Провисания", "Слой отличался от остальных слоёв модели", "Модель слоиться", "Не соблюдается прямой угол" };

        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int temp = rnd.Next(mas.Length);

            richTextBoxOutput.Text = " " + mas[temp];
            if (mas[temp] == mas[0] || mas[temp] == mas[1])
            {

                labelStart.Text = "Коробление";

            }
            if (mas[temp] == mas[2] || mas[temp] == mas[3] || mas[temp] == mas[4])
            {

                labelStart.Text = "Перекос";

            }
            if (mas[temp] == mas[5] || mas[temp] == mas[6])
            {

                labelStart.Text = "Неслойность";

            }
            if (mas[temp] == mas[7])
            {

                labelStart.Text = "Вскип, Подутость";

            }
            if (mas[temp] == mas[8] || mas[temp] == mas[9])
            {

                labelStart.Text = "Слоновья нога ";

            }
            if (mas[temp] == mas[10])
            {

                labelStart.Text = "Внешние провисания";

            }
            if (mas[temp] == mas[11] || mas[temp] == mas[12])
            {

                labelStart.Text = "Волнистость";

            }
            if (mas[temp] == mas[13])
            {

                labelStart.Text = "Рыхлота";

            }
            if (mas[temp] == mas[14] || mas[temp] == mas[15])
            {

                labelStart.Text = "Слоистость нижнего слоя";

            }
            if (mas[temp] == mas[16] || mas[temp] == mas[17] || mas[temp] == mas[18])
            {

                labelStart.Text = "Недоэкструзия";

            }
            if (mas[temp] == mas[19] || mas[temp] == mas[20])
            {

                labelStart.Text = "Просечки";

            }
            if (mas[temp] == mas[21])
            {

                labelStart.Text = "Царапины";

            }
            if (mas[temp] == mas[22] || mas[temp] == mas[23])
            {

                labelStart.Text = "Недостаточное заполнение";

            }
            if (mas[temp] == mas[24] || mas[temp] == mas[25] || mas[temp] == mas[26])
            {

                labelStart.Text = "Пушистость";

            }
            if (mas[temp] == mas[27] || mas[temp] == mas[28])
            {

                labelStart.Text = "Пропущенный слой";

            }
            if (mas[temp] == mas[29])
            {

                labelStart.Text = "Несоблюдение осей";

            }

            labelPer.Text = "Подробнее об ошибках в разделе  \"Ошибки печати\" ";
        }
    }
}
