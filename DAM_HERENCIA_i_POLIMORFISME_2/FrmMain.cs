using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CLASSES_HERENCIA_i_POLIMORFISME;
using DAM_HERENCIA_i_POLIMORFISME_2.CLASSES;

namespace DAM_HERENCIA_i_POLIMORFISME_2
{
    public partial class FrmMain : Form
    {

        List<ClPoligons> llistaPoligons = new List<ClPoligons>();
        List<ClQuadrat> llistaQuadrats = new List<ClQuadrat>();
        List<ClCercle> llistaCercles = new List<ClCercle>();
        List<ClRectangle> llistaRectangles = new List<ClRectangle>();
        List<ClTriangle> llistaTriangles = new List<ClTriangle>();
        List<ClRombe> llistaRombes = new List<ClRombe>();


        public FrmMain()
        {
            InitializeComponent();
        }

        // càrrega del Form    
        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlConfig.Height = this.Height;
            lbEstat.Top = this.Height - lbEstat.Height - 100;
            lbArea.Top = this.Height - lbEstat.Height - 100;
        }

        // doble click sobre el Form
        private void FrmMain_DoubleClick(object sender, EventArgs e)
        {
            if (rdQuadrat.Checked)
            {
                dibuixarQuadrat();
            }
            if (rdRectangle.Checked)
            {
                dibuixarRectangle();
            }
            if (rdCercle.Checked)
            {
                dibuixarCercle();
            }
            if (rdTriangle.Checked)
            {
                dibuixarTriangle();
            }
            if (rdRombe.Checked)
            {
                dibuixarRombe();
            }
        }

        

        // selecció del color de la vora
        private void pnlColorVora_Click(object sender, EventArgs e)
        {
            ColorDialog dc = new ColorDialog();

            dc.Color = pnlColorVora.BackColor;
            if (dc.ShowDialog() == DialogResult.OK)
            {
                pnlColorVora.BackColor = dc.Color;
            }
        }

        // selecció del color interior si el checkbox està activat
        private void pnlColorInterior_Click(object sender, EventArgs e)
        {
            ColorDialog dc = new ColorDialog();

            dc.Color = pnlColorInterior.BackColor;
            if (dc.ShowDialog() == DialogResult.OK)
            {
                pnlColorInterior.BackColor = dc.Color;
            }
        }

        // canvi del checkbox
        private void chkInterior_CheckedChanged(object sender, EventArgs e)
        {
            pnlColorInterior.Visible = chkInterior.Checked;
        }

        // selecció de quadrat
        private void rdQuadrat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdQuadrat.Checked)
            {
                lbAmple.Text = "Mida";
                lbAltura.Visible = false;
                altura.Visible = false;
            }
        }

        private void rdRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRectangle.Checked)
            {
                lbAmple.Text = "Ample";
                lbAltura.Text = "Altura";
                lbAltura.Visible = true;
                altura.Visible = true;
            }
        }

        private void rdCercle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCercle.Checked)
            {
                lbAmple.Text = "Mida";
                lbAltura.Visible = false;
                altura.Visible = false;
            }
        }

        private void rdTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTriangle.Checked)
            {
                lbAmple.Text = "Ample";
                lbAltura.Text = "Altura";
                lbAltura.Visible = true;
                altura.Visible = true;
            }
        }

        private void rdRombe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRombe.Checked)
            {
                lbAmple.Text = "Ample";
                lbAltura.Text = "Altura";
                lbAltura.Visible = true;
                altura.Visible = true;
            }
        }

        //dibuixem un quadrat
        private void dibuixarQuadrat()
        {
            ClQuadrat q;

             if (chkInterior.Checked)
            {
                // a la coordenada Y cal restar-li l'alçada de la barra de títol
                q = new ClQuadrat(this, MousePosition.X, MousePosition.Y-SystemInformation.CaptionHeight , pnlColorVora.BackColor, (float)gruixVora.Value, pnlColorInterior.BackColor, (int)ample.Value);
            }
            else
            {
                // a la coordenada Y cal restar-li l'alçada de la barra de títol
                q = new ClQuadrat(this, MousePosition.X, MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, (int)ample.Value);
            }
            q.hanFetClic += new EventHandler(mostrarArea);
            llistaPoligons.Add(q);
            llistaQuadrats.Add(q);
        }

        private void dibuixarRectangle()
        {
            ClRectangle r;
            if (chkInterior.Checked)
            {
                //Aqui entrara si hem clicat la part de fer l'interior
                r = new ClRectangle(this, MousePosition.X, MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, pnlColorInterior.BackColor, (int)altura.Value, (int)ample.Value);
            }
            else
            {
                //Aqui entrara si no hem posat un fons de color
                r = new ClRectangle(this, MousePosition.X , MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, (int)altura.Value, (int)ample.Value);
            }
            r.hanFetClic += new EventHandler(mostrarArea);
            llistaPoligons.Add(r);
            llistaRectangles.Add(r);
        }

        private void dibuixarCercle()
        {
            ClCercle c;

            if (chkInterior.Checked)
            {
                // a la coordenada Y cal restar-li l'alçada de la barra de títol
                c = new ClCercle(this, MousePosition.X, MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, pnlColorInterior.BackColor, (int)ample.Value);
            }
            else
            {
                // a la coordenada Y cal restar-li l'alçada de la barra de títol
                c = new ClCercle(this, MousePosition.X, MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, (int)ample.Value);
            }
            c.hanFetClic += new EventHandler(mostrarArea);
            llistaPoligons.Add(c);
            llistaCercles.Add(c);
        }

        private void dibuixarTriangle()
        {
            ClTriangle t;

            if (chkInterior.Checked)
            {
                // a la coordenada Y cal restar-li l'alçada de la barra de títol
                t = new ClTriangle(this, MousePosition.X, MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, pnlColorInterior.BackColor, (int)altura.Value, (int)ample.Value);
            }
            else
            {
                // a la coordenada Y cal restar-li l'alçada de la barra de títol
                t = new ClTriangle(this, MousePosition.X, MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, (int)altura.Value, (int)ample.Value);
            }
            t.hanFetClic += new EventHandler(mostrarArea);
            llistaPoligons.Add(t);
            llistaTriangles.Add(t);
        }

        private void dibuixarRombe()
        {
            ClRombe r;

            if (chkInterior.Checked)
            {
                // a la coordenada Y cal restar-li l'alçada de la barra de títol
                r = new ClRombe(this, MousePosition.X, MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, pnlColorInterior.BackColor, (int)altura.Value, (int)ample.Value);
            }
            else
            {
                // a la coordenada Y cal restar-li l'alçada de la barra de títol
                r = new ClRombe(this, MousePosition.X, MousePosition.Y - SystemInformation.CaptionHeight, pnlColorVora.BackColor, (float)gruixVora.Value, (int)altura.Value, (int)ample.Value);
            }
            r.hanFetClic += new EventHandler(mostrarArea);
            llistaPoligons.Add(r);
            llistaRombes.Add(r);
        }

        private void mostrarArea(object sender, EventArgs e)
        {
            lbArea.Text = (((ClPoligons)sender).Area().ToString());
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            if (cbEscalarTots.Checked)
            {
                escalartoteslesfigures();
            }
            else
            {
                if (rdQuadrat.Checked)
                {
                    escalarQuadrats();
                }
                if (rdRectangle.Checked)
                {
                    escalarRectangles();
                }
                if (rdCercle.Checked)
                {
                    escalarCercles();
                }
                if (rdTriangle.Checked)
                {
                    escalarTriangles();
                }
                if (rdRombe.Checked)
                {
                    escalarRombes();
                }
            }
        }

        

        private void escalartoteslesfigures()
        {
            foreach (ClPoligons pnl in llistaPoligons)
            {
                pnl.FerGran((int)nudNumeroEscalar.Value);
            }
        }
        private void escalarQuadrats()
        {
            foreach (ClQuadrat pnl in llistaQuadrats)
            {
                pnl.FerGran((int)nudNumeroEscalar.Value);
            }
        }

        private void escalarRectangles()
        {
            foreach (ClRectangle pnl in llistaRectangles)
            {
                pnl.FerGran((int)nudNumeroEscalar.Value);
            }
        }

        private void escalarCercles()
        {
            foreach (ClCercle pnl in llistaCercles)
            {
                pnl.FerGran((int)nudNumeroEscalar.Value);
            }
        }

        private void escalarTriangles()
        {
            foreach (ClTriangle pnl in llistaTriangles)
            {
                pnl.FerGran((int)nudNumeroEscalar.Value);
            }
        }

        private void escalarRombes()
        {
            foreach (ClRombe pnl in llistaRombes)
            {
                pnl.FerGran((int)nudNumeroEscalar.Value);
            }
        }
    }
}

