using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta[] contas = new Conta[2];
            contas[0] = new Conta();
            contas[1] = new ContaPoupanca();

            contas[0].Deposita(1000);
            contas[1].Deposita(3000);

            for (int i = 0; i < contas.Length; i++)
            {
                MessageBox.Show("O saldo da conta é de: " + contas[i].Saldo);
            }

            //ou desta outra maneira

            foreach (Conta conta in contas)
            {
                MessageBox.Show("O saldo da conta é de: " + conta.Saldo);
            }
        }
    }
}
