using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_08_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var varBool = (1 == 1);

            MessageBox.Show(Convert.ToString(varBool));

            varBool = (1 == 2);

            MessageBox.Show(Convert.ToString(varBool));
        }
    }
}
