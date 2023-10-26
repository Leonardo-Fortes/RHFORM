using ProjetoRhForm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRhForm.Apresentação
{
    public partial class Beneficios : Form
    {
        private string cpf;
        public Beneficios()
        {
            InitializeComponent();
        }
        public Beneficios(string cpf)
        {
            this.cpf = cpf;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBeneficio_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string convenioStr = txbConvenio.Text;
            string valeTransporteStr = txbValeTransporte.Text;
            string alimentacaoStr = txbAlimentacao.Text;
            string valeRefeicaoStr = txbValeRefeicao.Text;
            string feriasStr = txbFerias.Text;
            string decimoStr = txbDecimo.Text;

            double convenio;
            double valeTransporte;
            double alimentacao;
            double valeRefeicao;
            double ferias;
            double decimo;
        
            try
            {
                convenio = Double.Parse(convenioStr);
                valeTransporte = Double.Parse(valeTransporteStr);
                alimentacao = Double.Parse(alimentacaoStr);
                valeRefeicao = Double.Parse(valeRefeicaoStr);
                ferias = Double.Parse(feriasStr);
                decimo = Double.Parse(decimoStr);

                // Agora você pode chamar o método de controle com os valores do tipo double
                controle.cadastrarBeneficios(cpf, convenio, valeTransporte, alimentacao, valeRefeicao, ferias, decimo);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Benefícios adicionados com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro, tente novamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.msg);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valores inválidos. Certifique-se de inserir números válidos.");
            }



        }
    }
}
