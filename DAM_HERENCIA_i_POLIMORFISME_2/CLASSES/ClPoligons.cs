using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CLASSES_HERENCIA_i_POLIMORFISME
{

        // Clase base o Superclasse (ClPoligons)
        public abstract class ClPoligons //Aqui creem el constructor abstract per
        {
            protected Form frmPare;                 // Form on es dibuixarà el polígon

            protected private Panel pnl=new Panel();  // panell dins el qual es dibuixa el polígon

            protected Color colorContorn;           // color de la vora
            protected float gruixContorn;           // gruix de la vora

            protected  Color colorInterior;         // color de l'interior

            public event EventHandler hanFetClic;

            // declarem un constructor genèric per a totes les subclasses que es derivin d'aquesta
            protected ClPoligons(Form xfrmPare, Color xcolorContorn, float xgruixContorn) //Si fos una classe sealed no es podria
            {   
                frmPare = xfrmPare;
                colorContorn = xcolorContorn;
                gruixContorn = xgruixContorn;

                pnl.MouseClick += new MouseEventHandler(clicAlPanel);
            }


        private void clicAlPanel(object sender, EventArgs e)
        {
            hanFetClic(this, e);
        }
            public abstract Double Area(); //Aixo es el mateix que declarar una funcio aqui pero ferla servir a un altre lloc? és una funcio que ha d'existir si o si en l'altre classe?                   // retorna l'àrea de la figura mesurada en pixels
            public abstract Double Perimetre();                 // retorna el perímetre de la figura mesurat en pixels

            public abstract void FerGran(int numeroEscalar);
    }
}
