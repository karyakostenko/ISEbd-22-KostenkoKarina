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

        public Color DopColor { private set; get; }

        public bool roga { private set; get; }

        public bool akum { private set; get; }

        public Electrovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool roga, bool akum) : base(maxSpeed, weight, mainColor, 100, 60) 
        {

            DopColor = dopColor;
            this.roga = roga;
            this.akum = akum;
        
        }

        public Electrovoz(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                roga = Convert.ToBoolean(strs[4]);
                akum = Convert.ToBoolean(strs[5]);
            }
        }

		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			Brush dopBrush = new SolidBrush(DopColor);
			Brush brBlack = new SolidBrush(Color.Black);
		
			base.DrawTransport(g);
			
			if (akum)
			{
				Brush dopcolor = new SolidBrush(DopColor);
				g.FillRectangle(dopcolor, _startPosX + 130, _startPosY - 30, 160, 30);

				g.FillRectangle(brBlack, _startPosX + 150, _startPosY - 20, 50, 15);
				g.FillRectangle(brBlack, _startPosX + 220, _startPosY - 20, 50, 15);


				g.FillRectangle(dopcolor, _startPosX + 130, _startPosY - 40, 10, 10);
				g.FillRectangle(dopcolor, _startPosX + 160, _startPosY - 40, 10, 10);
				g.FillRectangle(dopcolor, _startPosX + 190, _startPosY - 40, 10, 10);
				g.FillRectangle(dopcolor, _startPosX + 220, _startPosY - 40, 10, 10);
				g.FillRectangle(dopcolor, _startPosX + 250, _startPosY - 40, 10, 10);
				g.FillRectangle(dopcolor, _startPosX + 280, _startPosY - 40, 10, 10);
			}
			
			if (roga)
			{
				Pen pen1 = new Pen(DopColor, 5);
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
		}

		public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{roga}{separator}{akum}";
        }
    }
}
