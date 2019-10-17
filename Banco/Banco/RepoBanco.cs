using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class RepoBanco
    {
        DatosCuenta ad;
        public RepoBanco()
        {
            ad = new DatosCuenta();
        }
        internal void Principal()
        {
            Console.WriteLine("Bienvenidos A el Banco mi Casita");
            Menu();
            Console.ReadLine();
        }

        private void Menu()
        {
            Console.WriteLine("Ingrese a la Opcion Correcta");
            Console.WriteLine("1.- Cuenta Ahorro \n2.- Pensiones \n3.- Cuenta Corriente");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Bienvenido a Cuenta Ahorro");
                    GetDataSave();
                    break;
                case "2":
                    Console.WriteLine("Bienvenido a Pensiones");
                    GetDataPension();

                    break;

                case "3":
                    Console.WriteLine("Bienvenido a Cuenta Corriente");
                    GetDataCurrent();
                    break;

                default:
                    break;
            }
        }

        private void GetDataCurrent()
        {
            int number = GetData();
            var lista = ad.Currents();
            CuentaCurrente c = new CuentaCurrente();
            foreach (var cuenta in lista)
            {
                if (number == cuenta.AccountNumber)
                {
                    c = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }



        }



        private void GetDataPension()
        {
            int number = GetData();
            var lista = ad.Pensiones();
            CuentaPension p = new CuentaPension();

            foreach (var cuenta in lista)
            {
                if (number == cuenta.AccountNumber)
                {
                    p = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }

            Console.WriteLine("Bienvenido " + p.Headline);

            MenuUsuario(p);
        }

        private void MenuUsuario(Cuenta p)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu Cuenta :" + p.Headline);
            Console.WriteLine("1.- Consultar Saldo \n2.- Transferir \n3.- Interes x Mes 4.- Ingreso");
            Console.WriteLine("Elije una Opcion");

            switch (Console.ReadLine())
            {
                case "1":
                    p.ConsultarSaldo(p);
                    break;
                case "2":
                    p.Tranferir(d);

                    break;
                case "3":
                    Console.WriteLine("EL interes Generado es de : " + p.InteresPorMes(p));
                    break;
  

                default:
                    break;
            }

        }

        private void GetDataSave()
        {
            int number = GetData();
            var lista = ad.Saves();
            CuentaAhorro a = new CuentaAhorro();

            foreach (var cuenta in lista)
            {
                if (number == cuenta.AccountNumber)
                {
                    a = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }
        }

        private int GetData()
        {
            Console.WriteLine("Ingrese Su Numero de Cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }



    }
}
