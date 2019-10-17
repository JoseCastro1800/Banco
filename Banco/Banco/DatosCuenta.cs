using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class DatosCuenta
    {
        public List<CuentaPension> Pensiones()
        {
            List<CuentaPension> pensions = new List<CuentaPension>();
            pensions.Add(new CuentaPension { AccountNumber = 12345, Balance = 12.35M, Expiration = Convert.ToDateTime("11/05/2021"), Headline = "Einar Perez", Interest = 2.21, NAccountPrincipal = 12322, Quotation = 25 });
            pensions.Add(new CuentaPension { AccountNumber = 12347, Balance = 12.35M, Expiration = Convert.ToDateTime("14/03/2020"), Headline = "Goku", Interest = 2.21, NAccountPrincipal = 12323, Quotation = 25 });
            pensions.Add(new CuentaPension { AccountNumber = 12348, Balance = 12.35M, Expiration = Convert.ToDateTime("13/06/2023"), Headline = "Gohan", Interest = 2.21, NAccountPrincipal = 12321, Quotation = 25 });
            pensions.Add(new CuentaPension { AccountNumber = 12340, Balance = 12.35M, Expiration = Convert.ToDateTime("13/02/2020"), Headline = "Piccolo", Interest = 2.21, NAccountPrincipal = 12365, Quotation = 25 });
            pensions.Add(new CuentaPension { AccountNumber = 12349, Balance = 12.35M, Expiration = Convert.ToDateTime("15/08/2022"), Headline = "Bardock", Interest = 2.21, NAccountPrincipal = 14322, Quotation = 25 });
            return pensions;

        }
        public List<CuentaAhorro> Saves()
        {
            List<CuentaAhorro> saves = new List<CuentaAhorro>();
            saves.Add(new CuentaAhorro { Headline = "Maria", Interest = 10, AccountNumber = 111, Balance = 1000, Expiration = Convert.ToDateTime("31/octubre/2020") });
            saves.Add(new CuentaAhorro { Headline = "Juan", Interest = 20, AccountNumber = 122, Balance = 2000, Expiration = Convert.ToDateTime("25/mayo/2020") });
            saves.Add(new CuentaAhorro { Headline = "Ana", Interest = 30, AccountNumber = 133, Balance = 3000, Expiration = Convert.ToDateTime("12/junio/2020") });
            saves.Add(new CuentaAhorro { Headline = "Sam", Interest = 40, AccountNumber = 144, Balance = 4000, Expiration = Convert.ToDateTime("31/diciembre/2020") });
            saves.Add(new CuentaAhorro { Headline = "joe", Interest = 50, AccountNumber = 155, Balance = 5000, Expiration = Convert.ToDateTime("10/noviembre/2020") });
            return saves;

        }
        public List<CuentaCurrente> Currents()
        {

            List<CuentaCurrente> currents = new List<CuentaCurrente>();
            currents.Add(new CuentaCurrente { Headline = "Mariana", Interest = 10, AccountNumber = 111, Balance = 1000 });
            currents.Add(new CuentaCurrente { Headline = "Martha", Interest = 20, AccountNumber = 122, Balance = 2000 });
            currents.Add(new CuentaCurrente { Headline = "Hannia", Interest = 30, AccountNumber = 133, Balance = 3000 });
            currents.Add(new CuentaCurrente { Headline = "Doom", Interest = 40, AccountNumber = 144, Balance = 4000 });
            currents.Add(new CuentaCurrente { Headline = "Pedro", Interest = 50, AccountNumber = 155, Balance = 5000 });

            return currents;

        }
    }
}
