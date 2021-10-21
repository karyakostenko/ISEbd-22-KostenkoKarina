﻿using System;
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
		/// Метод отрисовки машины
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
			Graphics gr = Graphics.FromImage(bmp);
			locomotive.DrawTransport(gr);
			pictureBoxCars.Image = bmp;
		}
		/// <summary>
		/// Обработка нажатия кнопки "Создать автомобиль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			locomotive = new Locomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			locomotive.SetPosition(100, 100, pictureBoxCars.Width, pictureBoxCars.Height);
			Draw();
		}
		/// <summary>
		/// Обработка нажатия кнопки "Создать гоночный автомобиль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			locomotive = new Electrovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow,true, true);
			locomotive.SetPosition(100, 100, pictureBoxCars.Width, pictureBoxCars.Height);
			Draw();
		}
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
					locomotive.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					locomotive.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					locomotive.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					locomotive.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}

		private void FormLocomotive_Load(object sender, EventArgs e)
		{

		}
	}
}

