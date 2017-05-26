using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_Atividade_08
{
    class ContaPoupanca : Conta, ITributavel
    {
        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
    }
}
