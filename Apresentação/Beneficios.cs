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

        public bool Adicionar
        {
            get; set;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        private void AdiocionarOUALterar(Controle controle, string cpf, double convenio, double valeTransporte, double alimentacao, double valeRefeicao, double ferias, double decimo, string dataFormatada)
        {


            if (Adicionar)
            {
                controle.cadastrarBeneficios(this.cpf, convenio, valeTransporte, alimentacao, valeRefeicao, ferias, decimo, dataFormatada);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Benefícios Cadastrado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                controle.AlterarBeneficios(this.cpf, convenio, valeTransporte, alimentacao, valeRefeicao, ferias, decimo, dataFormatada);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Benefícios alterados com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
        }

        private void txbConvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbAlimentacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbFerias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbValeTransporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbValeRefeicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbValeRefeicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbDecimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void MTxbData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
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

            if (double.TryParse(convenioStr, out double convenioValue))
            {
                convenio = convenioValue;
            }

            if (double.TryParse(valeTransporteStr, out double valeTransporteValue))
            {
                valeTransporte = valeTransporteValue;
            }

            if (double.TryParse(alimentacaoStr, out double alimentacaoValue))
            {
                alimentacao = alimentacaoValue;
            }

            if (double.TryParse(valeRefeicaoStr, out double valeRefeicaoValue))
            {
                valeRefeicao = valeRefeicaoValue;
            }

            if (double.TryParse(feriasStr, out double feriasValue))
            {
                ferias = feriasValue;
            }

            if (double.TryParse(decimoStr, out double decimoValue))
            {
                decimo = decimoValue;
            }
            if (string.IsNullOrWhiteSpace(this.cpf))
            {
                MessageBox.Show("Por favor, insira um CPF válido.");
                return;
            }

            string dataInserida = MTxbData.Text;
            string formatoAtual = "MM-yyyy";
            string formatoDesejado = "yyyy-MM";

            if (TryFormatarData(dataInserida, formatoAtual, formatoDesejado, out string dataFormatada))
            {

                AdiocionarOUALterar(controle, this.cpf, convenioValue, valeTransporteValue, alimentacaoValue, valeRefeicaoValue, feriasValue, decimoValue, dataFormatada);

            }
            else
            {
                MessageBox.Show("A data inserida não está no formato correto");
            }
        }
    }
}


