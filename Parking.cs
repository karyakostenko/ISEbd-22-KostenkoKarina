using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsLocomotive
{
	/// <summary>
	/// Параметризованный класс для хранения набора объектов от интерфейса ITransport
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Parking<T> where T : class, ITransport
	{
		/// <summary>
		/// Массив объектов, которые храним
		/// </summary>
		private readonly T[] _places;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private readonly int pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private readonly int pictureHeight;
		/// <summary>
		/// Размер парковочного места (ширина)
		/// </summary>
		private readonly int _placeSizeWidth = 510;
		/// <summary>
		/// Размер парковочного места (высота)
		/// </summary>
		private readonly int _placeSizeHeight = 220;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="picWidth">Рамзер парковки - ширина</param>
		/// <param name="picHeight">Рамзер парковки - высота</param>
		public Parking(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth+1;
			int height = picHeight / _placeSizeHeight;
			_places = new T[width * height];
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}

		public static int operator +(Parking<T> p, T locomotive)
		{

			int x = 10;
			int rowsCount = p.pictureHeight / p._placeSizeHeight;
			for (int i = 0; i < p._places.Length; i++)
			{
				if (p._places[i] == null)
				{
					locomotive.SetPosition(x + p._placeSizeWidth * (i % rowsCount), x + 15 + p._placeSizeHeight * (i / rowsCount), p.pictureWidth, p.pictureHeight);
					p._places[i] = locomotive;
					return i;
				}
			}
			return -1;
			// Прописать логику для сложения
		}
		
		public static T operator -(Parking<T> p, int index)  
		{

			if (index >= 0 && index < p._places.Length && p._places[index] != null)
			{
				T temp = p._places[index];
				p._places[index] = null;
				return temp;
			}
			return null;
			// Прописать логику для вычитания
		}
		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		/// <param name="g"></param>
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				_places[i]?.DrawTransport(g);
			}
		}
		/// <summary>
		/// Метод отрисовки разметки парковочных мест
		/// </summary>
		/// <param name="g"></param>
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			for (int i = 0; i < 2*pictureWidth / _placeSizeWidth; i++)
			{
				int h = 0;
				if (i > 0) { h = 1; }
				for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
				{//линия рамзетки места
					g.DrawLine(pen, i * _placeSizeWidth/2, j * _placeSizeHeight, i * _placeSizeWidth + (_placeSizeWidth /2)+100, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth/2+500, h*440, i * _placeSizeWidth/2+500, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
	}
}