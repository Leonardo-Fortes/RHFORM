using ProjetoRhForm.Modelo;
namespace ProjetoRhForm.Apresentação
{
    public partial class BeneficioInicio : Form
    {

        public BeneficioInicio()
        {
            InitializeComponent();

        }

        
        public void txbCPFINSERIDO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string cpf = MTxbCPF.Text;

            Beneficios beneficios1 = new Beneficios(cpf);

            Controle controle = new Controle();
            controle.verificaCPF(cpf);
            if (controle.msg.Equals(""))
            {
                if (controle.tem)
                {
                    beneficios1.Adicionar = true;
                    beneficios1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cpf não foi encontrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.msg);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
        }

        private void MTxbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            string cpf = MTxbCPF.Text;

            Beneficios beneficios1 = new Beneficios(cpf);

            Controle controle = new Controle();
            controle.verificaCPF(cpf);
            if (controle.msg.Equals(""))
            {
                if (controle.tem)
                {
                    beneficios1.Adicionar = false;
                    beneficios1.Show();
                }
                else
                {
                    MessageBox.Show("Cpf não foi encontrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.msg);
            }
        }
    }
}
