﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01_Atividade_07
{
    class Cliente
    {
        public string cpf;
        public string nome;
        public string endereco;
        public int idade;

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;

            //ou desta maneira
            /*
            if (this.idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }
    }
}