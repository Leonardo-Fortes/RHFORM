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
using Timer = System.Windows.Forms.Timer;

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

        private void beneficiosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void beneficiosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BeneficioInicio beneficio = new BeneficioInicio();
            beneficio.Show();
        }

        private void descontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }

        private void adicionarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroEmpresa cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.Show();
        }

        private void saírToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string horaInserida = DateTime.Now.ToString("HH:mm:ss");
            string cpfUsu = UsuarioLogado.CPF;
            string dataInserida = DateTime.Now.ToString("dd:MM:yyyy");
            if(DateTime.TryParseExact(horaInserida,"HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime horaIntervalo ) && DateTime.TryParseExact(dataInserida,"dd:MM:yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInvervalo))
            {
                Controle controle = new Controle();
                controle.cadPontoInicioIntervalo(cpfUsu,horaIntervalo,dataInvervalo);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Ponto Cadastrado" + horaIntervalo, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbInicio.Text = horaInserida;
                    }
                    else
                    {
                        MessageBox.Show("Ponto não cadastrado, Tente novamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.msg);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string cpfUsu = UsuarioLogado.CPF;
            string dataInserida = DateTime.Now.ToString("dd-MM-yyyy");
            string dataEntrada = DateTime.Now.ToString("HH:mm:ss");
            if (DateTime.TryParseExact(dataInserida, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataHoje) && DateTime.TryParseExact(dataEntrada, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime dataDeEntrada))
            {
                Controle controle = new Controle();
                controle.cadPontoEntradaFolha(dataDeEntrada, cpfUsu, dataHoje);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Ponto cadastrado " + dataDeEntrada, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbEntrada.Text = dataEntrada;
                    }
                    else
                    {
                        MessageBox.Show("Ponto não cadastrado, Tente novamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.msg);
                }
            }
        }


        private void btnFIm_Click(object sender, EventArgs e)
        {
            lbFim.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            lbSaida.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txbData_TextChanged(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbDataInicio.Text = DateTime.Now.ToString("dd/MM/yy");

        }

        private void lbteste_Click(object sender, EventArgs e)
        {
            lbEntrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lbDataInicio_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCPF_Click(object sender, EventArgs e)
        {

        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void lvUsu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lbUsu_Click(object sender, EventArgs e)
        {
            string cpfUsu = UsuarioLogado.CPF;
            lbUsu.Text = cpfUsu;
        }
    }
}
