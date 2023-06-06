using CLASSES_HERENCIA_i_POLIMORFISME;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM_HERENCIA_i_POLIMORFISME_2.CLASSES
{
    public class ClRectangle : ClPoligons
    {
        private int height;
        private int width;
        private Point Centre;

        //Aquest es el constructor amb un color extern i intern
        public ClRectangle(Form xfrmPare, int xCentre, int yCentre, Color xcolorContorn, float xgruixContorn, Color xcolorInterior, int xheight, int xwidth) : base(xfrmPare, xcolorContorn, xgruixContorn)
        {
            height = xheight;
            width = xwidth;
            Centre = new Point(xCentre, yCentre);
            colorInterior = xcolorInterior; //Com que aquest constructor si que te un color, li donarem valor, si no no hauriem de donar valor

            mostrar();
        }

        public ClRectangle(Form xfrmPare2, int xCentre, int yCentre, Color xcolorContorn2, float xgruixContorn, int xheight, int xwidth) : base(xfrmPare2, xcolorContorn2, xgruixContorn)
        {
            height = xheight;
            width = xwidth;
            Centre = new Point(xCentre, yCentre);
            colorInterior = Color.Empty; //Com que aquest constructor si que un color, li donarem valor, si no no hauriem de donar valor

            mostrar();
        }

        private void mostrar()
        {
            int xSupEsq, ySupEsq;

            xSupEsq = (int)(Centre.X - (width / 2));
            ySupEsq = (int)(Centre.Y - (height / 2));

            pnl.Size = new Size(width, height);
            pnl.Location = new Point(xSupEsq, ySupEsq);
            pnl.Paint += new PaintEventHandler(ferRectangle);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void ferRectangle(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(colorContorn, gruixContorn);   // Pen per a traçar el contorn


            //e.Graphics.DrawRectangle(p, xSupEsq, ySupEsq, Mida, Mida); //Per que tenim aixo comentat?
            e.Graphics.DrawRectangle(p, 0, 0, width, height);
            if (colorInterior != Color.Empty)
            {
                e.Graphics.FillRectangle(new SolidBrush(colorInterior), gruixContorn + 1, gruixContorn + 1, width - 2 * gruixContorn - 2, height - 2 * gruixContorn - 2);
            }
        }

        public override Double Perimetre()
        {
            return (height * 2 + width * 2);
        }

        // retorna l'àrea de la figura mesurada en pixels
        public override Double Area()
        {
            return (height * width);
        }

        public override void FerGran(int escalar)
        {
            if (escalar > 0)
            {
                this.height = height * escalar;
                this.width = width * escalar;

                this.Centre.X = this.Centre.X - (width * (escalar / 10));
                this.Centre.Y = this.Centre.Y - (height * (escalar / 10));
                this.mostrar();
                this.pnl.Refresh();
            }
            else if (escalar < 0)
            {
                escalar = Math.Abs(escalar);
                this.height = height * escalar;
                this.width = width * escalar;
                this.Centre.X = this.Centre.X - (width * (escalar / 10));
                this.Centre.Y = this.Centre.Y - (height * (escalar / 10));
                this.mostrar();
                this.pnl.Refresh();
            }
        }
    }
}
