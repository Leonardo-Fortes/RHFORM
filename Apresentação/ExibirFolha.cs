using ProjetoRhForm.Dal;
using ProjetoRhForm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRhForm.Apresentação
{
    public partial class ExibirFolha : Form
    {
        public ExibirFolha()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dataInserida = MTxbData.Text;
            string formatoAtual = "MM-yyyy";
            string formatoDesejado = "yyyy-MM";
            string cpfUsu = UsuarioLogado.CPF;
            Controle controle = new Controle();


            if (TryFormatarData(dataInserida, formatoAtual, formatoDesejado, out string dataFormatada))
            {
                string resultado = controle.BuscarDados(cpfUsu);
                lbNomeEmpresa.Text = resultado;

                DataTable dadosFolha = controle.ExibirFolha(cpfUsu, dataFormatada);
                if (dadosFolha != null && dadosFolha.Rows.Count > 0)
                {
                    DataRow linha = dadosFolha.Rows[0]; // Obtenha a primeira linha
                    DataRow linha1 = dadosFolha.Rows[1];

                    // Atribua os valores às labels
                    lbValorSalarioBase.Text = $"{linha["salario_base"]}";
                    lbValorHoraExtra.Text = $"{linha["hora_extra"]} Horas!";
                    lbValorSalarioLiquido.Text = $"{linha["salario_liquido"]}";
                    lbValorHora.Text = $"{linha["qtd_hora"]} Horas!";
                    DateTime dataOriginal = DateTime.ParseExact(linha["mes_ano"].ToString(), "yyyy-MM", CultureInfo.InvariantCulture);
                    string dataCerta = dataOriginal.ToString("MM-yyyy");
                    lbDataFolha.Text = dataCerta;
                    lbValorINSS.Text = $"{linha1["inss"]}";
                    lbValorFGTS.Text = $"{linha1["fgts"]}";
                    lbValorIRRF.Text = $"{linha1["irrf"]}";

                    MessageBox.Show("Folha Consultada!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado para o CPF e data fornecidos.");
                }
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

        private void lbTESTE_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbHoraExtra_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MTxbData_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }

}
