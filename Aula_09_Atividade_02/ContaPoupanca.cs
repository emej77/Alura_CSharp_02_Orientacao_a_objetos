using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aula_09_Atividade_02
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
    }
}