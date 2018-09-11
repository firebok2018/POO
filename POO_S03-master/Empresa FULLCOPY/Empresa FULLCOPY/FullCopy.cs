using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_FULLCOPY
{
    class FullCopy : Fotocopias
    {
        public string tipo;
        public override double monto()
        {
            if (tipo == "A4")
                tarifa = 0.08;
            else if (tipo == "A3")
                tarifa = 0.15;
            else
                tarifa = 0.10;
            return tarifa * cantidad;
        }
    }
}
