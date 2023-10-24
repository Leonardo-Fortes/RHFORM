using ProjetoRhForm.Dal;
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
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void txtNomeEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadEmp_Click(object sender, EventArgs e)
        {

            string nomeEmp = txtNomeEmp.Text;
            string cnpjEmp = txtCNPJEmp.Text;
            string rua = txbRua.Text;
            string numero = txbNumero.Text;
            string bairro = txbBairro.Text;
            string cidade = txbCidade.Text;
            string uf = txbUF.Text;
            string pais = txbPais.Text;
            string cep = txbCep.Text;

            // Verifica se algum valor é igual a null e lança uma exceção se necessário
            if (string.IsNullOrEmpty(nomeEmp) || string.IsNullOrEmpty(cnpjEmp) || string.IsNullOrEmpty(rua) ||
                string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(bairro) || string.IsNullOrEmpty(cidade) ||
                string.IsNullOrEmpty(uf) || string.IsNullOrEmpty(pais) || string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Nenhum campo pode estar vazio", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Controle controle = new Controle();
                controle.cadastrarEmp(txtNomeEmp.Text, txtCNPJEmp.Text, txbRua.Text, txbNumero.Text, txbBairro.Text, txbCidade.Text, txbUF.Text, txbPais.Text, txbCep.Text);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Cadastrado com Sucesso", "Empresa Cadastrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo de errado aconteceu, Tente Novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show(controle.msg);
                }
            }
            

        }
    }
}
