using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aula_09_Atividade_02
{
    class ContaCorrente : Conta
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
                    this.Saldo -= valor;
                    return true;
                }
                else
                {
                    if (valor <= 200)
                    {
                        this.Saldo -= valor;
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