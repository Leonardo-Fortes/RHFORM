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
            txbCadUsu = new TextBox();
            txbCadSenha = new TextBox();
            txbConfirmarSenha = new TextBox();
            lbCadSenha = new Label();
            lbConfirmarSenha = new Label();
            lbCodUsu = new Label();
            txbCodUsu = new TextBox();
            SuspendLayout();
            // 
            // brnCadUsu
            // 
            brnCadUsu.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            brnCadUsu.Location = new Point(562, 348);
            brnCadUsu.Name = "brnCadUsu";
            brnCadUsu.Size = new Size(214, 49);
            brnCadUsu.TabIndex = 0;
            brnCadUsu.Text = "Cadastrar-se";
            brnCadUsu.UseVisualStyleBackColor = true;
            brnCadUsu.Click += brnCadUsu_Click;
            // 
            // lbCadUsu
            // 
            lbCadUsu.AutoSize = true;
            lbCadUsu.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCadUsu.Location = new Point(227, 97);
            lbCadUsu.Name = "lbCadUsu";
            lbCadUsu.Size = new Size(88, 40);
            lbCadUsu.TabIndex = 1;
            lbCadUsu.Text = "Login";
            // 
            // txbCadUsu
            // 
            txbCadUsu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbCadUsu.Location = new Point(337, 109);
            txbCadUsu.Name = "txbCadUsu";
            txbCadUsu.Size = new Size(439, 29);
            txbCadUsu.TabIndex = 4;
            // 
            // txbCadSenha
            // 
            txbCadSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbCadSenha.Location = new Point(337, 167);
            txbCadSenha.Name = "txbCadSenha";
            txbCadSenha.PasswordChar = '*';
            txbCadSenha.Size = new Size(439, 29);
            txbCadSenha.TabIndex = 5;
            // 
            // txbConfirmarSenha
            // 
            txbConfirmarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbConfirmarSenha.Location = new Point(462, 232);
            txbConfirmarSenha.Name = "txbConfirmarSenha";
            txbConfirmarSenha.PasswordChar = '*';
            txbConfirmarSenha.Size = new Size(314, 29);
            txbConfirmarSenha.TabIndex = 6;
            // 
            // lbCadSenha
            // 
            lbCadSenha.AutoSize = true;
            lbCadSenha.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCadSenha.Location = new Point(227, 155);
            lbCadSenha.Name = "lbCadSenha";
            lbCadSenha.Size = new Size(94, 40);
            lbCadSenha.TabIndex = 7;
            lbCadSenha.Text = "Senha";
            // 
            // lbConfirmarSenha
            // 
            lbConfirmarSenha.AutoSize = true;
            lbConfirmarSenha.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbConfirmarSenha.Location = new Point(227, 221);
            lbConfirmarSenha.Name = "lbConfirmarSenha";
            lbConfirmarSenha.Size = new Size(229, 40);
            lbConfirmarSenha.TabIndex = 8;
            lbConfirmarSenha.Text = "Confirmar Senha";
            // 
            // lbCodUsu
            // 
            lbCodUsu.AutoSize = true;
            lbCodUsu.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodUsu.Location = new Point(528, 291);
            lbCodUsu.Name = "lbCodUsu";
            lbCodUsu.Size = new Size(110, 40);
            lbCodUsu.TabIndex = 9;
            lbCodUsu.Text = "Código";
            // 
            // txbCodUsu
            // 
            txbCodUsu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbCodUsu.Location = new Point(644, 296);
            txbCodUsu.Name = "txbCodUsu";
            txbCodUsu.Size = new Size(60, 29);
            txbCodUsu.TabIndex = 10;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbCodUsu);
            Controls.Add(lbCodUsu);
            Controls.Add(lbConfirmarSenha);
            Controls.Add(lbCadSenha);
            Controls.Add(txbConfirmarSenha);
            Controls.Add(txbCadSenha);
            Controls.Add(txbCadUsu);
            Controls.Add(lbCadUsu);
            Controls.Add(brnCadUsu);
            Name = "CadastroUsuario";
            Text = "CadastroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button brnCadUsu;
        private Label lbCadUsu;
        private TextBox txbCadUsu;
        private TextBox txbCadSenha;
        private TextBox txbConfirmarSenha;
        private Label lbCadSenha;
        private Label lbConfirmarSenha;
        private Label lbCodUsu;
        private TextBox txbCodUsu;
    }
}