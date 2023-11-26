namespace ProjetoRhForm.Apresentação
{
    partial class CadastroUsuario
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
            brnCadUsu = new Button();
            lbCadUsu = new Label();
            txbCadSenha = new TextBox();
            txbConfirmarSenha = new TextBox();
            lbCadSenha = new Label();
            lbConfirmarSenha = new Label();
            MtxbCPFFunc = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            cbTipo = new ComboBox();
            lbTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // brnCadUsu
            // 
            brnCadUsu.BackColor = SystemColors.ButtonHighlight;
            brnCadUsu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            brnCadUsu.Location = new Point(369, 24);
            brnCadUsu.Name = "brnCadUsu";
            brnCadUsu.Size = new Size(78, 29);
            brnCadUsu.TabIndex = 0;
            brnCadUsu.Text = "Confirmar";
            brnCadUsu.UseVisualStyleBackColor = false;
            brnCadUsu.Click += brnCadUsu_Click;
            // 
            // lbCadUsu
            // 
            lbCadUsu.AutoSize = true;
            lbCadUsu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCadUsu.Location = new Point(132, 18);
            lbCadUsu.Name = "lbCadUsu";
            lbCadUsu.Size = new Size(78, 32);
            lbCadUsu.TabIndex = 1;
            lbCadUsu.Text = "Login";
            // 
            // txbCadSenha
            // 
            txbCadSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbCadSenha.Location = new Point(230, 63);
            txbCadSenha.Name = "txbCadSenha";
            txbCadSenha.PasswordChar = '*';
            txbCadSenha.Size = new Size(217, 25);
            txbCadSenha.TabIndex = 5;
            // 
            // txbConfirmarSenha
            // 
            txbConfirmarSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbConfirmarSenha.Location = new Point(230, 102);
            txbConfirmarSenha.Name = "txbConfirmarSenha";
            txbConfirmarSenha.PasswordChar = '*';
            txbConfirmarSenha.Size = new Size(217, 25);
            txbConfirmarSenha.TabIndex = 6;
            // 
            // lbCadSenha
            // 
            lbCadSenha.AutoSize = true;
            lbCadSenha.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCadSenha.Location = new Point(128, 56);
            lbCadSenha.Name = "lbCadSenha";
            lbCadSenha.Size = new Size(82, 32);
            lbCadSenha.TabIndex = 7;
            lbCadSenha.Text = "Senha";
            // 
            // lbConfirmarSenha
            // 
            lbConfirmarSenha.AutoSize = true;
            lbConfirmarSenha.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbConfirmarSenha.Location = new Point(12, 95);
            lbConfirmarSenha.Name = "lbConfirmarSenha";
            lbConfirmarSenha.Size = new Size(205, 32);
            lbConfirmarSenha.TabIndex = 8;
            lbConfirmarSenha.Text = "Confirmar Senha";
            // 
            // MtxbCPFFunc
            // 
            MtxbCPFFunc.BackColor = SystemColors.ControlLightLight;
            MtxbCPFFunc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MtxbCPFFunc.Location = new Point(231, 25);
            MtxbCPFFunc.Mask = "000,000,000-00";
            MtxbCPFFunc.Name = "MtxbCPFFunc";
            MtxbCPFFunc.Size = new Size(96, 25);
            MtxbCPFFunc.TabIndex = 28;
            MtxbCPFFunc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MtxbCPFFunc.ValidatingType = typeof(DateTime);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1828503;
            pictureBox1.Location = new Point(22, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "funcionario", "admin" });
            cbTipo.Location = new Point(326, 139);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 30;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTipo.Location = new Point(255, 130);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(65, 32);
            lbTipo.TabIndex = 31;
            lbTipo.Text = "Tipo";
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(462, 187);
            Controls.Add(lbTipo);
            Controls.Add(cbTipo);
            Controls.Add(pictureBox1);
            Controls.Add(MtxbCPFFunc);
            Controls.Add(lbConfirmarSenha);
            Controls.Add(lbCadSenha);
            Controls.Add(txbConfirmarSenha);
            Controls.Add(txbCadSenha);
            Controls.Add(lbCadUsu);
            Controls.Add(brnCadUsu);
            MaximumSize = new Size(500, 300);
            Name = "CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button brnCadUsu;
        private Label lbCadUsu;
        private TextBox txbCadSenha;
        private TextBox txbConfirmarSenha;
        private Label lbCadSenha;
        private Label lbConfirmarSenha;
        private MaskedTextBox MtxbCPFFunc;
        private PictureBox pictureBox1;
        private ComboBox cbTipo;
        private Label lbTipo;
    }
}