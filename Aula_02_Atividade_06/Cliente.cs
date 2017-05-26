using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_Atividade_06
{
    class Cliente
    {
        public string Cpf { get; private set; }
        public string Nome { get; private set; }
        public int idade;
        public string endereco;

        public Cliente ()
        {

        }

        public Cliente (string nome)
        {
            this.Nome = nome;
        }
    }
}
