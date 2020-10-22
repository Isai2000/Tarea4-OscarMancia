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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnSalario_Click(object sender, EventArgs e)
        {
            Formularios.FrmSalario dorico = new Formularios.FrmSalario();
            dorico.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmPrestamo jonico = new Formularios.FrmPrestamo();
            jonico.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmAumentoSal mixolidio = new Formularios.FrmAumentoSal();
            mixolidio.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FrmCompu eolico = new Formularios.FrmCompu();
            eolico.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmEmpleado frigio = new Formularios.FrmEmpleado();
            frigio.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
