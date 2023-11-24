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
    public partial class ConsultarEmpresa : Form
    {
        public ConsultarEmpresa()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cnpj = MTxbCNPJ.Text;
            Controle controle = new Controle();
            DataTable dadosEmp = controle.ConsultarEmpresa(cnpj);
            dataGridView1.DataSource = dadosEmp;
        }

        private void MTxbCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
            int limiteCaracteres = 14; // Substitua pelo limite desejado
            if (MTxbCNPJ.Text.Length >= limiteCaracteres && e.KeyChar != (char)Keys.Back)
            {
                // Se o comprimento já atingiu o limite e a tecla pressionada não for Backspace, ignora a tecla
                e.Handled = true;
            }

        }
    }
}
