using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_OscarMancia.Formularios
{
    public partial class FrmPrestamo : Form
    {
        Clases.CoutaMensual re = new Clases.CoutaMensual();
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtPrest .Text .Trim ().Length == 0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtPrest.Focus();
                return;
            }
            if (TxtPlazo.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtPlazo.Focus();
                return;
            }
            if (TxtInter.Text.Trim().Length == 0)
            {
                MessageBox.Show("EL DATO ES REQUERIDO");
                TxtInter.Focus();
                return;
            }
            double prest, inter, plazo;
            prest = Convert.ToDouble(TxtPrest .Text .Trim ());
            inter = Convert.ToDouble(TxtInter .Text .Trim ());
            plazo = Convert.ToDouble(TxtPlazo .Text .Trim ());

            inter = inter / 100;
            plazo = plazo * 12;

            TxtCoutaM.Text = re.Cuota(prest , inter ,plazo ).ToString() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtInter.Clear();
            TxtPlazo.Clear();
            TxtPrest.Clear();
            TxtCoutaM.Clear();
            TxtPrest.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
