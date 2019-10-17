using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaPension:Cuenta
    {
        public DateTime Expiration { get; set; }
        public int Quotation { get; set; }
        public int NAccountPrincipal { get; set; }
    }
}
