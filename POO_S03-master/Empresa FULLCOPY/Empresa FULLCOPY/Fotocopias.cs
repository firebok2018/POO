using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_FULLCOPY
{
    class Fotocopias
    {

        public string cliente, descripcion;
        public int cantidad;
        public double tarifa;

        public Fotocopias()
        {
            tarifa = 0.10;
            cantidad = 0;

        }
        public virtual double monto()
        {
            return tarifa * cantidad;
        }
       
    }
}
