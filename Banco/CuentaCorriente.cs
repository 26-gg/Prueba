using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaCorriente:Cuenta
    {
        public CuentaCorriente(decimal valor):base(valor)
        {

        }

        public override string Consignar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override string Retirar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
