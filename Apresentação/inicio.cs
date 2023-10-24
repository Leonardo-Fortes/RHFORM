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
    public partial class inicio : Form
    {
        private bool fechamentoConfirmado = false;
        public inicio()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.Show();
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();
        }

        private void cadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.Show();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastrofuncionario = new CadastroFuncionario();
            cadastrofuncionario.Show();
        }

        private void adicionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastro = new CadastroUsuario();
            cadastro.Show();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fechamentoConfirmado)
            {
                if (MessageBox.Show("Deseja fechar a aplicação ?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    fechamentoConfirmado = true;
                    Application.Exit();
                }
            }
        }
    }
}
