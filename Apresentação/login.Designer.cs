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
            txbLogin = new TextBox();
            txbSenha = new TextBox();
            lbLogin = new Label();
            lbSenha = new Label();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ButtonFace;
            btnSair.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(624, 363);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(120, 51);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button1_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonFace;
            btnEntrar.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.Location = new Point(624, 261);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(120, 49);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(436, 168);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(308, 23);
            txbLogin.TabIndex = 2;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(436, 218);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(308, 23);
            txbSenha.TabIndex = 3;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogin.Location = new Point(329, 151);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(88, 40);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbSenha.Location = new Point(329, 201);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(94, 40);
            lbSenha.TabIndex = 5;
            lbSenha.Text = "Senha";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbSenha);
            Controls.Add(lbLogin);
            Controls.Add(txbSenha);
            Controls.Add(txbLogin);
            Controls.Add(btnEntrar);
            Controls.Add(btnSair);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnEntrar;
        private TextBox txbLogin;
        private TextBox txbSenha;
        private Label lbLogin;
        private Label lbSenha;
    }
}