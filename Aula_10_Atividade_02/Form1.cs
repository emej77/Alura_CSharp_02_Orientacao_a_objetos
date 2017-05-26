using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_10_Atividade_02
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
            cp.Deposita(100.0);

            ContaInvestimento ci = new ContaInvestimento();
            ci.Deposita(100.0);

            ContaCorrente cc = new ContaCorrente();
            cc.Deposita(100.0);

            TotalizadorDeTributos tt = new TotalizadorDeTributos();
            tt.Acumula(cp);
            tt.Acumula(ci);
            //A linha abaixo não compila, pois a classe não possui a interface e assim tbm não possui o método.
            //tt.Acumula(cc);

            MessageBox.Show("Total de tributos: " + tt.Total);
        }
    }
}
