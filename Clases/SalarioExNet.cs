using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_OscarMancia.Clases
{
    class SalarioExNet
    {
        public double SalEx(double hrt, double valorh)
        {
            double salarioextra;
            
            salarioextra = hrt * valorh;

            return salarioextra;
        }

        public double Saln(double sb, double salex, double deduc)
        {
            double Salarioneto;

            Salarioneto = ((sb + salex) - ( deduc * (sb + salex)));
     
            return Salarioneto;
        }

    }
}
