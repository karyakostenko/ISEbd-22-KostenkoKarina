﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
	public abstract class Vehicle : ITransport
	{
	
		protected float _startPosX;
		
		protected float _startPosY;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		protected int _pictureWidth=550;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		protected int _pictureHeight =600;
		/// <summary>
		/// Максимальная скорость
		/// </summary>
		public int MaxSpeed { protected set; get; }
		
		public float Weight { protected set; get; }
		/// <summary>
		/// Основной цвет кузова
		/// </summary>
		public Color MainColor { protected set; get; }
		public  void SetPosition(int x, int y, int width, int height)
		{
			
			_startPosX = x;
			_startPosY = y+50;
		}
		public abstract void DrawTransport(Graphics g);
		public abstract void MoveTransport(Direction direction);
	}
}