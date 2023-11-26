namespace ProjetoRhForm.Apresentação
{
    partial class login
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
            btnSair = new Button();
            btnEntrar = new Button();
            txbSenha = new TextBox();
            lbLogin = new Label();
            lbSenha = new Label();
            MTxbLogin = new MaskedTextBox();
            pcbInicio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbInicio).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ButtonFace;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(75, 119);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(67, 30);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button1_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonFace;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.Location = new Point(181, 118);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(67, 31);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(126, 69);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(122, 23);
            txbSenha.TabIndex = 3;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(26, 18);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(66, 30);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbSenha.Location = new Point(26, 62);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(70, 30);
            lbSenha.TabIndex = 5;
            lbSenha.Text = "Senha";
            // 
            // MTxbLogin
            // 
            MTxbLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MTxbLogin.Location = new Point(126, 22);
            MTxbLogin.Mask = "000,000,000-00";
            MTxbLogin.Name = "MTxbLogin";
            MTxbLogin.Size = new Size(122, 29);
            MTxbLogin.TabIndex = 22;
            MTxbLogin.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MTxbLogin.Click += MTxbLogin_Click;
            MTxbLogin.KeyPress += MTxbCpfFunc_KeyPress;
            // 
            // pcbInicio
            // 
            pcbInicio.Image = Properties.Resources._1828503;
            pcbInicio.Location = new Point(286, 22);
            pcbInicio.Name = "pcbInicio";
            pcbInicio.Size = new Size(100, 83);
            pcbInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbInicio.TabIndex = 23;
            pcbInicio.TabStop = false;
            pcbInicio.Click += pcbInicio_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 185);
            Controls.Add(pcbInicio);
            Controls.Add(MTxbLogin);
            Controls.Add(lbSenha);
            Controls.Add(lbLogin);
            Controls.Add(txbSenha);
            Controls.Add(btnEntrar);
            Controls.Add(btnSair);
            MaximumSize = new Size(443, 224);
            MinimumSize = new Size(443, 224);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pcbInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnEntrar;
        private TextBox txbSenha;
        private Label lbLogin;
        private Label lbSenha;
        private MaskedTextBox MTxbLogin;
        private PictureBox pcbInicio;
    }
}