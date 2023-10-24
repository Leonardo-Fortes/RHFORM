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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string Login = txbLogin.Text;
            string Senha = txbSenha.Text;

            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Senha))
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                Controle controle = new Controle();
                controle.acessar(txbLogin.Text, txbSenha.Text);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Logado com sucesso", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicio inicio = new inicio();
                        inicio.Show();
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Login ou senha incorretos, Verifique!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.msg);
                }
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
