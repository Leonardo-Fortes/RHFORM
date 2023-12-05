namespace ProjetoRhForm.Apresentação
{
    partial class ConsultarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnConsultar = new Button();
            lbCPF = new Label();
            MtxbCPFFunc = new MaskedTextBox();
            btnDeletar = new Button();
            lbOBS = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 364);
            dataGridView1.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.ButtonHighlight;
            btnConsultar.Location = new Point(179, 30);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPF.Location = new Point(12, 24);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(50, 30);
            lbCPF.TabIndex = 2;
            lbCPF.Text = "CPF";
            // 
            // MtxbCPFFunc
            // 
            MtxbCPFFunc.BackColor = SystemColors.ControlLightLight;
            MtxbCPFFunc.BorderStyle = BorderStyle.None;
            MtxbCPFFunc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MtxbCPFFunc.Location = new Point(68, 31);
            MtxbCPFFunc.Mask = "000,000,000-00";
            MtxbCPFFunc.Name = "MtxbCPFFunc";
            MtxbCPFFunc.Size = new Size(105, 22);
            MtxbCPFFunc.TabIndex = 28;
            MtxbCPFFunc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MtxbCPFFunc.ValidatingType = typeof(DateTime);
            MtxbCPFFunc.Click += MtxbCPFFunc_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = SystemColors.ButtonHighlight;
            btnDeletar.Location = new Point(260, 30);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 29;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // lbOBS
            // 
            lbOBS.AutoSize = true;
            lbOBS.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbOBS.ForeColor = Color.Firebrick;
            lbOBS.Location = new Point(502, 58);
            lbOBS.Name = "lbOBS";
            lbOBS.Size = new Size(286, 13);
            lbOBS.TabIndex = 30;
            lbOBS.Text = "*OBS DEIXAR BLOCO VAZIO PARA CONSULTAR TODOS";
            // 
            // ConsultarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(lbOBS);
            Controls.Add(btnDeletar);
            Controls.Add(MtxbCPFFunc);
            Controls.Add(lbCPF);
            Controls.Add(btnConsultar);
            Controls.Add(dataGridView1);
            Name = "ConsultarFuncionario";
            Text = "TechInnovate";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnConsultar;
        private Label lbCPF;
        private MaskedTextBox MtxbCPFFunc;
        private Button btnDeletar;
        private Label lbOBS;
    }
}