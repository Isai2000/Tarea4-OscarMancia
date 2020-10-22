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
    public partial class FrmEmpleado : Form
    {
        Clases.SalarioVendedor mi = new Clases.SalarioVendedor();
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtName .Text .Trim ().Length == 0)
            {
                MessageBox.Show("LA INFORMACION ES REQUERIDA");
                TxtName.Focus();
                return;
            }
            if (TxtDay1.Text.Trim().Length == 0)
            {
                MessageBox.Show("LA INFORMACION ES REQUERIDA");
                TxtDay1.Focus();
                return;
            }
            if (TxtDay2.Text.Trim().Length == 0)
            {
                MessageBox.Show("LA INFORMACION ES REQUERIDA");
                TxtDay2.Focus();
                return;
            }
            if (TxtDay3.Text.Trim().Length == 0)
            {
                MessageBox.Show("LA INFORMACION ES REQUERIDA");
                TxtDay3.Focus();
                return;
            }
            if (TxtDay4.Text.Trim().Length == 0)
            {
                MessageBox.Show("LA INFORMACION ES REQUERIDA");
                TxtDay4.Focus();
                return;
            }
            if (TxtDay5.Text.Trim().Length == 0)
            {
                MessageBox.Show("LA INFORMACION ES REQUERIDA");
                TxtDay5.Focus();
                return;
            }
            double d1, d2, d3, d4, d5, porcent, sum;
            string name;
            d1 = Convert.ToDouble(TxtDay1 .Text .Trim ());
            d2 = Convert.ToDouble(TxtDay2.Text.Trim());
            d3 = Convert.ToDouble(TxtDay3 .Text .Trim ());
            d4 = Convert.ToDouble(TxtDay4 .Text .Trim ());
            d5 = Convert.ToDouble(TxtDay5 .Text .Trim ());
            name = TxtName.Text;

            porcent = 0.05;
            sum = mi.Venta(d1, d2 , d3 ,d4 ,d5);

            
            TxtMostrar.Text = name + " Su salario es: " + mi.ventasum(porcent,sum).ToString ();

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtDay1.Clear();
            TxtDay2.Clear();
            TxtDay3.Clear();
            TxtDay4.Clear();
            TxtDay5.Clear();
            TxtMostrar.Clear();
            TxtName.Clear();
            TxtName.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
