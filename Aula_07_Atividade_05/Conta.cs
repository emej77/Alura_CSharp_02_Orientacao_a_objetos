using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aula_07_Atividade_05
{
    class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }

        public bool Saca(double valor)
        {
            if ((valor > this.Saldo) && (valor <= 0))
            {
                return false;
            }
            else
            {
                if (this.Titular.EhMaiorDeIdade())
                {
                    this.Saldo -= valor;
                    return true;
                }
                else
                {
                    if (valor <= 200)
                    {
                        this.Saldo -= valor;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
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