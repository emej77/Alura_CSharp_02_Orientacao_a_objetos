using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_Atividade_02
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public abstract void Saca(double valor);
        //Declarei como abstract, então não pode ter corpo
        /*
        {
            if ((valor <= this.Saldo) && (valor > 0))
            {
                this.Saldo -= valor;
            }
        }
        */

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
