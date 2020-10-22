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
    public partial class FrmSalario : Form
    {
        Clases.SalarioExNet fa = new Clases.SalarioExNet();
      
        public FrmSalario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el nombre del empleado");
                TxtNombre.Focus();
                return;
            }
            if (TxtSalarioB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el salario");
                TxtSalarioB.Focus();
                return;
            }
            if (TxtHrt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese las horas extra");
                TxtHrt.Focus();
                return;
            }
            if (TxtValorH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el valor de las horas");
                TxtValorH.Focus();
                return;
            }

            double salb, salex ,hrt, valor, deduc;
            string nombre;
            salb = Convert.ToDouble(TxtSalarioB .Text .Trim ());
            hrt = Convert.ToDouble(TxtHrt .Text .Trim ());
            valor = Convert.ToDouble(TxtValorH .Text .Trim ());
            nombre = TxtNombre.Text;

            deduc = 0.05;
            salex = fa .SalEx (hrt , valor);
            

            TxtRestNomb.Text = nombre;
            TxtCoop.Text = deduc.ToString();
            TxtSalx.Text = fa.SalEx(hrt , valor).ToString ();            
            TxtSalnt.Text = fa .Saln  (salb , salex , deduc ).ToString ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtSalarioB.Clear();
            TxtSalnt.Clear();
            TxtSalx.Clear();
            TxtValorH.Clear();
            TxtRestNomb.Clear();
            TxtHrt.Clear();
            TxtCoop.Clear();
            TxtNombre.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
