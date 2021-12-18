using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLocomotive
{
    public partial class FormLocomotive : Form
    {
        private ITransport locomotive;
        public FormLocomotive()
        {
            InitializeComponent();
        }

        public void SetLocomotive(ITransport locomotive) 
        {
            this.locomotive = locomotive;
            Draw();       
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
            Graphics gr = Graphics.FromImage(bmp);
            locomotive?.DrawTransport(gr);
            pictureBoxLocomotive.Image = bmp;          
        }

      

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    locomotive?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    locomotive?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    locomotive?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    locomotive?.MoveTransport(Direction.Right);
                    break;

            }
            Draw();
        }

       

       
    }
}
