using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cuenta
    {
        //Creación de Atributos Principales
        public int AccountNumber { get; set; }

        public string Headline { get; set; }

        public decimal Balance { get; set; }

        public double Interest { get; set; }

        public bool Ingreso()
        {
            return false;

        }
        public double InteresPorMes(Cuenta p)
        {
            var iTotal = p.Interest / 100 * Convert.ToDouble(p.Balance);
            return iTotal;

        }
        public void ConsultarSaldo(Cuenta account)
        {

            Console.WriteLine("Su saldo Actual es de  $" + account.Balance);
        }
        public Cuenta Tranferir(Cuenta d , double quantity)
        {
            d.Balance += Convert.ToDecimal(quantity);
            return d;


        }
    }
}
