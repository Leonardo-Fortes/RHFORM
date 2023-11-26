using ProjetoRhForm.Dal;
using ProjetoRhForm.Modelo;


namespace ProjetoRhForm.Apresentação
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }
        public bool Adicionar
        {
            get; set;
        }
        private void txtNomeEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadEmp_Click(object sender, EventArgs e)
        {
            string nomeEmp = txtNomeEmp.Text;
            string cnpjEmp = MtxtCNPJEmp.Text;
            string rua = txbRua.Text;
            string numero = txbNumero.Text;
            string bairro = txbBairro.Text;
            string cidade = txbCidade.Text;
            string uf = txbUF.Text;
            string pais = txbPais.Text;
            string cep = MtxbCEP.Text;

            // Verifica se algum valor é igual a null e lança uma exceção se necessário
            if (string.IsNullOrEmpty(nomeEmp) || string.IsNullOrEmpty(cnpjEmp) || string.IsNullOrEmpty(rua) ||
                string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(bairro) || string.IsNullOrEmpty(cidade) ||
                string.IsNullOrEmpty(uf) || string.IsNullOrEmpty(pais) || string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Nenhum campo pode estar vazio", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Controle controle = new Controle();
                CadastrarOuAlterarEmpresa(controle, nomeEmp, cnpjEmp, rua, numero, bairro, cidade, uf, pais, cep);

                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Operação realizada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CadastrarOuAlterarEmpresa(Controle controle, string nomeEmp, string cnpjEmp, string rua, string numero, string bairro, string cidade, string uf, string pais, string cep)
        {
            if (Adicionar)
            {

                controle.cadastrarEmp(nomeEmp, cnpjEmp, rua, numero, bairro, cidade, uf, pais, cep);

            }
            else
            {
                // Caso a empresa exista, realizar a lógica de alteração
                controle.AlterarEmpresa(nomeEmp, cnpjEmp, rua, numero, bairro, cidade, uf, pais, cep);
            }
        }

        private void MtxtCNPJEmp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MtxtCNPJEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void MtxbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            int limiteCaracteres = 2; // Substitua pelo limite desejado
            if (txbUF.Text.Length >= limiteCaracteres && e.KeyChar != (char)Keys.Back)
            {
                // Se o comprimento já atingiu o limite e a tecla pressionada não for Backspace, ignora a tecla
                e.Handled = true;
            }
            Program.charChar(e);
        }

        private void txbUF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

