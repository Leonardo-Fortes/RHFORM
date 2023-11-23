using ProjetoRhForm.Modelo;

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

            double? convenio = null;
            double? valeTransporte = null;
            double? alimentacao = null;
            double? valeRefeicao = null;
            double? ferias = null;
            double? decimo = null;

            if (string.IsNullOrWhiteSpace(convenioStr))
            {
                MessageBox.Show("Por favor, insira um valor válido para Convênio.");
                return;
            }

            if (Double.TryParse(convenioStr, out double convenioValue))
            {
                convenio = convenioValue;
            }

            if (string.IsNullOrWhiteSpace(valeTransporteStr))
            {
                MessageBox.Show("Por favor, insira um valor válido para Vale Transporte.");
                return;
            }

            if (Double.TryParse(valeTransporteStr, out double valeTransporteValue))
            {
                valeTransporte = valeTransporteValue;
            }
            if (Double.TryParse(alimentacaoStr, out double alimentacaoValue))
            {
                alimentacao = alimentacaoValue;
            }
            if (Double.TryParse(valeRefeicaoStr, out double valeRefeicaoValue))
            {
                valeRefeicao = valeRefeicaoValue;
            }
            if (Double.TryParse(feriasStr, out double feriasValue))
            {
                ferias = feriasValue;
            }
            if (Double.TryParse(decimoStr, out double decimoValue))
            {
                decimo = decimoValue;
            }

            // Repita para as outras variáveis...

            // Agora você tem as variáveis 'convenio', 'valeTransporte', etc., que podem ser null se a conversão falhar.



            if (string.IsNullOrWhiteSpace(this.cpf))
                {
                    MessageBox.Show("Por favor, insira um CPF válido.");
                    return;
                }

                
               
                string dataInserida = txbData.Text;
                string formatoAtual = "MM-yyyy";
                string formatoDesejado = "yyyy-MM";
           
            if (TryFormatarData(dataInserida, formatoAtual, formatoDesejado, out string dataFormatada))
                {
                    // Agora você pode chamar o método de controle com os valores do tipo double
                    controle.cadastrarBeneficios(this.cpf, convenioValue, valeTransporteValue, alimentacaoValue, valeRefeicaoValue, feriasValue, decimoValue, dataFormatada);
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        static bool TryFormatarData(string dataInserida, string formatoAtual, string formatoDesejado, out string dataFormatada)
        {
            if (DateTime.TryParseExact(dataInserida, formatoAtual, null, System.Globalization.DateTimeStyles.None, out DateTime dataConvertida))
            {
                // Se a conversão for bem-sucedida, você pode agora formatar a data no novo formato desejado
                dataFormatada = dataConvertida.ToString(formatoDesejado);
                return true;
            }

            dataFormatada = null;
            return false;
        }
    }
}
