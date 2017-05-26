using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Atividade_08
{
    class ContaPoupanca : Conta
    {
        public override bool Saca(double valor)
        {
            if ((valor > this.Saldo) && (valor <= 0))
            {
                return false;
            }
            else
            {
                if (this.Titular.EhMaiorDeIdade())
                {
                    this.Saldo -= valor + 0.1;
                    return true;
                }
                else
                {
                    if (valor <= 200)
                    {
                        this.Saldo -= valor + 0.1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor - 0.1;
        }
    }
}
