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
	public partial class FormParking : Form
	{
		/// <summary>
		/// Объект от класса-парковки
		/// </summary>
		private readonly Parking<Locomotive> parking;
		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<Locomotive>(pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}
		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxParking.Image = bmp;
		}
		/// <summary>
		/// Обработка нажатия кнопки "Припарковать автомобиль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetLocomotiv_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var locomotive = new Locomotive(100, 1000, dialog.Color);
				if ((parking + locomotive) > -1)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}
		/// <summary>
		/// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetElectrovoz_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var locomotive = new Electrovoz(100, 1000, dialog.Color, dialogDop.Color, true, true );
					if ((parking + locomotive) > -1)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
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
			if (maskedTextBox.Text != "")
			{
				var locomotive = parking - Convert.ToInt32(maskedTextBox.Text);
				if (locomotive != null)
				{
					FormLocomotive form = new FormLocomotive();
					form.SetLocomotive(locomotive);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}