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
    public class ClCercle: ClPoligons
    {

        private int Mida;
        private Point Centre;

        public ClCercle(Form xfrmPare2, int xCentre, int yCentre, Color xcolorContorn2, float xgruixContorn, int xmida) : base(xfrmPare2, xcolorContorn2, xgruixContorn)
        {
            Mida = xmida;
            Centre = new Point(xCentre, yCentre);
            colorInterior = Color.Empty;               // Empty és un color que equival a null

            mostrar();
        }

        // constructor per a un quadrat amb interior (2on constructor - sobrecàrrega)
        public ClCercle(Form xfrmPare, int xCentre, int yCentre, Color xcolorContorn, float xgruixContorn, Color xcolorInterior, int xmida) : base(xfrmPare, xcolorContorn, xgruixContorn)
        {
            this.Mida = xmida;
            this.Centre = new Point(xCentre, yCentre);
            this.colorInterior = xcolorInterior;               // Empty és un color que equival a null

            mostrar();
        }

        private void mostrar()
        {
            int xSupEsq, ySupEsq;                               // (x,y) del vèrtex superior esquerre

            xSupEsq = (int)(Centre.X - (Mida / 2));
            ySupEsq = (int)(Centre.Y - (Mida / 2));

            pnl.Size = new Size(Mida, Mida);
            pnl.Location = new Point(xSupEsq, ySupEsq);
            pnl.Paint += new PaintEventHandler(ferCercle);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        private void ferCercle(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(colorContorn, gruixContorn);   // Pen per a traçar el contorn

            Graphics g = e.Graphics;

            Rectangle forma = new Rectangle(0, 0, Mida-2, Mida-2);

            //e.Graphics.DrawRectangle(p, xSupEsq, ySupEsq, Mida, Mida);
            //e.Graphics.DrawRectangle(p, 0, 0, Mida, Mida);

            g.DrawEllipse(p, forma);

            if (colorInterior != Color.Empty)
            {
                e.Graphics.FillEllipse(new SolidBrush(colorInterior), gruixContorn + 1, gruixContorn + 1, Mida - 2 * gruixContorn - 2, Mida - 2 * gruixContorn - 2);
            }
        }

        public override Double Perimetre()
        {
            return ((Mida/2)*(Mida/2) * 3.1451);
        }

        // retorna l'àrea de la figura mesurada en pixels
        public override Double Area()
        {
            return ((Mida / 2) * (Mida / 2) * 3.1451);
        }

        public override void FerGran(int escalar)
        {
            if (escalar > 0)
            {
                this.Mida = Mida * escalar;

                this.Centre.X = this.Centre.X - (Mida * (escalar / 10));
                this.Centre.Y = this.Centre.Y - (Mida * (escalar / 10));
                this.mostrar();
                this.pnl.Refresh();
            }
            else if (escalar < 0)
            {
                escalar = Math.Abs(escalar);
                this.Mida = Mida / escalar;
                this.Centre.X = this.Centre.X - (Mida * (escalar / 10));
                this.Centre.Y = this.Centre.Y - (Mida * (escalar / 10));
                this.mostrar();
                this.pnl.Refresh();
            }
        }
    }
}
