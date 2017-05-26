using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_Atividade_02
{
    class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
            if ((valor <= this.Saldo) && (valor > 0))
            {
                this.Saldo -= (valor * 0.01);
            }
        }
    }
}
