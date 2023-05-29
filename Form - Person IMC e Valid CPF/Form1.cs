using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form___Person_IMC_e_Valid_CPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_classificacao.Text = " ";
            lb_grau.Text = " ";
            lb_imc.Text = " ";
            lb_valida.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ValidarCPF.ValidaCPF(mask_cpf.Text) == false)
            {
                lb_valida.Text = "CPF inválido, insira outro novamente";
            }
            else
            {
                lb_valida.Text = "";
            }

            Pessoa p = new Pessoa(tx_nome.Text, mask_cpf.Text, tx_idade.Text, cb_sexo.Text, 
                Convert.ToDouble(num_peso.Text), Convert.ToDouble(mask_altura.Text));

(double imc, string classificacao, string grau) = p.IMC();

            lb_imc.Text = $"O IMC é igual a: {imc}";
            lb_classificacao.Text = $"A classificação é: {classificacao}";
            lb_grau.Text = $"O grau é: {grau}";
        }

        

        private void mask_altura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mask_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
