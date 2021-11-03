using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
	
	public class Electrovoz : Locomotive
	{
		/// <summary>
		/// Дополнительный цвет
		/// </summary>
		public Color DopColor { private set; get; }
		
		public bool roga { private set; get; }
		
		public bool akum { private set; get; }
	
		public Electrovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool Roga, bool Akum) :
		base(maxSpeed, weight, mainColor, 450, 150)
		{
			DopColor = dopColor;
		    roga = Roga;
			akum = Akum;
		}

		public override void DrawTransport(Graphics g)
		{
            Pen pen = new Pen(Color.Black);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlack = new SolidBrush(Color.Black);

            base.DrawTransport(g);
            



           
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
