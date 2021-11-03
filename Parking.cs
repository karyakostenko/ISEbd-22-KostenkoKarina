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
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T> _places;
        /// <summary>
        /// Максимальное количество мест на парковке
        /// </summary>
        private readonly int _maxCount;
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
            int width = picWidth / _placeSizeWidth + 5;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height / 3;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }
       
        public static bool operator +(Parking<T> p, T locomotive)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(locomotive);
            return true;
        }
       
 public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }
            T locomotive = p._places[index];
            p._places.RemoveAt(index);
            return locomotive;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(7 + i % 2 * _placeSizeWidth + 7, i / 2 *
                _placeSizeHeight + 70, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < 2 * pictureWidth / _placeSizeWidth; i++)
            {
                int h = 0;
                if (i > 0) { h = 1; }
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth / 2, j * _placeSizeHeight, i * _placeSizeWidth + (_placeSizeWidth / 2) + 100, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth / 2 + 500, h * 440, i * _placeSizeWidth / 2 + 500, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}