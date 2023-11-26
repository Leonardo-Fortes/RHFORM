using ProjetoRhForm.Modelo;
namespace ProjetoRhForm.Apresentação
{
    public partial class CadastroFuncionario : Form
    {

        public CadastroFuncionario()
        {
            InitializeComponent();
            MTxbCNPJ.TabIndex = 0;
            MtxbCPFFunc.TabIndex = 1;
            txbNomeFunc.TabIndex = 2;
            MTxbTelefoneFunc.TabIndex = 3;
            MtxbSexoFunc.TabIndex = 4;
            txbEmail.TabIndex = 5;
            MTxbDataNascimento.TabIndex = 6;
            MtxbAdmissao.TabIndex = 7;
            txbCargoFunc.TabIndex = 8;
            MtxbHorista.TabIndex = 9;
            btnCadFunc.TabIndex = 10;
        }
        public bool Adicionar
        {
            get; set;
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string dataDigitada = MTxbDataNascimento.Text;
            string nomeFunc = txbNomeFunc.Text;
            string telefoneFunc = MTxbTelefoneFunc.Text;
            string emailFunc = txbEmail.Text;
            string sexoFunc = MtxbSexoFunc.Text;
            string cpfFunc = MtxbCPFFunc.Text;
            string cargo = txbCargoFunc.Text;
            string cnpj = MTxbCNPJ.Text;
            string dataAdmissao = MtxbAdmissao.Text;
            int salarioHr;
            if (int.TryParse(MtxbHorista.Text, out salarioHr))
            {
                if (string.IsNullOrEmpty(nomeFunc) || string.IsNullOrEmpty(telefoneFunc) || string.IsNullOrEmpty(emailFunc) || string.IsNullOrEmpty(sexoFunc) || string.IsNullOrEmpty(cpfFunc) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(cnpj) || string.IsNullOrEmpty(dataDigitada))
                {
                    MessageBox.Show("Nenhum campo pode estar vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (DateTime.TryParseExact(dataDigitada, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInserida) && DateTime.TryParseExact(dataAdmissao, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataadmissao))
                    {
                        // Verifique se a data inserida está acima ou igual à data mínima suportada pelo SQL Server (01/01/1753)
                        if (dataInserida < new DateTime(1753, 1, 1) || dataadmissao < new DateTime(1753, 1, 1))
                        {
                            MessageBox.Show("A data inserida está abaixo do limite .", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (dataadmissao > DateTime.Now || dataInserida > DateTime.Now)
                        {
                            MessageBox.Show("A data inserida está acima do limite .", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            AdicionarOUAlterar(controle, txbNomeFunc.Text, dataInserida, MTxbTelefoneFunc.Text, txbEmail.Text, MtxbSexoFunc.Text, MtxbCPFFunc.Text, txbCargoFunc.Text, MTxbCNPJ.Text, dataadmissao, salarioHr);
                        }
                    }
                    else
                    {
                        MessageBox.Show("A data inserida não está no formato correto");
                    }
                }
            }
            else
            {
                MessageBox.Show("Salário hora deve ser númerico");
            }
        }
        private void AdicionarOUAlterar(Controle controle, string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj, DateTime dataadmissao, int salarioHr)
        {
            if (Adicionar)
            {
                controle.cadastrarFunc(nome, date, telefone, email, sexo, cpf, cargo, cnpj, dataadmissao, salarioHr);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Cadastrado com Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu algo de errado, tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.msg);
                }
            }
            else
            {
                controle.AlterFunc(nome, date, telefone, email, sexo, cpf, cargo, cnpj, dataadmissao, salarioHr);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Alterado com Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu algo de errado, tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.msg);
                }
            }
        }
        private void txbHorista_TextChanged(object sender, EventArgs e)
        {
        }
        private void lbSexoFunc_Click(object sender, EventArgs e)
        {
        }

        private void lbEmpresa_Click(object sender, EventArgs e)
        {

        }



        private void MTxbCNPJ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MTxbCNPJ.Text))
            {
                MTxbCNPJ.SelectionStart = 0;
            }
        }

        private void MtxbCPFFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MtxbCPFFunc.Text))
            {
                MtxbCPFFunc.SelectionStart = 0;
            }
        }

        private void MtxbNomeFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void MTxbTelefoneFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MTxbTelefoneFunc.Text))
            {
                MTxbTelefoneFunc.SelectionStart = 0;
            }
        }

        private void MtxbSexoFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MTxbDataNascimento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MTxbDataNascimento.Text))
            {
                MTxbDataNascimento.SelectionStart = 0;
            }
        }

        private void MtxbAdmissao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MtxbAdmissao.Text))
            {
                MtxbAdmissao.SelectionStart = 0;
            }
        }

        private void MtxbCargoFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MtxbHorista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MtxbHorista.Text))
            {
                MtxbHorista.SelectionStart = 0;
            }
        }

        private void MtxbEmailFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void MTxbDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbNomeFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNomeFunc.Text))
            {
                txbNomeFunc.SelectionStart = 0;
            }
        }

        private void MtxbSexoFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MtxbSexoFunc.Text))
            {
                MtxbSexoFunc.SelectionStart = 0;
            }
        }

        private void txbEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmail.Text))
            {
                txbEmail.SelectionStart = 0;
            }
        }

        private void lbAdmissao_Click(object sender, EventArgs e)
        {

        }

        private void txbCargoFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCargoFunc.Text))
            {
                txbCargoFunc.SelectionStart = 0;
            }
        }

        private void MtxbHorista_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MtxbHorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void MtxbAdmissao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
