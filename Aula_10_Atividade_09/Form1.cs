using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_10_Atividade_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp1 = new ContaPoupanca();
            cp1.Depositar(100);

            ContaPoupanca cp2 = new ContaPoupanca();
            cp2.Depositar(200);

            SeguroDeVida sdv1 = new SeguroDeVida();

            Conta c = new ContaPoupanca();

            GerenciadorDeImposto gdi = new GerenciadorDeImposto();
            gdi.Adiciona(cp1);
            gdi.Adiciona(cp2);
            gdi.Adiciona(sdv1);
            //gdi.Adiciona(c);

            MessageBox.Show("Total de imposto: " + gdi.Total);
        }
    }
}
