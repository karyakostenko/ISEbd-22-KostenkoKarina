using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive

{
    public class Electrovoz
    {
        
      
        private float _startPosX;
       
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
       
         
        private readonly int locomotiveWidth = 450;
        
        private readonly int locomotiveHeight = 150;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
      
        public bool akum { private set; get; }
        /// <summary>
        /// Признак наличия гоночной полосы
        /// </summary>
        public bool roga { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
       
        public Electrovoz(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool Akum, bool Roga)
        {
            MaxSpeed = maxSpeed;
        
        Weight = weight;
        MainColor = mainColor;
        DopColor = dopColor;
        akum = Akum;
        roga = Roga;
         }
   
    /// <param name="x">Координата X</param>
    /// <param name="y">Координата Y</param>
    /// <param name="width">Ширина картинки</param>
    /// <param name="height">Высота картинки</param>
    public void SetPosition(int x, int y, int width, int height)
    {
            // Продумать логику
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
    }
    /// <summary>
    /// Изменение направления пермещения
    /// </summary>
    /// <param name="direction">Направление</param>
    public void MoveTransport(Direction direction)
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
                    if (_startPosX - step  >0)
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
       
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            

            // вагон
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 1, 400, 100);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 1, 400, 75);
            g.DrawRectangle(pen, _startPosX + 130, _startPosY +100, 160, 30);

            g.DrawRectangle(pen, _startPosX + 20, _startPosY +5, 50, 50);
            g.DrawRectangle(pen, _startPosX + 350, _startPosY +5, 50, 50);

            g.DrawRectangle(pen, _startPosX -20, _startPosY +80, 30, 15);
            g.DrawRectangle(pen, _startPosX +410, _startPosY + 80, 30, 15);

            Brush brGray = new SolidBrush(Color.Gray);
            g.FillRectangle(brGray, _startPosX + 10, _startPosY - 1, 400, 100);
            g.FillRectangle(brGray, _startPosX + 130, _startPosY + 100, 160, 30);
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 10, _startPosY - 1, 400, 75);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 20, _startPosY +5, 50, 50);
            g.FillRectangle(brBlue, _startPosX + 350, _startPosY + 5, 50, 50);
            //колеса
            g.DrawEllipse(pen, _startPosX+10, _startPosY + 100, 40, 40);
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







          


           
             if (roga)
             {
                
                Pen pen1 = new Pen(Color.Red,5);
                Point p1 = new Point((int)_startPosX+50, (int)_startPosY);
                Point p2 = new Point((int)_startPosX+10, (int)_startPosY-30);
                g.DrawLine(pen1, p1, p2);

                Point p11 = new Point((int)_startPosX + 50, (int)_startPosY-60);
                Point p12 = new Point((int)_startPosX + 10, (int)_startPosY - 30);
                g.DrawLine(pen1, p11, p12);

                Point p21 = new Point((int)_startPosX + 50, (int)_startPosY-60);
                Point p22 = new Point((int)_startPosX + 90, (int)_startPosY - 30);
                g.DrawLine(pen1, p21, p22);

                Point p31 = new Point((int)_startPosX + 50, (int)_startPosY);
                Point p32 = new Point((int)_startPosX + 90, (int)_startPosY - 30);
                g.DrawLine(pen1, p31, p32);


                
                Point p41 = new Point((int)_startPosX + 370, (int)_startPosY);
                Point p42 = new Point((int)_startPosX + 330, (int)_startPosY - 30);
                g.DrawLine(pen1, p41, p42);

                Point p51 = new Point((int)_startPosX + 370, (int)_startPosY - 60);
                Point p52 = new Point((int)_startPosX + 330, (int)_startPosY - 30);
                g.DrawLine(pen1, p51, p52);

                Point p61 = new Point((int)_startPosX + 370, (int)_startPosY - 60);
                Point p62 = new Point((int)_startPosX + 410, (int)_startPosY - 30);
                g.DrawLine(pen1, p61, p62);

                Point p71 = new Point((int)_startPosX + 370, (int)_startPosY);
                Point p72 = new Point((int)_startPosX + 410, (int)_startPosY - 30);
                g.DrawLine(pen1, p71, p72);
            }
             

             if (akum)
             {
                
                g.FillRectangle(brGray, _startPosX + 130, _startPosY -30, 160, 30);

                g.FillRectangle(brBlack, _startPosX + 150, _startPosY - 20, 50, 15);
                g.FillRectangle(brBlack, _startPosX + 220, _startPosY - 20, 50, 15);

                Brush brLGray = new SolidBrush(Color.LightGray);
                g.FillRectangle(brLGray, _startPosX + 130, _startPosY - 40, 10, 10);
                g.FillRectangle(brLGray, _startPosX + 160, _startPosY - 40, 10, 10);
                g.FillRectangle(brLGray, _startPosX + 190, _startPosY - 40, 10, 10);
                g.FillRectangle(brLGray, _startPosX + 220, _startPosY - 40, 10, 10);
                g.FillRectangle(brLGray, _startPosX + 250, _startPosY - 40, 10, 10);
                g.FillRectangle(brLGray, _startPosX + 280, _startPosY - 40, 10, 10);
                
            }
             

        }








    }
}
