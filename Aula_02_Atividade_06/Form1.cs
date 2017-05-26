using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02_Atividade_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente umCliente = new Cliente("Teste");
            Cliente doisCliente = new Cliente() { idade = 1, endereco = "Rua Abc, 34" };
        }
    }
}
