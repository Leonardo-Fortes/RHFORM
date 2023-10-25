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
            Controle controle = new Controle();
            controle.validarFuncBeneficio(txbCPFINSERIDO.Text);
            if (controle.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("deu certo");
                }
                else
                {
                    MessageBox.Show("deu errado");
                }
            }
            else
            {
                MessageBox.Show(controle.msg);
            }
        }

        public string CPFINSERIDO
        {
            get
            {
                return txbCPFINSERIDO.Text;
            }
        }
    }
}
