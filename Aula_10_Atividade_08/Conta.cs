using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_Atividade_08
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if ( (valor <= this.Saldo) && (valor > 0) )
            {
                this.Saldo += valor;
            }
        }
    }
}
