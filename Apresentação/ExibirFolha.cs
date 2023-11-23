using ProjetoRhForm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string dataInserida = txbData.Text;
            string formatoAtual = "MM-yyyy";
            string formatoDesejado = "yyyy-MM";
            string cpfUsu = UsuarioLogado.CPF;

            if (TryFormatarData(dataInserida, formatoAtual, formatoDesejado, out string dataFormatada))
            {
                Controle controle = new Controle();
                // Chame o método da camada de controle para obter os dados da folha
                DataRow dadosFolha = controle.ExibirFolha(cpfUsu, dataFormatada);

                // Atualize as labels com os dados obtidos
                if (dadosFolha != null)
                {
                    lbTESTE.Text = $"Qtd Hora: {dadosFolha["qtd_hora"]}";
                    MessageBox.Show("OK");
                    /*labelHoraExtra.Text = $"Hora Extra: {dadosFolha["hora_extra"]}";
                    labelSalarioBase.Text = $"Salário Base: {dadosFolha["salario_base"]}";
                    // Atualize outras labels conforme necessário
                    */
                }
                else
                {
                    // Lógica para lidar com a falta de dados
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
    }
    
}
