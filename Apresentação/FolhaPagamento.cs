using ProjetoRhForm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRhForm.Apresentação
{
    public partial class FolhaPagamento : Form
    {
        public FolhaPagamento()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string dataInserida = txbData.Text;
            string formatoAtual = "MM-yyyy";
            string formatoDesejado = "yyyy-MM";
            int cnpj = int.Parse(txbCNPJ.Text);

            if (TryFormatarData(dataInserida, formatoAtual, formatoDesejado, out string dataFormatada))
            {
                try
                {
                    Controle controle = new Controle();
                    controle.calcHorasTrabalhadas(txbCpfFunc.Text, dataFormatada, cnpj);
                    if (controle.msg.Equals(""))
                    {
                        if (controle.tem)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Deu errado");
                        }
                    }
                    else
                    {
                        MessageBox.Show(controle.msg);
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }
            else
            {
                Console.WriteLine("Formato de data inválido.");
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
