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
		/// <summary>
		/// Переменная-выбранная машина
		/// </summary>
		Locomotive locomotive = null;
		/// <summary>
		/// Событие
		/// </summary>
		//private event CarDelegate eventAddCar;
		private event Action<Locomotive> eventAddLocomotive;
		public FormLocomotiveConfig()
		{
			InitializeComponent();
			// привязать panelColor_MouseDown к панелям с цветами
			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}
		/// <summary>
		/// Отрисовать машину
		/// </summary>
		private void DrawLocomotive()
		{
			if (locomotive != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
				Graphics gr = Graphics.FromImage(bmp);
				locomotive.SetPosition(5, 120, pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
				locomotive.DrawTransport(gr);
				pictureBoxLocomotive.Image = bmp;
			}
		}
		/// <summary>
		/// Добавление события
		/// </summary>
		/// <param name="ev"></param>
		public void AddEvent(Action<Locomotive> ev)
		{
			if (eventAddLocomotive == null)
			{
				eventAddLocomotive = ev;
			}
			else
			{
				eventAddLocomotive += ev;
			}
		}
		/// <summary>
		/// Передаем информацию при нажатии на Label
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelLocomotive_MouseDown(object sender, MouseEventArgs e)
		{
			labelLocomotive.DoDragDrop(labelLocomotive.Name, DragDropEffects.Move | DragDropEffects.Copy);
		}
		/// <summary>
		/// Передаем информацию при нажатии на Label
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelElectrovoz_MouseDown(object sender, MouseEventArgs e)
		{
			labelElectrovoz.DoDragDrop(labelElectrovoz.Name, DragDropEffects.Move | DragDropEffects.Copy);
		}
		/// <summary>
		/// Проверка получаемой информации (ее типа на соответствие требуемому)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		/// <summary>
		/// Действия при приеме перетаскиваемой информации
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void panelLocomotive_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "labelLocomotive":
					locomotive = new Locomotive((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
					break;
				case "labelElectrovoz":
					locomotive = new Electrovoz((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
					 checkRoga.Checked, checkAkum.Checked);
					break;
			}
			DrawLocomotive();
		}
		/// <summary>
		/// Отправляем цвет с панели
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			// Прописать логику вызова dragDrop для панелей, используя sender
			(sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);

		}
		/// <summary>
		/// Проверка получаемой информации (ее типа на соответствие требуемому)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			//logika
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;

			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		/// <summary>
		/// Принимаем основной цвет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			// Прописать логику смены базового цвета
			if (locomotive != null)
			{
				locomotive.SetMainColor((Color)e.Data.GetData(typeof(Color)));
				DrawLocomotive();
			}

		}
		/// <summary>
		/// Принимаем дополнительный цвет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			// Прописать логику смены дополнительного цвета, если объект является объектом дочернего класса
			if (locomotive != null)
			{
				if (locomotive is Electrovoz)
				{
					(locomotive as Electrovoz).SetDopColor((Color)e.Data.GetData(typeof(Color)));
					DrawLocomotive();
				}

			}
		}
		/// <summary>
		/// Добавление машины
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonOk_Click(object sender, EventArgs e)
		{
			eventAddLocomotive?.Invoke(locomotive);
			Close();
		}
	}
}