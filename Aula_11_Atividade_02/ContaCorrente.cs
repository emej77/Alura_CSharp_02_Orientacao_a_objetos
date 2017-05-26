using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_Atividade_02
{
    class ContaCorrente : Conta
    {
        public static int QuantidadeDeContaCorrente = 0;

        public ContaCorrente()
        {
            ContaCorrente.QuantidadeDeContaCorrente++;
        }

        public static int ProximaContaCorrente()
        {
            return ContaCorrente.QuantidadeDeContaCorrente + 1;
        }
    }
}
