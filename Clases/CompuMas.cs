using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_OscarMancia.Clases
{
    class CompuMas
    {
        public double Couta(double venta, double precio)
        {
            double couta;

            couta = (venta * precio ) * 30/360;

            return couta;
        }
    }

}
