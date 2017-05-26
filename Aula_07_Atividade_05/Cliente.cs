﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aula_07_Atividade_05
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