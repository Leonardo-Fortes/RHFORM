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
            txbNomeFunc = new TextBox();
            txbDataFunc = new TextBox();
            txbTelefoneFunc = new TextBox();
            txbEmailFunc = new TextBox();
            txbSexoFunc = new TextBox();
            txbCPFFunc = new TextBox();
            SuspendLayout();
            // 
            // btnCadFunc
            // 
            btnCadFunc.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadFunc.Location = new Point(570, 370);
            btnCadFunc.Name = "btnCadFunc";
            btnCadFunc.Size = new Size(177, 49);
            btnCadFunc.TabIndex = 0;
            btnCadFunc.Text = "Cadastrar";
            btnCadFunc.UseVisualStyleBackColor = true;
            btnCadFunc.Click += btnCadFunc_Click;
            // 
            // lbNomeFunc
            // 
            lbNomeFunc.AutoSize = true;
            lbNomeFunc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomeFunc.Location = new Point(40, 9);
            lbNomeFunc.Name = "lbNomeFunc";
            lbNomeFunc.Size = new Size(96, 40);
            lbNomeFunc.TabIndex = 1;
            lbNomeFunc.Text = "Nome";
            // 
            // lbDataFunc
            // 
            lbDataFunc.AutoSize = true;
            lbDataFunc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDataFunc.Location = new Point(40, 76);
            lbDataFunc.Name = "lbDataFunc";
            lbDataFunc.Size = new Size(277, 40);
            lbDataFunc.TabIndex = 2;
            lbDataFunc.Text = "Data de Nascimento";
            // 
            // lbTelefoneFunc
            // 
            lbTelefoneFunc.AutoSize = true;
            lbTelefoneFunc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTelefoneFunc.Location = new Point(40, 141);
            lbTelefoneFunc.Name = "lbTelefoneFunc";
            lbTelefoneFunc.Size = new Size(123, 40);
            lbTelefoneFunc.TabIndex = 3;
            lbTelefoneFunc.Text = "Telefone";
            // 
            // lbEmailFunc
            // 
            lbEmailFunc.AutoSize = true;
            lbEmailFunc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmailFunc.Location = new Point(40, 213);
            lbEmailFunc.Name = "lbEmailFunc";
            lbEmailFunc.Size = new Size(86, 40);
            lbEmailFunc.TabIndex = 4;
            lbEmailFunc.Text = "Email";
            // 
            // lbSexoFunc
            // 
            lbSexoFunc.AutoSize = true;
            lbSexoFunc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbSexoFunc.Location = new Point(40, 278);
            lbSexoFunc.Name = "lbSexoFunc";
            lbSexoFunc.Size = new Size(77, 40);
            lbSexoFunc.TabIndex = 5;
            lbSexoFunc.Text = "Sexo";
            // 
            // lbCPFFunc
            // 
            lbCPFFunc.AutoSize = true;
            lbCPFFunc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCPFFunc.Location = new Point(40, 351);
            lbCPFFunc.Name = "lbCPFFunc";
            lbCPFFunc.Size = new Size(65, 40);
            lbCPFFunc.TabIndex = 6;
            lbCPFFunc.Text = "CPF";
            // 
            // txbNomeFunc
            // 
            txbNomeFunc.Location = new Point(40, 50);
            txbNomeFunc.Name = "txbNomeFunc";
            txbNomeFunc.Size = new Size(277, 23);
            txbNomeFunc.TabIndex = 7;
            // 
            // txbDataFunc
            // 
            txbDataFunc.Location = new Point(40, 119);
            txbDataFunc.Name = "txbDataFunc";
            txbDataFunc.Size = new Size(277, 23);
            txbDataFunc.TabIndex = 8;
            // 
            // txbTelefoneFunc
            // 
            txbTelefoneFunc.Location = new Point(40, 187);
            txbTelefoneFunc.Name = "txbTelefoneFunc";
            txbTelefoneFunc.Size = new Size(277, 23);
            txbTelefoneFunc.TabIndex = 9;
            // 
            // txbEmailFunc
            // 
            txbEmailFunc.Location = new Point(40, 256);
            txbEmailFunc.Name = "txbEmailFunc";
            txbEmailFunc.Size = new Size(277, 23);
            txbEmailFunc.TabIndex = 10;
            // 
            // txbSexoFunc
            // 
            txbSexoFunc.Location = new Point(40, 325);
            txbSexoFunc.Name = "txbSexoFunc";
            txbSexoFunc.Size = new Size(277, 23);
            txbSexoFunc.TabIndex = 11;
            // 
            // txbCPFFunc
            // 
            txbCPFFunc.Location = new Point(40, 397);
            txbCPFFunc.Name = "txbCPFFunc";
            txbCPFFunc.Size = new Size(277, 23);
            txbCPFFunc.TabIndex = 12;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbCPFFunc);
            Controls.Add(txbSexoFunc);
            Controls.Add(txbEmailFunc);
            Controls.Add(txbTelefoneFunc);
            Controls.Add(txbDataFunc);
            Controls.Add(txbNomeFunc);
            Controls.Add(lbCPFFunc);
            Controls.Add(lbSexoFunc);
            Controls.Add(lbEmailFunc);
            Controls.Add(lbTelefoneFunc);
            Controls.Add(lbDataFunc);
            Controls.Add(lbNomeFunc);
            Controls.Add(btnCadFunc);
            Name = "CadastroFuncionario";
            Text = "CadastroFuncionario";
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
        private TextBox txbDataFunc;
        private TextBox txbTelefoneFunc;
        private TextBox txbEmailFunc;
        private TextBox txbSexoFunc;
        private TextBox txbCPFFunc;
    }
}