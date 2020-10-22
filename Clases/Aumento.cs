using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_OscarMancia.Clases
{
    class Aumento
    {
        public double subir(double salb, double aumnt)
        {
            double subir;

            subir = (salb * aumnt) + salb;

            return subir;
        }
    }
}
