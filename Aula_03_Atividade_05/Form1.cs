using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03_Atividade_05
{
    public partial class Form1 : Form
    {

        private Conta umaConta;

        public Form1()
        {
            this.umaConta = new Conta()
            {
                Agencia = 1,
                Numero = 384756,
                Titular = new Cliente()
                {
                    cpf = "546879452-98",
                    endereco = "rua abc, 123",
                    idade = 19,
                    nome = "Victor"
                }
            };
            this.umaConta.Deposita(250.0);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(this.umaConta.Numero);
            textoTitular.Text = this.umaConta.Titular.nome;
            textoSaldo.Text = Convert.ToString(this.umaConta.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.umaConta.Deposita(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.umaConta.Saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.umaConta.Saca(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.umaConta.Saldo);
        }
    }
}
