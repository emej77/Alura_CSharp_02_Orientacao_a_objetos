using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_Atividade_02
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }
        public static int QuantidadeDeConta = 0;

        public Conta ()
        {
            Conta.QuantidadeDeConta++;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            if ( (valor <= this.Saldo) && (valor > 0) )
            {
                this.Saldo -= valor;
            }
        }

        public static int ProximaConta()
        {
            return Conta.QuantidadeDeConta + 1;
        }

    }
}
