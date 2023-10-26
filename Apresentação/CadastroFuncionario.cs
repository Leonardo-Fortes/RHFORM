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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }
        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string dataDigitada = txbDataFunc.Text;
            string nomeFunc = txbNomeFunc.Text;
            string telefoneFunc = txbTelefoneFunc.Text;
            string emailFunc = txbEmailFunc.Text;
            string sexoFunc = txbSexoFunc.Text;
            string cpfFunc = txbCPFFunc.Text;
            string cargo = txbCargo.Text;
            string cnpj = txbCNPJ.Text;
            string dataAdmissao = txbAdmissao.Text;
            if (string.IsNullOrEmpty(nomeFunc) || string.IsNullOrEmpty(telefoneFunc) || string.IsNullOrEmpty(emailFunc) || string.IsNullOrEmpty(sexoFunc) || string.IsNullOrEmpty(cpfFunc) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(cnpj) || string.IsNullOrEmpty(dataDigitada))
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DateTime.TryParseExact(dataDigitada, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInserida) && DateTime.TryParseExact(dataAdmissao,"dd-MM-yyyy",null,System.Globalization.DateTimeStyles.None, out DateTime dataadmissao))
                {
                    // Verifique se a data inserida está acima ou igual à data mínima suportada pelo SQL Server (01/01/1753)
                    if (dataInserida < new DateTime (1753, 1, 1) || dataadmissao < new DateTime(1753,1,1)) 
                    {                      
                            MessageBox.Show("A data inserida está abaixo do limite .", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);         
                    }
                    if (dataadmissao > DateTime.Now || dataInserida > DateTime.Now)
                    {
                        MessageBox.Show("A data inserida está acima do limite .", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        controle.cadastrarFunc(txbNomeFunc.Text, dataInserida, txbTelefoneFunc.Text, txbEmailFunc.Text, txbSexoFunc.Text, txbCPFFunc.Text, txbCargo.Text, txbCNPJ.Text, dataadmissao);
                        if (controle.msg.Equals(""))
                        {
                            if (controle.tem)
                            {
                                MessageBox.Show("Cadastrado com Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu algo de errado, tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(controle.msg);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("A data inserida não está no formato correto");
                }
            }
        }
    }
}
