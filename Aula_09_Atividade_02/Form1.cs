using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_09_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Classes abstratas");

            // a classe conta está abstrata.
            // não pode criar um objeto por uma classe abstrata.
            //Conta c = new Conta();
            Conta c = new ContaCorrente();
        }
    }
}
