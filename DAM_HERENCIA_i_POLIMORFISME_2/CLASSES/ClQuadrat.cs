using System;

using System.Drawing;
using System.Windows.Forms;

namespace CLASSES_HERENCIA_i_POLIMORFISME
{
    public class ClQuadrat : ClPoligons                 // ClPoligons és la superclasse de la que es deriva ClQuadrat
    {
        private int Mida;
        private Point Centre;                           // posició del centre del quadrat

        // constructor per a un quadrat sense interior 
        // : base(.....) ve determinat per l'herència del constructor genèric de la superclasse ClPoligons
        public ClQuadrat(Form xfrmPare2, int xCentre, int yCentre, Color xcolorContorn2, float xgruixContorn, int xmida) : base(xfrmPare2, xcolorContorn2, xgruixContorn)     
        {
            Mida = xmida;
            Centre = new Point(xCentre, yCentre);
            colorInterior = Color.Empty;               // Empty és un color que equival a null
            
            mostrar();
        }


        // constructor per a un quadrat amb interior (2on constructor - sobrecàrrega)
        public ClQuadrat(Form xfrmPare, int xCentre, int yCentre, Color xcolorContorn, float xgruixContorn, Color xcolorInterior, int xmida) : base(xfrmPare, xcolorContorn, xgruixContorn)
        {
            this.Mida = xmida;
            this.Centre = new Point(xCentre, yCentre);
            this.colorInterior = xcolorInterior;               // Empty és un color que equival a null

            mostrar();
        }

        // mostrar el quadrat
        private void mostrar()               
        {
            int xSupEsq, ySupEsq;                               // (x,y) del vèrtex superior esquerre

            xSupEsq = (int)(Centre.X - (Mida / 2));
            ySupEsq = (int)(Centre.Y - (Mida / 2));

            pnl.Size = new Size(Mida, Mida);
            pnl.Location = new Point(xSupEsq, ySupEsq);
            pnl.Paint += new PaintEventHandler(ferQuadrat);
            frmPare.Controls.Add(pnl);
            pnl.BringToFront();
        }

        // dibuix el quadrat dins el Panel
        private void ferQuadrat(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(colorContorn, gruixContorn);   // Pen per a traçar el contorn


            //e.Graphics.DrawRectangle(p, xSupEsq, ySupEsq, Mida, Mida);
            e.Graphics.DrawRectangle(p, 0, 0, Mida, Mida);
            if (colorInterior != Color.Empty)
            {
                e.Graphics.FillRectangle(new SolidBrush(colorInterior), gruixContorn + 1, gruixContorn + 1, Mida - 2 * gruixContorn - 2, Mida - 2 * gruixContorn - 2);
            }


        }

        // retorna el perímetre de la figura mesurat en pixels
        // utilitzem la clàusula override (polimorfisme)
        public override Double Perimetre()
        {
            return (Mida*4);
        }

        // retorna l'àrea de la figura mesurada en pixels
        public override Double Area()
        {
            return (Mida*Mida);
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
