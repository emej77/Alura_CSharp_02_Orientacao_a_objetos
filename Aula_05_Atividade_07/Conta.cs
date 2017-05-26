using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Atividade_07
{
    class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public virtual bool Saca(double valor)
        {
            if ((this.Saldo >= valor) && (valor > 0))
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.Saldo;

            return rendimento;
        }
    }
}
