using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCars
{
	public class Car : Vehicle
	{
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		protected readonly int carWidth = 90;
		/// <summary>
		/// Высота отрисовки автомобиля
		/// </summary>
		protected readonly int carHeight = 50;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		public Car(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		
		/// <summary>
		/// Конструкторс изменением размеров машины
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="carWidth">Ширина отрисовки автомобиля</param>
		/// <param name="carHeight">Высота отрисовки автомобиля</param>
		protected Car(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.carWidth = carWidth;
			this.carHeight = carHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			int a = 670;
			int b = 65;
			int c = 60;
			int d = 350;
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
		    
				// вправо
				case Direction.Right:
					if (_startPosX - step < _pictureWidth + carWidth + a)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX + step > _pictureWidth + carWidth - b)
					{
						_startPosX -= step;
					}
					break;

				//вверх
				case Direction.Up:
					if (_startPosY + step > _pictureHeight + carHeight+c)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY - step < _pictureHeight + carHeight + d)
					{

						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);


			// вагон
			g.DrawRectangle(pen, _startPosX + 10, _startPosY - 1, 400, 100);
			g.DrawRectangle(pen, _startPosX + 10, _startPosY - 1, 400, 75);
			g.DrawRectangle(pen, _startPosX + 130, _startPosY + 100, 160, 30);

			g.DrawRectangle(pen, _startPosX + 20, _startPosY + 5, 50, 50);
			g.DrawRectangle(pen, _startPosX + 350, _startPosY + 5, 50, 50);

			g.DrawRectangle(pen, _startPosX - 20, _startPosY + 80, 30, 15);
			g.DrawRectangle(pen, _startPosX + 410, _startPosY + 80, 30, 15);

			Brush brGray = new SolidBrush(Color.Gray);
			g.FillRectangle(brGray, _startPosX + 10, _startPosY - 1, 400, 100);
			g.FillRectangle(brGray, _startPosX + 130, _startPosY + 100, 160, 30);
			Brush brRed = new SolidBrush(Color.Red);
			g.FillRectangle(brRed, _startPosX + 10, _startPosY - 1, 400, 75);
			Brush brBlue = new SolidBrush(Color.LightBlue);
			g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 5, 50, 50);
			g.FillRectangle(brBlue, _startPosX + 350, _startPosY + 5, 50, 50);
			//колеса
			g.DrawEllipse(pen, _startPosX + 10, _startPosY + 100, 40, 40);
			g.DrawEllipse(pen, _startPosX + 50, _startPosY + 100, 40, 40);
			g.DrawEllipse(pen, _startPosX + 90, _startPosY + 100, 40, 40);

			g.DrawEllipse(pen, _startPosX + 290, _startPosY + 100, 40, 40);
			g.DrawEllipse(pen, _startPosX + 330, _startPosY + 100, 40, 40);
			g.DrawEllipse(pen, _startPosX + 370, _startPosY + 100, 40, 40);

			Brush brBlack = new SolidBrush(Color.Black);
			g.FillEllipse(brBlack, _startPosX + 10, _startPosY + 100, 40, 40);
			g.FillEllipse(brBlack, _startPosX + 50, _startPosY + 100, 40, 40);
			g.FillEllipse(brBlack, _startPosX + 90, _startPosY + 100, 40, 40);

			g.FillEllipse(brBlack, _startPosX + 290, _startPosY + 100, 40, 40);
			g.FillEllipse(brBlack, _startPosX + 330, _startPosY + 100, 40, 40);
			g.FillEllipse(brBlack, _startPosX + 370, _startPosY + 100, 40, 40);

			g.FillRectangle(brBlack, _startPosX - 20, _startPosY + 80, 30, 15);
			g.FillRectangle(brBlack, _startPosX + 410, _startPosY + 80, 30, 15);
		}
	}
}