using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_Atividade_02
{
    class ContaPoupanca : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            if ((valor <= this.Saldo) && (valor > 0))
            {
                this.Saldo -= (valor * 0.02);
            }
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
