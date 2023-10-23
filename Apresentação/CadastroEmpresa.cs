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
