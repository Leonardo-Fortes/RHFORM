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
            lbCPF = new Label();
            lbTitulo = new Label();
            btnAdicionar = new Button();
            MTxbCPF = new MaskedTextBox();
            btnAlterar = new Button();
            SuspendLayout();
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPF.Location = new Point(36, 83);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(51, 30);
            lbCPF.TabIndex = 1;
            lbCPF.Text = "CPF";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitulo.Location = new Point(33, 25);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(417, 45);
            lbTitulo.TabIndex = 2;
            lbTitulo.Text = "Informar CPF Colaborador";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(283, 91);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // MTxbCPF
            // 
            MTxbCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MTxbCPF.Location = new Point(93, 83);
            MTxbCPF.Mask = "000.000.000-00";
            MTxbCPF.Name = "MTxbCPF";
            MTxbCPF.Size = new Size(100, 29);
            MTxbCPF.TabIndex = 20;
            MTxbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MTxbCPF.KeyPress += MTxbCPF_KeyPress;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(375, 89);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 21;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click_1;
            // 
            // BeneficioInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 166);
            Controls.Add(btnAlterar);
            Controls.Add(MTxbCPF);
            Controls.Add(btnAdicionar);
            Controls.Add(lbTitulo);
            Controls.Add(lbCPF);
            MaximumSize = new Size(494, 205);
            MinimumSize = new Size(494, 205);
            Name = "BeneficioInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeneficioInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCPF;
        private Label lbTitulo;
        private Button btnAdicionar;
        private MaskedTextBox MTxbCPF;
        private Button btnAlterar;
    }
}