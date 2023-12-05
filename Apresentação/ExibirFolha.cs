using ProjetoRhForm.Dal;
using ProjetoRhForm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
                    DataRow linha2 = dadosFolha.Rows[2];
                    // Atribua os valores às labels
                    lbValorSalarioBase.Text = $"{linha["salario_base"]}";
                    lbValorSalarioLiquido.Text = $"{linha["salario_liquido"]}";
                    DateTime dataOriginal = DateTime.ParseExact(linha["mes_ano"].ToString(), "yyyy-MM", CultureInfo.InvariantCulture);
                    string dataCerta = dataOriginal.ToString("MM-yyyy");
                    lbDataFolha.Text = dataCerta;
                    lbValorINSS.Text = $"{linha1["inss"]}";
                    lbValorFGTS.Text = $"{linha1["fgts"]}";
                    lbValorIRRF.Text = $"{linha1["irrf"]}";
                    lbValeAliResul.Text = $"{linha2["valealimentacao"]}";
                    lbValeTransResul.Text = $"{linha2["valetransporte"]}";


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

        private void lbValeTrans_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.ImprimirConteudo);

            // Mostrar a caixa de diálogo de impressão
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }


        private void ImprimirConteudo(object sender, PrintPageEventArgs e)
        {
            // Criar uma instância de Graphics para desenhar no documento
            Graphics g = e.Graphics;

            // Definir a fonte e a cor
            Font fonte = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Definir as posições iniciais e os incrementos
            float x = 50; // Posição X inicial
            float y = 50; // Posição Y inicial
            float larguraColuna = 150; // Largura das colunas
            float alturaLinha = 20; // Altura das linhas
            float incremento = alturaLinha + 5; // Incremento para as próximas linhas

            // Exemplo de impressão de uma tabela
            string[] titulos = { "Descrição", "Valor" };
            string[,] dados = {
            { "Nome da Empresa", lbNomeEmpresa.Text },
            { "Salário Base", lbValorSalarioBase.Text },
            // Adicione mais linhas conforme necessário
        };

            // Imprimir cabeçalho da tabela
            for (int i = 0; i < titulos.Length; i++)
            {
                g.DrawString(titulos[i], fonte, brush, x + i * larguraColuna, y);
            }
            y += incremento;

            // Imprimir dados da tabela
            for (int i = 0; i < dados.GetLength(0); i++)
            {
                for (int j = 0; j < dados.GetLength(1); j++)
                {
                    g.DrawString(dados[i, j], fonte, brush, x + j * larguraColuna, y + i * incremento);
                }
            }

            // Limpar recursos
            fonte.Dispose();
            brush.Dispose();
        }


    }
}


