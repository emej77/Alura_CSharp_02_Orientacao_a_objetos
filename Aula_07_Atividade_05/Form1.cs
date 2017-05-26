using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_07_Atividade_05
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[3];

            this.contas[0] = new Conta();
            this.contas[0].Agencia = 1;
            this.contas[0].Numero = 1111;
            this.contas[0].Deposita(111.11);
            this.contas[0].Titular = new Cliente();
            this.contas[0].Titular.nome = "Elias Mansur";
            this.contas[0].Titular.idade = 39;
            this.contas[0].Titular.endereco = "Rua José Ignácio, 546";

            this.contas[1] = new Conta();
            this.contas[1].Agencia = 2;
            this.contas[1].Numero = 2222;
            this.contas[1].Deposita(222.22);
            this.contas[1].Titular = new Cliente();
            this.contas[1].Titular.nome = "João da Silva";
            this.contas[1].Titular.idade = 25;
            this.contas[1].Titular.endereco = "Rua Tomaz de Abreu, 758";

            this.contas[2] = new Conta();
            this.contas[2].Agencia = 3;
            this.contas[2].Numero = 3333;
            this.contas[2].Deposita(333.33);
            this.contas[2].Titular = new Cliente();
            this.contas[2].Titular.nome = "Andréia Beltrão";
            this.contas[2].Titular.idade = 26;
            this.contas[2].Titular.endereco = "Rua Bela Cintra, 78";

            foreach (Conta conta in this.contas)
            {
                comboContas.Items.Add(conta.Titular.nome);
                comboContasTransferencia.Items.Add(conta.Titular.nome);
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoTitular.Text = contaSelecionada.Titular.nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];
            contaSelecionada.Deposita(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];
            contaSelecionada.Saca(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];

            int indiceSelecionadoTransf = comboContasTransferencia.SelectedIndex;
            Conta contaSelecionadaTransf = this.contas[indiceSelecionadoTransf];

            contaSelecionada.Transfere(Convert.ToDouble(textoValorTransferir.Text), contaSelecionadaTransf);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }
    }
}
