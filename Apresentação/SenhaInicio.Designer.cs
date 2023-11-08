namespace ProjetoRhForm.Apresentação
{
    partial class SenhaInicio
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
            lbSenha = new Label();
            txbSenha = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSenha.Location = new Point(12, 28);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(62, 21);
            lbSenha.TabIndex = 0;
            lbSenha.Text = "Senha :";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(80, 30);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(164, 23);
            txbSenha.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(169, 63);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // SenhaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 98);
            Controls.Add(btnOk);
            Controls.Add(txbSenha);
            Controls.Add(lbSenha);
            MaximumSize = new Size(272, 137);
            MinimumSize = new Size(272, 137);
            Name = "SenhaInicio";
            Text = "SenhaInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSenha;
        private TextBox txbSenha;
        private Button btnOk;
    }
}