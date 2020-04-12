using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new CuentaAhorro(100000);
           Console.WriteLine (cuenta.Retirar(200000));
            Console.WriteLine(cuenta.Consignar(200000));
            Console.WriteLine(cuenta.Consignar(50000));
            Console.WriteLine(cuenta.ConsultarSaldo());
            Console.ReadKey();

        }
    }
}
