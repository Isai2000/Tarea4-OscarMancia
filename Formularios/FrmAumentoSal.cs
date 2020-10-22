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
    public partial class FrmAumentoSal : Form
    {
        Clases.Aumento si = new Clases.Aumento();
        public FrmAumentoSal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNombre .Text .Trim ().Length == 0)
            {
                MessageBox.Show("ES REQUEDIRO LA INFORMACION");
                MessageBox.Show("FAVOR LLENAR LA INFORMACION");
                TxtNombre.Focus();
                return;
            }
            if (TxtSal.Text.Trim().Length == 0)
            {
                MessageBox.Show("ES REQUEDIRO LA INFORMACION");
                MessageBox.Show("FAVOR LLENAR LA INFORMACION");
                TxtSal.Focus();
                return;
            }
            if (TxtAumento.Text.Trim().Length == 0)
            {
                MessageBox.Show("ES REQUEDIRO LA INFORMACION");
                MessageBox.Show("FAVOR LLENAR LA INFORMACION");
                TxtAumento.Focus();
                return;
            }

            double salb, aum;
            string nombre;
            salb = Convert.ToDouble(TxtSal .Text .Trim ());
            aum = Convert.ToDouble(TxtAumento .Text .Trim ());
            nombre = TxtNombre.Text;

            aum = aum / 100;
            TxtResultado.Text = nombre +" Su nuevo salario es: " + si.subir(salb , aum ).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtAumento.Clear();
            TxtResultado.Clear();
            TxtSal.Clear();
            TxtNombre.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
