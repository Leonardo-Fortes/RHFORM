namespace ProjetoRhForm.Apresentação
{
    partial class CadastroEmpresa
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
            btnCadEmp = new Button();
            lbNomeEmp = new Label();
            txtNomeEmp = new TextBox();
            lbCNPJ = new Label();
            lbRua = new Label();
            txbRua = new TextBox();
            txbNumero = new TextBox();
            lbNumero = new Label();
            lbBairro = new Label();
            txbBairro = new TextBox();
            txbCidade = new TextBox();
            lbCidade = new Label();
            lbUF = new Label();
            txbUF = new TextBox();
            lbPais = new Label();
            txbPais = new TextBox();
            lbCEP = new Label();
            MtxtCNPJEmp = new MaskedTextBox();
            MtxbCEP = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnCadEmp
            // 
            btnCadEmp.Location = new Point(709, 270);
            btnCadEmp.Name = "btnCadEmp";
            btnCadEmp.Size = new Size(90, 25);
            btnCadEmp.TabIndex = 0;
            btnCadEmp.Text = "OK";
            btnCadEmp.UseVisualStyleBackColor = true;
            btnCadEmp.Click += btnCadEmp_Click;
            // 
            // lbNomeEmp
            // 
            lbNomeEmp.AutoSize = true;
            lbNomeEmp.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomeEmp.Location = new Point(12, 9);
            lbNomeEmp.Name = "lbNomeEmp";
            lbNomeEmp.Size = new Size(96, 40);
            lbNomeEmp.TabIndex = 1;
            lbNomeEmp.Text = "Nome";
            // 
            // txtNomeEmp
            // 
            txtNomeEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeEmp.Location = new Point(139, 24);
            txtNomeEmp.Name = "txtNomeEmp";
            txtNomeEmp.Size = new Size(660, 25);
            txtNomeEmp.TabIndex = 2;
            txtNomeEmp.TextChanged += txtNomeEmp_TextChanged;
            // 
            // lbCNPJ
            // 
            lbCNPJ.AutoSize = true;
            lbCNPJ.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCNPJ.Location = new Point(12, 49);
            lbCNPJ.Name = "lbCNPJ";
            lbCNPJ.Size = new Size(81, 40);
            lbCNPJ.TabIndex = 3;
            lbCNPJ.Text = "CNPJ";
            // 
            // lbRua
            // 
            lbRua.AutoSize = true;
            lbRua.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbRua.Location = new Point(12, 89);
            lbRua.Name = "lbRua";
            lbRua.Size = new Size(65, 40);
            lbRua.TabIndex = 5;
            lbRua.Text = "Rua";
            // 
            // txbRua
            // 
            txbRua.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbRua.Location = new Point(139, 104);
            txbRua.Name = "txbRua";
            txbRua.Size = new Size(660, 25);
            txbRua.TabIndex = 6;
            // 
            // txbNumero
            // 
            txbNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNumero.Location = new Point(140, 144);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(90, 25);
            txbNumero.TabIndex = 7;
            txbNumero.TextChanged += txbNumero_TextChanged;
            txbNumero.KeyPress += txbNumero_KeyPress;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNumero.Location = new Point(12, 129);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(122, 40);
            lbNumero.TabIndex = 8;
            lbNumero.Text = "Numero";
            // 
            // lbBairro
            // 
            lbBairro.AutoSize = true;
            lbBairro.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbBairro.Location = new Point(236, 132);
            lbBairro.Name = "lbBairro";
            lbBairro.Size = new Size(93, 40);
            lbBairro.TabIndex = 9;
            lbBairro.Text = "Bairro";
            // 
            // txbBairro
            // 
            txbBairro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbBairro.Location = new Point(335, 144);
            txbBairro.Name = "txbBairro";
            txbBairro.Size = new Size(464, 25);
            txbBairro.TabIndex = 10;
            // 
            // txbCidade
            // 
            txbCidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbCidade.Location = new Point(140, 184);
            txbCidade.Name = "txbCidade";
            txbCidade.Size = new Size(481, 25);
            txbCidade.TabIndex = 11;
            // 
            // lbCidade
            // 
            lbCidade.AutoSize = true;
            lbCidade.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCidade.Location = new Point(12, 169);
            lbCidade.Name = "lbCidade";
            lbCidade.Size = new Size(106, 40);
            lbCidade.TabIndex = 12;
            lbCidade.Text = "Cidade";
            // 
            // lbUF
            // 
            lbUF.AutoSize = true;
            lbUF.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbUF.Location = new Point(627, 172);
            lbUF.Name = "lbUF";
            lbUF.Size = new Size(51, 40);
            lbUF.TabIndex = 13;
            lbUF.Text = "UF";
            // 
            // txbUF
            // 
            txbUF.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbUF.Location = new Point(684, 184);
            txbUF.Name = "txbUF";
            txbUF.Size = new Size(115, 25);
            txbUF.TabIndex = 14;
            txbUF.KeyPress += txbUF_KeyPress;
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbPais.Location = new Point(12, 209);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(66, 40);
            lbPais.TabIndex = 15;
            lbPais.Text = "País";
            // 
            // txbPais
            // 
            txbPais.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPais.Location = new Point(139, 224);
            txbPais.Name = "txbPais";
            txbPais.Size = new Size(660, 25);
            txbPais.TabIndex = 16;
            // 
            // lbCEP
            // 
            lbCEP.AutoSize = true;
            lbCEP.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCEP.Location = new Point(12, 255);
            lbCEP.Name = "lbCEP";
            lbCEP.Size = new Size(66, 40);
            lbCEP.TabIndex = 18;
            lbCEP.Text = "CEP";
            // 
            // MtxtCNPJEmp
            // 
            MtxtCNPJEmp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MtxtCNPJEmp.Location = new Point(139, 60);
            MtxtCNPJEmp.Mask = "00.000.000/0000-00";
            MtxtCNPJEmp.Name = "MtxtCNPJEmp";
            MtxtCNPJEmp.Size = new Size(100, 29);
            MtxtCNPJEmp.TabIndex = 19;
            MtxtCNPJEmp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MtxtCNPJEmp.MaskInputRejected += MtxtCNPJEmp_MaskInputRejected;
            MtxtCNPJEmp.KeyPress += MtxtCNPJEmp_KeyPress;
            // 
            // MtxbCEP
            // 
            MtxbCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MtxbCEP.Location = new Point(139, 266);
            MtxbCEP.Mask = "00000-000";
            MtxbCEP.Name = "MtxbCEP";
            MtxbCEP.Size = new Size(70, 29);
            MtxbCEP.TabIndex = 20;
            MtxbCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MtxbCEP.KeyPress += MtxbCEP_KeyPress;
            // 
            // CadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 323);
            Controls.Add(MtxbCEP);
            Controls.Add(MtxtCNPJEmp);
            Controls.Add(lbCEP);
            Controls.Add(txbPais);
            Controls.Add(lbPais);
            Controls.Add(txbUF);
            Controls.Add(lbUF);
            Controls.Add(lbCidade);
            Controls.Add(txbCidade);
            Controls.Add(txbBairro);
            Controls.Add(lbBairro);
            Controls.Add(lbNumero);
            Controls.Add(txbNumero);
            Controls.Add(txbRua);
            Controls.Add(lbRua);
            Controls.Add(lbCNPJ);
            Controls.Add(txtNomeEmp);
            Controls.Add(lbNomeEmp);
            Controls.Add(btnCadEmp);
            MaximumSize = new Size(836, 362);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(836, 362);
            Name = "CadastroEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroEmpresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadEmp;
        private Label lbNomeEmp;
        private TextBox txtNomeEmp;
        private Label lbCNPJ;
        private Label lbRua;
        private TextBox txbRua;
        private TextBox txbNumero;
        private Label lbNumero;
        private Label lbBairro;
        private TextBox txbBairro;
        private TextBox txbCidade;
        private Label lbCidade;
        private Label lbUF;
        private TextBox txbUF;
        private Label lbPais;
        private TextBox txbPais;
        private Label lbCEP;
        private MaskedTextBox MtxtCNPJEmp;
        private MaskedTextBox MtxbCEP;
    }
}