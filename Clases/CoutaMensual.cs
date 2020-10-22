using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_OscarMancia.Clases
{
    class CoutaMensual
    {
        public double Cuota(double prest, double inter, double plazo)
        {
            double couta;

            couta = (prest * inter + prest )/plazo;
            
            return couta;
        }
    }
}
