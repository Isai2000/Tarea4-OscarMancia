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
    public partial class FrmCompu : Form
    {
        Clases.CompuMas la = new Clases.CompuMas();
        public FrmCompu()
        {
            InitializeComponent();
        }

        private void FrmCompu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtVenta .Text .Trim ().Length == 0)
            {
                MessageBox.Show("FAVOR LLENAR LA INFORMACION");
                TxtVenta.Focus();
                return;
            }
            double venta, precio;
            venta = Convert.ToDouble(TxtVenta .Text .Trim ());

            precio = 0.35;

            TxtCuotaM.Text = la.Couta(venta , precio ).ToString ();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtVenta.Clear();
            TxtCuotaM.Clear();
            TxtVenta.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
