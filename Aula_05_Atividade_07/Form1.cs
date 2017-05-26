using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_05_Atividade_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta()
            {
                Numero = 123,
                Agencia = 38475
            };
            c.Deposita(250.0);

            ContaCorrente cc = new ContaCorrente()
            {
                Numero = 965,
                Agencia = 96558
            };
            cc.Deposita(123.56);

            TotalizadorDeContas tdc = new TotalizadorDeContas();
            tdc.Adiciona(c);
            tdc.Adiciona(cc);

            MessageBox.Show("O total do saldo das contas é de " + tdc.SaldoTotal);
        }
    }
}
