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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
           
                Controle controle = new Controle();

                
                string dataDigitada = txbDataFunc.Text;

                if (DateTime.TryParseExact(dataDigitada, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInserida))
                {
                
                    controle.cadastrarFunc(txbNomeFunc.Text, dataInserida, txbTelefoneFunc.Text, txbEmailFunc.Text, txbSexoFunc.Text, txbCPFFunc.Text);
                    if (controle.msg.Equals(""))
                    {
                        if (controle.tem)
                        {
                            MessageBox.Show("Cadastrado com Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BemVindo bv = new BemVindo();
                            bv.Show();
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
               
                    MessageBox.Show("A data inserida não está no formato correto");
                }
                
            





        }
    }
}
