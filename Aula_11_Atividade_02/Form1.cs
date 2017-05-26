using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_11_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaCorrente cc = new ContaCorrente();
            MessageBox.Show("Quantidade atual CC: " + ContaCorrente.QuantidadeDeContaCorrente);
            MessageBox.Show("Próxima CC: " + ContaCorrente.ProximaContaCorrente());

            ContaPoupanca cp = new ContaPoupanca();
            MessageBox.Show("Quantidade atual CP: " + ContaPoupanca.QuantidadeDeContaPoupanca);
            MessageBox.Show("Próxima CP: " + ContaPoupanca.ProximaContaPoupanca());

            MessageBox.Show("Quantidade atual C: " + Conta.QuantidadeDeConta);
            MessageBox.Show("Próxima C: " + Conta.ProximaConta());
        }
    }
}
