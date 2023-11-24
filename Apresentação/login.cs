using ProjetoRhForm.Modelo;
namespace ProjetoRhForm.Apresentação
{
    public static class UsuarioLogado
    {
        public static string CPF
        {
            get; set;
        }
    }

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
            string Login = MTxbLogin.Text;
            string Senha = txbSenha.Text;

            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Senha))
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Controle controle = new Controle();
                controle.acessar(MTxbLogin.Text, txbSenha.Text);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Logado com sucesso", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicio inicio = new inicio();
                        inicio.Show();
                        this.Hide();
                        UsuarioLogado.CPF = Login;
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

        private void MTxbCpfFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pcbInicio_Click(object sender, EventArgs e)
        {

        }
    }

}
