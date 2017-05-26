using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Titular = new Cliente() { idade = 18 };
            cp.Deposita(1000.0);
            cp.Saca(100.0);
            MessageBox.Show("Saldo da conta poupança: " + cp.Saldo);

            Conta c = new Conta();
            c.Titular = new Cliente() { idade = 18 };
            c.Deposita(1000.0);
            c.Saca(100.0);
            MessageBox.Show("Saldo da conta: " + c.Saldo);
        }
    }
}
