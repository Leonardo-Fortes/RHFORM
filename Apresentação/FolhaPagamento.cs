﻿using ProjetoRhForm.Modelo;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string dataInserida = MTxbData.Text;
            string formatoAtual = "MM-yyyy";
            string formatoDesejado = "yyyy-MM";
            string cnpj = MTxbCNPJ.Text;
            if (TryFormatarData(dataInserida, formatoAtual, formatoDesejado, out string dataFormatada))
            {
                try
                {
                    Controle controle = new Controle();
                    controle.calcHorasTrabalhadas(MTxbCpfFunc.Text, dataFormatada, cnpj);
                    if (controle.msg.Equals(""))
                    {
                        if (controle.tem)
                        {
                            MessageBox.Show("Folha Gerada Com Sucesso!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                catch (SqlException ex)
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
                dataFormatada = dataConvertida.ToString(formatoDesejado);
                return true;
            }
            dataFormatada = null;
            return false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void MTxbCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
            int limiteCaracteres = 14; // Substitua pelo limite desejado
            if (MTxbCNPJ.Text.Length >= limiteCaracteres && e.KeyChar != (char)Keys.Back)
            {
                // Se o comprimento já atingiu o limite e a tecla pressionada não for Backspace, ignora a tecla
                e.Handled = true;
            }
        }

        private void MTxbCpfFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void MTxbData_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }
}
