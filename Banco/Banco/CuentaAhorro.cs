using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaAhorro:Cuenta
    {
        public DateTime Expiration { get; set; }

        public double Ingresopormes()
        {
            return 0;
        }
    }
}
