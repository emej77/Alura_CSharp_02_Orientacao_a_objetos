using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_01_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            umaConta.Agencia = 1;
            umaConta.Numero = 2345;
            umaConta.Titular = new Cliente();
            umaConta.Titular.cpf = "456789321-85";
            umaConta.Titular.nome = "José da Silva";
            umaConta.Titular.idade = 36;
            umaConta.Titular.endereco = "Alameda do Amor, 123";
            //umaConta.Saldo += 100.0; //não pode, pois a propriedade "set" está como "private"
            Console.WriteLine(umaConta.Saldo); //pode, pois a propriedade "get" está como "public"
        }
    }
}
