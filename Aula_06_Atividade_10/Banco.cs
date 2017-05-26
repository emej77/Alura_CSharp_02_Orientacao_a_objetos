using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_Atividade_10
{
    class Banco
    {
        public Conta[] Contas = new Conta[10];

        private int quantidade;

        public void Adiciona (Conta conta)
        {
            this.Contas[this.quantidade] = conta;
            this.quantidade++;
        }
    }
}
