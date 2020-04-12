using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
   public class CuentaAhorro :Cuenta
    {
        public CuentaAhorro(decimal saldo):base(saldo)
        {

        }

        public override string Consignar(decimal valor)
        {

                if (valor > 0)
                {
                    Saldo += valor;
                AgregarMovimientos("Consignacion",valor);
                    return $"Se consignó {valor} su nuevo saldo es {Saldo}";
                }

                return $"No es posible consignar valores menores a cero. Su saldo es {Saldo}";
        }

        public override string Retirar(decimal valor)
        {
            if (valor <= Saldo)
            {
               
                Saldo -= valor;
                AgregarMovimientos("Retiro", valor);
                return $"Se Retiró {valor} su nuevo saldo es {Saldo}";
            }

            return $"Saldo Insuficentes. Su saldo es {Saldo}";


        }
    }
}
