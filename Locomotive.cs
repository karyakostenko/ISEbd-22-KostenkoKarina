﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
	public class Locomotive : Vehicle
	{
		
		protected readonly int locomotiveWidth = 450;
		
		protected readonly int locomotiveHeight = 150;
		/// <summary>
		/// Конструктор
		/// </summary>
		
		public Locomotive(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		
		
		protected Locomotive(int maxSpeed, float weight, Color mainColor, int locomotiveWidth, int locomotiveHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.locomotiveWidth = locomotiveWidth;
			this.locomotiveHeight = locomotiveHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - locomotiveWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;

				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - locomotiveHeight)
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