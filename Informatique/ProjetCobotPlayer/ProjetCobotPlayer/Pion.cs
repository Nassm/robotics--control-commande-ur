using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjetCobotPlayer
{
    class Pion : UserControl
    {

        public bool? side;
        public bool isHovered;

        public Pion()
        {
            
            this.MouseEnter += Pion_MouseEnter;
            this.MouseLeave += Pion_MouseLeave;
            this.Paint += Pion_Paint;
            this.Size = new Size(100, 100);
        }

        private void Pion_MouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            //Debug.WriteLine("DEBUG : MouseEnter event triggered.");
            Invalidate();
        }

        private void Pion_MouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            //Debug.WriteLine("DEBUG : MouseLeave event triggered.");
            Invalidate();
        }

        private void Pion_Paint(object sender, PaintEventArgs e)
        {
            if (side == null)
            {
                e.Graphics.FillEllipse(isHovered ? Brushes.Orange : Brushes.Blue, 0, 0, 100, 100);

            }
            else if (side == true)
            {
                e.Graphics.FillEllipse(Brushes.White, 0, 0, 100, 100);
            }
            else
            {
                e.Graphics.FillEllipse(Brushes.Black, 0, 0, 100, 100);
            }
                        
        }

    }
}
