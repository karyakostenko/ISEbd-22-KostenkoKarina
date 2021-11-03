using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCars
{
	/// <summary>
	/// Класс отрисовки гоночного автомобиля
	/// </summary>
	public class SportCar : Car
	{
		/// <summary>
		/// Дополнительный цвет
		/// </summary>
		public Color DopColor { private set; get; }
		/// <summary>
		/// Признак наличия переднего спойлера
		/// </summary>
		public bool FrontSpoiler { private set; get; }
		/// <summary>
		/// Признак наличия боковых спойлеров
		/// </summary>
		public bool SideSpoiler { private set; get; }
		/// <summary>
		/// Признак наличия заднего спойлера
		/// </summary>
		public bool roga { private set; get; }
		/// <summary>
		/// Признак наличия гоночной полосы
		/// </summary>
		public bool akum { private set; get; }
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="dopColor">Дополнительный цвет</param>
		/// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
		/// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
		/// <param name="roga">Признак наличия заднего спойлера</param>
		/// <param name="sportLine">Признак наличия гоночной полосы</param>
		public SportCar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontSpoiler, bool sideSpoiler, bool Roga, bool Akum) :
		base(maxSpeed, weight, mainColor, 100, 60)
		{
			DopColor = dopColor;
			FrontSpoiler = frontSpoiler;
			SideSpoiler = sideSpoiler;
		    roga = Roga;
			akum = Akum;
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










            // рисуем гоночные полоски
            if (roga)
            {

                Pen pen1 = new Pen(Color.Red, 5);
                Point p1 = new Point((int)_startPosX + 50, (int)_startPosY);
                Point p2 = new Point((int)_startPosX + 10, (int)_startPosY - 30);
                g.DrawLine(pen1, p1, p2);

                Point p11 = new Point((int)_startPosX + 50, (int)_startPosY - 60);
                Point p12 = new Point((int)_startPosX + 10, (int)_startPosY - 30);
                g.DrawLine(pen1, p11, p12);

                Point p21 = new Point((int)_startPosX + 50, (int)_startPosY - 60);
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

                g.FillRectangle(brGray, _startPosX + 130, _startPosY - 30, 160, 30);

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
