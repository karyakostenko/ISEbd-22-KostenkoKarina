using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLocomotive
{
    public partial class FormLocomotiveConfig : Form
    {

        // Переменная-выбранная машина
        //ITransport boat = null;
        Vehicle locomotive = null;
        private event LocomotiveDelegate eventAddLocomotive;
        public FormLocomotiveConfig()
        {
            InitializeComponent();
            panelYellow.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGrey.MouseDown += panelColor_MouseDown;
            panelInfo.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawLocomotive()
        {
            if (locomotive != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
                Graphics gr = Graphics.FromImage(bmp);
                locomotive.SetPosition(5, 100, pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
                locomotive.DrawTransport(gr);
                pictureBoxLocomotive.Image = bmp;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (locomotive != null)
            {
                locomotive.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawLocomotive();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (locomotive != null)
            {
                if (locomotive is Electrovoz)
                {
                    (locomotive as Electrovoz).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawLocomotive();
                }

            }

        }

        // Отрисовать лодку


        public void AddEvent(LocomotiveDelegate ev)
        {
            if (eventAddLocomotive == null)
            {
                eventAddLocomotive = new LocomotiveDelegate(ev);
            }
            else
            {
                eventAddLocomotive += ev;
            }
        }
        // Передаем информацию при нажатии на Label
        private void labelLocomotive_MouseDown(object sender, MouseEventArgs e)
        {

            labelLocomotive.DoDragDrop(labelLocomotive.Text, DragDropEffects.Move | DragDropEffects.Copy);

        }
        // Передаем информацию при нажатии на Label
        private void labelElectrovoz_MouseDown(object sender, MouseEventArgs e)
        {
            labelEletrovoz.DoDragDrop(labelEletrovoz.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

       
        private void panelLocomotive_DragEnter(object sender, DragEventArgs e)
                {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelLocomotive_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Локомотив":
                    locomotive = new Locomotive((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Электровоз":
                    locomotive = new Electrovoz((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                     checkRoga.Checked, checkAkum.Checked);
                    break;
            }
            DrawLocomotive();
        }


        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            eventAddLocomotive?.Invoke(locomotive);

            Close();
        }

        
    }
}
