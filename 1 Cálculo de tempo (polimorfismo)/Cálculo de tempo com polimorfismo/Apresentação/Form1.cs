using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_de_tempo_com_polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle(txbDistancia.Text, txbVelocidade.Text);

            if (controle.mensagem.Equals(""))
            {
                lblResposta.Text = controle.ToString();             
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
