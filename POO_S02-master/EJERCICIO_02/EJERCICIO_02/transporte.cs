using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02
{
    class transporte
    {
        public string destino;
        public double tm;
        public double tarifa;


        public transporte()
        {
            tarifa = 150;

        }
        public double flete()
        {
            return tarifa * tm;
        }
    }
    
}
