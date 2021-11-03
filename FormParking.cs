﻿using System;
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
	public partial class FormParking : Form
	{
		/// <summary>
		/// Объект от класса-коллекции парковок
		/// </summary>
		private readonly ParkingCollection parkingCollection;
		public FormParking()
		{
			InitializeComponent();
			parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
		}
		/// <summary>
		/// Заполнение listBoxLevels
		/// </summary>
		private void ReloadLevels()
		{
			int index = listBoxParkings.SelectedIndex;
			listBoxParkings.Items.Clear();
			for (int i = 0; i < parkingCollection.Keys.Count; i++)
			{
				listBoxParkings.Items.Add(parkingCollection.Keys[i]);
			}
			if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
			{
				listBoxParkings.SelectedIndex = 0;
			}
			else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
			{
				listBoxParkings.SelectedIndex = index;
			}
		}
		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		private void Draw()
		{
			if (listBoxParkings.SelectedIndex > -1)
			{//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
				Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
				pictureBoxParking.Image = bmp;
			}
		}
		/// <summary>
		/// Обработка нажатия кнопки "Добавить парковку"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonAddParking_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			parkingCollection.AddParking(textBoxNewLevelName.Text);
			ReloadLevels();
		}
		/// <summary>
		/// Обработка нажатия кнопки "Удалить парковку"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDelParking_Click(object sender, EventArgs e)
		{
			if (listBoxParkings.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					parkingCollection.DelParking(textBoxNewLevelName.Text);
					ReloadLevels();
				}
			}
		}
		/// <summary>
		/// Обработка нажатия кнопки "Забрать"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonTakeLocomotive_Click(object sender, EventArgs e)
		{
			if (listBoxParkings.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				var locomotive = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
				if (locomotive != null)
				{
					FormLocomotive form = new FormLocomotive();
					form.SetLocomotive(locomotive);
					form.ShowDialog();
				}
				Draw();
			}
		}
		/// <summary>
		/// Метод обработки выбора элемента на listBoxLevels
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}
		/// <summary>
		/// Обработка нажатия кнопки "Добавить автомобиль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetLocomotive_Click(object sender, EventArgs e)
		{
			var formLocomotiveConfig = new FormLocomotiveConfig();
			formLocomotiveConfig.AddEvent(AddLocomotive);
			formLocomotiveConfig.Show();
		}
		/// <summary>
		/// Метод добавления машины
		/// </summary>
		/// <param name="locomotive"></param>
		private void AddLocomotive(Vehicle locomotive)
		{
			if (locomotive != null && listBoxParkings.SelectedIndex > -1)
			{
				if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + locomotive)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Машину не удалось поставить");
				}
			}
		}
	}
}