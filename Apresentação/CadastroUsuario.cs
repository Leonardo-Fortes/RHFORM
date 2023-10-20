using Microsoft.VisualBasic;
using ProjetoRhForm.Dal;
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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void brnCadUsu_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle();



            controle.cadastrar(txbCadUsu.Text, txbCadSenha.Text, txbConfirmarSenha.Text);

            if (controle.msg.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Cadastrado com sucesso", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("tente novamente!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(controle.msg);
            }


        }



    }
}
