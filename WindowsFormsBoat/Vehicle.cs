using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
    public abstract class Vehicle : ITransport
    {
        //Левая координата отрисовски лодки
        protected float _startPosX;
        //Правая координата отрисовски лодки
        protected float _startPosY;
        //Ширина окна отрисовки
        protected int _pictureWidth;
        //Высота окна отрисовки
        protected int _pictureHeight;
        //Максимальная скорость 
        public int MaxSpeed { protected set; get; }
        //Вес лодки
        public float Weight { protected set; get; }
        //Основной цвет кузова
        public Color MainColor { protected set; get; }
        //
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void SetMainColor(Color color)
        {           
            MainColor = color;
        }

        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);

    }
}
