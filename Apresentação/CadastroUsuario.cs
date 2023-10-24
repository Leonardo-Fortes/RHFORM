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
            string Cadusu = txbCadUsu.Text;
            string CadSenha = txbCadSenha.Text;
            string ConfSenha = txbConfirmarSenha.Text;

            if (string.IsNullOrEmpty(Cadusu) || string.IsNullOrEmpty(CadSenha) || string.IsNullOrEmpty(ConfSenha))
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Controle controle = new Controle();
                controle.cadastrar(txbCadUsu.Text, txbCadSenha.Text, txbConfirmarSenha.Text);

                if (controle.msg.Equals(""))
                {

                    if (controle.tem)
                    {
                        MessageBox.Show("Cadastrado com sucesso", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
}
