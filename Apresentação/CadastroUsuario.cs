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
            string Cadusu = MtxbCPFFunc.Text;
            string CadSenha = txbCadSenha.Text;
            string ConfSenha = txbConfirmarSenha.Text;
            string tipo = cbTipo.Text;

            if (string.IsNullOrEmpty(Cadusu) || string.IsNullOrEmpty(CadSenha) || string.IsNullOrEmpty(ConfSenha))
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Controle controle = new Controle();
                if (VerificarSenhaForte(CadSenha))
                {
                    controle.cadastrar(MtxbCPFFunc.Text, txbCadSenha.Text, txbConfirmarSenha.Text, tipo);

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
                else
                {
                    MessageBox.Show("Senha fraca, Por favor cadastrar uma senha forte seguindo os requisitos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        static bool VerificarSenhaForte(string senha)
        {

            if (!senha.Any(char.IsDigit))
            {
                return false;
            }

            // Verificar a presença de pelo menos uma letra maiúscula
            if (!senha.Any(char.IsUpper))
            {
                return false;
            }

            // Verificar a presença de pelo menos um caractere especial
            if (!senha.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return false;
            }
            if (senha.Length < 8)
            {
                return false;
            }

            // A senha atende a todos os critérios
            return true;
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

