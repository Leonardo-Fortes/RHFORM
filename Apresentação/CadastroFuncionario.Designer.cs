namespace ProjetoRhForm.Apresentação
{
    partial class CadastroFuncionario
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
            btnCadFunc = new Button();
            lbNomeFunc = new Label();
            lbDataFunc = new Label();
            lbTelefoneFunc = new Label();
            lbEmailFunc = new Label();
            lbSexoFunc = new Label();
            lbCPFFunc = new Label();
            lbCargo = new Label();
            lbEmpresa = new Label();
            lbAdmissao = new Label();
            lbSalarioHr = new Label();
            MTxbCNPJ = new MaskedTextBox();
            MTxbTelefoneFunc = new MaskedTextBox();
            MTxbDataNascimento = new MaskedTextBox();
            MtxbCPFFunc = new MaskedTextBox();
            MtxbAdmissao = new MaskedTextBox();
            MtxbHorista = new MaskedTextBox();
            MtxbSexoFunc = new MaskedTextBox();
            txbEmail = new TextBox();
            txbCargoFunc = new TextBox();
            txbNomeFunc = new TextBox();
            lbValeTransporte = new Label();
            cbValeTransporte = new ComboBox();
            lbValeAlimentacao = new Label();
            cbValeAlimentacao = new ComboBox();
            SuspendLayout();
            // 
            // btnCadFunc
            // 
            btnCadFunc.BackColor = SystemColors.ControlLightLight;
            btnCadFunc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadFunc.Location = new Point(691, 237);
            btnCadFunc.Name = "btnCadFunc";
            btnCadFunc.Size = new Size(110, 38);
            btnCadFunc.TabIndex = 0;
            btnCadFunc.Text = "OK";
            btnCadFunc.UseVisualStyleBackColor = false;
            btnCadFunc.Click += btnCadFunc_Click;
            // 
            // lbNomeFunc
            // 
            lbNomeFunc.AutoSize = true;
            lbNomeFunc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeFunc.Location = new Point(12, 52);
            lbNomeFunc.Name = "lbNomeFunc";
            lbNomeFunc.Size = new Size(247, 32);
            lbNomeFunc.TabIndex = 1;
            lbNomeFunc.Text = "Nome Colaborador :";
            // 
            // lbDataFunc
            // 
            lbDataFunc.AutoSize = true;
            lbDataFunc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbDataFunc.Location = new Point(12, 150);
            lbDataFunc.Name = "lbDataFunc";
            lbDataFunc.Size = new Size(259, 32);
            lbDataFunc.TabIndex = 2;
            lbDataFunc.Text = "Data de Nascimento :";
            // 
            // lbTelefoneFunc
            // 
            lbTelefoneFunc.AutoSize = true;
            lbTelefoneFunc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTelefoneFunc.Location = new Point(12, 87);
            lbTelefoneFunc.Name = "lbTelefoneFunc";
            lbTelefoneFunc.Size = new Size(170, 32);
            lbTelefoneFunc.TabIndex = 3;
            lbTelefoneFunc.Text = "Fone Celular :";
            // 
            // lbEmailFunc
            // 
            lbEmailFunc.AutoSize = true;
            lbEmailFunc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmailFunc.Location = new Point(12, 117);
            lbEmailFunc.Name = "lbEmailFunc";
            lbEmailFunc.Size = new Size(90, 32);
            lbEmailFunc.TabIndex = 4;
            lbEmailFunc.Text = "Email :";
            // 
            // lbSexoFunc
            // 
            lbSexoFunc.AutoSize = true;
            lbSexoFunc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbSexoFunc.Location = new Point(296, 87);
            lbSexoFunc.Name = "lbSexoFunc";
            lbSexoFunc.Size = new Size(82, 32);
            lbSexoFunc.TabIndex = 5;
            lbSexoFunc.Text = "Sexo :";
            lbSexoFunc.Click += lbSexoFunc_Click;
            // 
            // lbCPFFunc
            // 
            lbCPFFunc.AutoSize = true;
            lbCPFFunc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPFFunc.Location = new Point(479, 18);
            lbCPFFunc.Name = "lbCPFFunc";
            lbCPFFunc.Size = new Size(206, 32);
            lbCPFFunc.TabIndex = 6;
            lbCPFFunc.Text = "CPF Colaborador";
            // 
            // lbCargo
            // 
            lbCargo.AutoSize = true;
            lbCargo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCargo.Location = new Point(13, 181);
            lbCargo.Name = "lbCargo";
            lbCargo.Size = new Size(96, 32);
            lbCargo.TabIndex = 13;
            lbCargo.Text = "Cargo :";
            // 
            // lbEmpresa
            // 
            lbEmpresa.AutoSize = true;
            lbEmpresa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmpresa.Location = new Point(9, 19);
            lbEmpresa.Name = "lbEmpresa";
            lbEmpresa.Size = new Size(324, 32);
            lbEmpresa.TabIndex = 16;
            lbEmpresa.Text = "CNPJ Empresa Cadastrada :";
            lbEmpresa.Click += lbEmpresa_Click;
            // 
            // lbAdmissao
            // 
            lbAdmissao.AutoSize = true;
            lbAdmissao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbAdmissao.Location = new Point(451, 151);
            lbAdmissao.Name = "lbAdmissao";
            lbAdmissao.Size = new Size(234, 32);
            lbAdmissao.TabIndex = 17;
            lbAdmissao.Text = "Data de Admissão :";
            lbAdmissao.Click += lbAdmissao_Click;
            // 
            // lbSalarioHr
            // 
            lbSalarioHr.AutoSize = true;
            lbSalarioHr.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbSalarioHr.Location = new Point(570, 181);
            lbSalarioHr.Name = "lbSalarioHr";
            lbSalarioHr.Size = new Size(106, 32);
            lbSalarioHr.TabIndex = 19;
            lbSalarioHr.Text = "Sálario :";
            // 
            // MTxbCNPJ
            // 
            MTxbCNPJ.BackColor = SystemColors.ControlLightLight;
            MTxbCNPJ.BorderStyle = BorderStyle.None;
            MTxbCNPJ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MTxbCNPJ.Location = new Point(339, 27);
            MTxbCNPJ.Mask = "00,000,000/0000-00";
            MTxbCNPJ.Name = "MTxbCNPJ";
            MTxbCNPJ.Size = new Size(134, 22);
            MTxbCNPJ.TabIndex = 22;
            MTxbCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MTxbCNPJ.Click += MTxbCNPJ_Click;
            // 
            // MTxbTelefoneFunc
            // 
            MTxbTelefoneFunc.BackColor = SystemColors.ControlLightLight;
            MTxbTelefoneFunc.BorderStyle = BorderStyle.None;
            MTxbTelefoneFunc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MTxbTelefoneFunc.Location = new Point(195, 95);
            MTxbTelefoneFunc.Mask = "00000-9999";
            MTxbTelefoneFunc.Name = "MTxbTelefoneFunc";
            MTxbTelefoneFunc.Size = new Size(95, 22);
            MTxbTelefoneFunc.TabIndex = 23;
            MTxbTelefoneFunc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MTxbTelefoneFunc.Click += MTxbTelefoneFunc_Click;
            // 
            // MTxbDataNascimento
            // 
            MTxbDataNascimento.BackColor = SystemColors.ControlLightLight;
            MTxbDataNascimento.BorderStyle = BorderStyle.None;
            MTxbDataNascimento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MTxbDataNascimento.Location = new Point(272, 158);
            MTxbDataNascimento.Mask = "00-00-0000";
            MTxbDataNascimento.Name = "MTxbDataNascimento";
            MTxbDataNascimento.Size = new Size(85, 22);
            MTxbDataNascimento.TabIndex = 26;
            MTxbDataNascimento.ValidatingType = typeof(DateTime);
            MTxbDataNascimento.MaskInputRejected += MTxbDataNascimento_MaskInputRejected;
            MTxbDataNascimento.Click += MTxbDataNascimento_Click;
            // 
            // MtxbCPFFunc
            // 
            MtxbCPFFunc.BackColor = SystemColors.ControlLightLight;
            MtxbCPFFunc.BorderStyle = BorderStyle.None;
            MtxbCPFFunc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MtxbCPFFunc.Location = new Point(691, 27);
            MtxbCPFFunc.Mask = "000,000,000-00";
            MtxbCPFFunc.Name = "MtxbCPFFunc";
            MtxbCPFFunc.Size = new Size(105, 22);
            MtxbCPFFunc.TabIndex = 27;
            MtxbCPFFunc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MtxbCPFFunc.ValidatingType = typeof(DateTime);
            MtxbCPFFunc.Click += MtxbCPFFunc_Click;
            // 
            // MtxbAdmissao
            // 
            MtxbAdmissao.BackColor = SystemColors.ControlLightLight;
            MtxbAdmissao.BorderStyle = BorderStyle.None;
            MtxbAdmissao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MtxbAdmissao.Location = new Point(703, 158);
            MtxbAdmissao.Mask = "00-00-0000";
            MtxbAdmissao.Name = "MtxbAdmissao";
            MtxbAdmissao.Size = new Size(85, 22);
            MtxbAdmissao.TabIndex = 28;
            MtxbAdmissao.ValidatingType = typeof(DateTime);
            MtxbAdmissao.MaskInputRejected += MtxbAdmissao_MaskInputRejected;
            MtxbAdmissao.Click += MtxbAdmissao_Click;
            // 
            // MtxbHorista
            // 
            MtxbHorista.BackColor = SystemColors.ControlLightLight;
            MtxbHorista.BorderStyle = BorderStyle.None;
            MtxbHorista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MtxbHorista.Location = new Point(682, 186);
            MtxbHorista.Mask = "aaaa";
            MtxbHorista.Name = "MtxbHorista";
            MtxbHorista.Size = new Size(108, 22);
            MtxbHorista.TabIndex = 30;
            MtxbHorista.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MtxbHorista.MaskInputRejected += MtxbHorista_MaskInputRejected;
            MtxbHorista.Click += MtxbHorista_Click;
            MtxbHorista.KeyPress += MtxbHorista_KeyPress;
            // 
            // MtxbSexoFunc
            // 
            MtxbSexoFunc.BackColor = SystemColors.ControlLightLight;
            MtxbSexoFunc.BorderStyle = BorderStyle.None;
            MtxbSexoFunc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MtxbSexoFunc.Location = new Point(384, 97);
            MtxbSexoFunc.Mask = "LLLLLLLLLLLLLLLLLLLLL";
            MtxbSexoFunc.Name = "MtxbSexoFunc";
            MtxbSexoFunc.Size = new Size(89, 22);
            MtxbSexoFunc.TabIndex = 25;
            MtxbSexoFunc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MtxbSexoFunc.MaskInputRejected += MtxbSexoFunc_MaskInputRejected;
            MtxbSexoFunc.Click += MtxbSexoFunc_Click;
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbEmail.Location = new Point(108, 123);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(662, 25);
            txbEmail.TabIndex = 32;
            txbEmail.Click += txbEmail_Click;
            // 
            // txbCargoFunc
            // 
            txbCargoFunc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbCargoFunc.Location = new Point(108, 186);
            txbCargoFunc.Name = "txbCargoFunc";
            txbCargoFunc.Size = new Size(456, 25);
            txbCargoFunc.TabIndex = 33;
            txbCargoFunc.Click += txbCargoFunc_Click;
            // 
            // txbNomeFunc
            // 
            txbNomeFunc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbNomeFunc.Location = new Point(265, 59);
            txbNomeFunc.Name = "txbNomeFunc";
            txbNomeFunc.Size = new Size(523, 25);
            txbNomeFunc.TabIndex = 34;
            txbNomeFunc.Click += txbNomeFunc_Click;
            // 
            // lbValeTransporte
            // 
            lbValeTransporte.AutoSize = true;
            lbValeTransporte.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeTransporte.Location = new Point(13, 214);
            lbValeTransporte.Name = "lbValeTransporte";
            lbValeTransporte.Size = new Size(192, 32);
            lbValeTransporte.TabIndex = 35;
            lbValeTransporte.Text = "Vale Transporte";
            // 
            // cbValeTransporte
            // 
            cbValeTransporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbValeTransporte.FormattingEnabled = true;
            cbValeTransporte.Items.AddRange(new object[] { "Sim", "Não" });
            cbValeTransporte.Location = new Point(211, 221);
            cbValeTransporte.Name = "cbValeTransporte";
            cbValeTransporte.Size = new Size(121, 25);
            cbValeTransporte.TabIndex = 36;
            // 
            // lbValeAlimentacao
            // 
            lbValeAlimentacao.AutoSize = true;
            lbValeAlimentacao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeAlimentacao.Location = new Point(349, 214);
            lbValeAlimentacao.Name = "lbValeAlimentacao";
            lbValeAlimentacao.Size = new Size(211, 32);
            lbValeAlimentacao.TabIndex = 37;
            lbValeAlimentacao.Text = "Vale Alimentação";
            // 
            // cbValeAlimentacao
            // 
            cbValeAlimentacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbValeAlimentacao.FormattingEnabled = true;
            cbValeAlimentacao.Items.AddRange(new object[] { "Sim", "Não" });
            cbValeAlimentacao.Location = new Point(555, 221);
            cbValeAlimentacao.Name = "cbValeAlimentacao";
            cbValeAlimentacao.Size = new Size(121, 25);
            cbValeAlimentacao.TabIndex = 38;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(808, 287);
            Controls.Add(cbValeAlimentacao);
            Controls.Add(lbValeAlimentacao);
            Controls.Add(cbValeTransporte);
            Controls.Add(lbValeTransporte);
            Controls.Add(txbNomeFunc);
            Controls.Add(txbCargoFunc);
            Controls.Add(txbEmail);
            Controls.Add(MtxbHorista);
            Controls.Add(MtxbAdmissao);
            Controls.Add(MtxbCPFFunc);
            Controls.Add(MTxbDataNascimento);
            Controls.Add(MtxbSexoFunc);
            Controls.Add(MTxbTelefoneFunc);
            Controls.Add(MTxbCNPJ);
            Controls.Add(lbSalarioHr);
            Controls.Add(lbAdmissao);
            Controls.Add(lbEmpresa);
            Controls.Add(lbCargo);
            Controls.Add(lbCPFFunc);
            Controls.Add(lbSexoFunc);
            Controls.Add(lbEmailFunc);
            Controls.Add(lbTelefoneFunc);
            Controls.Add(lbDataFunc);
            Controls.Add(lbNomeFunc);
            Controls.Add(btnCadFunc);
            MaximumSize = new Size(824, 326);
            MinimumSize = new Size(824, 326);
            Name = "CadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechInnovate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadFunc;
        private Label lbNomeFunc;
        private Label lbDataFunc;
        private Label lbTelefoneFunc;
        private Label lbEmailFunc;
        private Label lbSexoFunc;
        private Label lbCPFFunc;
        private TextBox txbNomeFunc;
        private TextBox txbTelefoneFunc;
        private Label lbCargo;
        private Label lbEmpresa;
        private Label lbAdmissao;
        private Label lbSalarioHr;
        private MaskedTextBox MTxbCNPJ;
        private MaskedTextBox MTxbTelefoneFunc;
        private MaskedTextBox MTxbDataNascimento;
        private MaskedTextBox MtxbCPFFunc;
        private MaskedTextBox MtxbAdmissao;
        private MaskedTextBox MtxbHorista;
        private MaskedTextBox MtxbSexoFunc;
        private TextBox txbEmail;
        private TextBox txbCargoFunc;
        private TextBox textBox1;
        private TextBox txbNome;
        private Label lbValeTransporte;
        private ComboBox cbValeTransporte;
        private Label lbValeAlimentacao;
        private ComboBox cbValeAlimentacao;
    }
}