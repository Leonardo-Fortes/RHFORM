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
            string cpf = txbCPFINSERIDO.Text;

            Beneficios beneficios1 = new Beneficios(cpf);
            
            Controle controle = new Controle();
            controle.verificaCPF(cpf);
            if (controle.msg.Equals(""))
            {
                if (controle.tem)
                {
                    beneficios1.Show();
                }
                else
                {
                    MessageBox.Show("Cpf não foi encontrado!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.msg);
            }

        }     
     
    }
}
