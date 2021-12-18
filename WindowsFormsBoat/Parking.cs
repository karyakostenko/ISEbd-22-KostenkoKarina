using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace WindowsFormsLocomotive
{
    public class Parking<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
    {

        private readonly List<T> _places;
        //Максимальное количество мест на парковке
        private readonly int _maxCount;
        //Ширина окна отрисовки
        private readonly int pictureWidth;
        //Высота окна отрисовки
        private readonly int pictureHeight;
        //Размер парковочного места(ширина)
        private readonly int _placeSizeWidth = 510;
        //Размер парковочного места(высота)
        private readonly int _placeSizeHeight = 220;

        private int _currentIndex;

        public T Current => _places[_currentIndex];

        object IEnumerator.Current => _places[_currentIndex];

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth + 5;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height / 3;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }

        public static bool operator +(Parking<T> p, T locomotive)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.Contains(locomotive))
            {
                throw new ParkingAlreadyHaveException();
            }
            p._places.Add(locomotive);
            return true;
        }
        
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                throw new ParkingNotFoundException(index);
            }
            T locomotive = p._places[index];
            p._places.RemoveAt(index);
            return locomotive;
        }



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

        public T GetNext(int index)
        {
            if (index < -1 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        public void Sort() => _places.Sort((IComparer<T>)new LocomotiveComparer());

        public void Dispose()
        {
        }


        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _places.Count;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
