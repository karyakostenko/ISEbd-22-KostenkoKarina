using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsLocomotive
{
	public partial class FormLocomotive : Form
	{
		private ITransport locomotive;
		/// <summary>
		/// Конструктор
		/// </summary>
		public FormLocomotive()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Передача машины на форму
		/// </summary>
		/// <param name="locomotive"></param>
		public void SetLocomotive(ITransport locomotive)
		{
			this.locomotive = locomotive;
			Draw();
		}
		/// <summary>
		/// Метод отрисовки машины
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
			Graphics gr = Graphics.FromImage(bmp);
			locomotive?.DrawTransport(gr);
			pictureBoxLocomotive.Image = bmp;
		}
		/// <summary>
		/// Обработка нажатия кнопки "Создать автомобиль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		
		/// <summary>
		/// Обработка нажатия кнопок управления
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					locomotive?.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					locomotive?.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					locomotive?.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					locomotive?.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}