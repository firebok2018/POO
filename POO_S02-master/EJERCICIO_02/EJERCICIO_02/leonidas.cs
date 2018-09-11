using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02
{
    class leonidas : transporte
    {
        public double tarifario()
        {
            if (destino == "Arequipa" || destino == "Ica" || destino == "Tacna")
                tarifa = 200;
            else if (destino == "Piura" || destino == "Tumbes" || destino == "Cajamarca")
                tarifa = 220;
            else
                tarifa = 150;
            return tarifa;
        }
        public double seguro()
        {
            return 0.05 * flete();
        }
        public double monto()
        {
            return flete() + seguro();
        }
    }
}
