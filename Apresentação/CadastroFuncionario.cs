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
            if (DateTime.TryParseExact(dataDigitada, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInserida))
            {
                // Verifique se a data inserida está acima ou igual à data mínima suportada pelo SQL Server (01/01/1753)
                if (dataInserida < new DateTime(1753, 1, 1))
                {
                    MessageBox.Show("A data inserida está abaixo do limite .", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    controle.cadastrarFunc(txbNomeFunc.Text, dataInserida, txbTelefoneFunc.Text, txbEmailFunc.Text, txbSexoFunc.Text, txbCPFFunc.Text, txbCargo.Text, txbCNPJ.Text);
                    if (controle.msg.Equals(""))
                    {
                        if (controle.tem)
                        {
                            MessageBox.Show("Cadastrado com Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cadastro bv = new Cadastro();
                            bv.Show();
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
