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

        public Beneficios(string cpf)
        {
            InitializeComponent();
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
            string data = txbData.Text;

            double convenio;
            double valeTransporte;
            double alimentacao;
            double valeRefeicao;
            double ferias;
            double decimo;
            
            try
            {

                if (string.IsNullOrWhiteSpace(this.cpf))
                {
                    MessageBox.Show("Por favor, insira um CPF válido.");
                    return;
                }

                convenio = Double.Parse(convenioStr);
                valeTransporte = Double.Parse(valeTransporteStr);
                alimentacao = Double.Parse(alimentacaoStr);
                valeRefeicao = Double.Parse(valeRefeicaoStr);
                ferias = Double.Parse(feriasStr);
                decimo = Double.Parse(decimoStr);
                if (DateTime.TryParseExact(data, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInserida))
                {




                    // Agora você pode chamar o método de controle com os valores do tipo double
                    controle.cadastrarBeneficios(this.cpf, convenio, valeTransporte, alimentacao, valeRefeicao, ferias, decimo, dataInserida);
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
                     else
                    {
                        MessageBox.Show("A data inserida não está no formato correto");
                    }               
            }
            catch (FormatException)
            {
                MessageBox.Show("Valores inválidos. Certifique-se de inserir números válidos.");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
