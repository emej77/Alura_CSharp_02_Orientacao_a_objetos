using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Atividade_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta() { Numero = 1 };
            Conta c2 = new Conta() { Numero = 2 };

            Banco b = new Banco();
            b.Adiciona(c1);
            b.Adiciona(c2);

            foreach (Conta conta in b.Contas)
            {
                if (conta != null)
                {
                    MessageBox.Show(conta.Numero.ToString());
                }
            }
        }
    }
}
