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
    public partial class ConsultarFuncionario : Form
    {
        public ConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string cpf = MtxbCPFFunc.Text;
            Controle controle = new Controle();
            DataTable dadosFunc = controle.ConsultarFunc(cpf);
            dataGridView1.DataSource = dadosFunc;
        }

        private void MtxbCPFFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MtxbCPFFunc.Text))
            {
                MtxbCPFFunc.SelectionStart = 0;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.DeletarFunc(MtxbCPFFunc.Text);
            if (controle.msg.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Funcionário deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Funcionário inexistente, tenta novamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(controle.msg);
            }

        }
    }
}
