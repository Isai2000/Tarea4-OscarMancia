using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Tarea4_OscarMancia.Clases
{
    class SalarioVendedor
    {
        public double Venta(double d1, double d2, double d3, double d4, double d5)
        {
            double Venta;

            Venta = d1 + d2 + d3 + d4 + d5 ;
            
           
            
            return Venta;
        }

        public double ventasum(double porcent, double sum)
        {
            double ventasum;
            ventasum = sum * porcent + sum;
            
            return ventasum;
        }
    }
}
