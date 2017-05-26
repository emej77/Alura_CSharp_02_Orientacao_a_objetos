using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_Atividade_02
{
    class ContaPoupanca : Conta
    {
        public static int QuantidadeDeContaPoupanca = 0;

        public ContaPoupanca()
        {
            ContaPoupanca.QuantidadeDeContaPoupanca++;
        }

        public static int ProximaContaPoupanca()
        {
            return ContaPoupanca.QuantidadeDeContaPoupanca + 1;
        }
    }
}
