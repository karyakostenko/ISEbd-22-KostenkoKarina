using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;


namespace WindowsFormsLocomotive
{
    public partial class FormParking : Form
    {

        private readonly ParkingCollection parkingCollection;
        private readonly Logger logger;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
        }

        public void ReloadLevels() 
        {
            int index = listBoxParkinga.SelectedIndex;

            listBoxParkinga.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++) 
            {
                listBoxParkinga.Items.Add(parkingCollection.Keys[i]);
            }

            if (listBoxParkinga.Items.Count > 0 && (index == -1 || index >= listBoxParkinga.Items.Count))
            {
                listBoxParkinga.SelectedIndex = 0;
            }
            else if (listBoxParkinga.Items.Count > 0 && index > -1 && index < listBoxParkinga.Items.Count) 
            {
                listBoxParkinga.SelectedIndex = index;
            }

        }
        private void Draw()
        {
            if (listBoxParkinga.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkinga.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

//забрать кнопка
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxParkinga.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var locomotive = parkingCollection[listBoxParkinga.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (locomotive != null)
                    {
                        FormLocomotive form = new FormLocomotive();
                        form.SetLocomotive(locomotive);
                        form.ShowDialog();
                        logger.Info($"Изъят локомотив {locomotive} с места {maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (ParkingNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Добавить парковку
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        //удалить парковку
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBoxParkinga.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxParkinga.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили парковку {listBoxParkinga.SelectedItem.ToString()}");
                    parkingCollection.DelParking(textBoxNewLevelName.Text);
                    ReloadLevels();
                }               
            }
        }

        private void listBoxParkinga_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxParkinga.SelectedItem.ToString()}");
            Draw();
        }
        //добавить лодку
        private void button6_Click(object sender, EventArgs e)
        {
            var formLocomotiveConfig = new FormLocomotiveConfig();         
            formLocomotiveConfig.AddEvent(AddLocomotive);
            formLocomotiveConfig.Show();
        }

        private void AddLocomotive(Vehicle locomotive)
        {
            if (locomotive != null && listBoxParkinga.SelectedIndex > -1)
            {
                try
                {
                    if ((parkingCollection[listBoxParkinga.SelectedItem.ToString()]) + locomotive)
                    {
                        Draw();
                        logger.Info($"Добавлен локомотив {locomotive}");
                    }
                    else
                    {
                        MessageBox.Show("Локомотив не удалось поставить");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog1.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog1.FileName);
                    ReloadLevels();
                    Draw();
                }
               
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxParkinga.SelectedIndex > -1)
            {
                parkingCollection[listBoxParkinga.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }

        
    }
}
