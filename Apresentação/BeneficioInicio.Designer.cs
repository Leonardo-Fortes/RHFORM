namespace ProjetoRhForm.Apresentação
{
    partial class BeneficioInicio
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
            txbCPFINSERIDO = new TextBox();
            lbCPF = new Label();
            lbTitulo = new Label();
            btnAlterar = new Button();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // txbCPFINSERIDO
            // 
            txbCPFINSERIDO.Location = new Point(90, 134);
            txbCPFINSERIDO.Name = "txbCPFINSERIDO";
            txbCPFINSERIDO.Size = new Size(254, 23);
            txbCPFINSERIDO.TabIndex = 0;
            txbCPFINSERIDO.TextChanged += txbCPFINSERIDO_TextChanged;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPF.Location = new Point(33, 127);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(51, 30);
            lbCPF.TabIndex = 1;
            lbCPF.Text = "CPF";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI Semibold", 30.3F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitulo.Location = new Point(142, 20);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(539, 55);
            lbTitulo.TabIndex = 2;
            lbTitulo.Text = "Inserir o CPF do funcionário";
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(444, 135);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 3;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(363, 135);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // BeneficioInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdicionar);
            Controls.Add(btnAlterar);
            Controls.Add(lbTitulo);
            Controls.Add(lbCPF);
            Controls.Add(txbCPFINSERIDO);
            Name = "BeneficioInicio";
            Text = "BeneficioInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbCPFINSERIDO;
        private Label lbCPF;
        private Label lbTitulo;
        private Button btnAlterar;
        private Button btnAdicionar;
    }
}