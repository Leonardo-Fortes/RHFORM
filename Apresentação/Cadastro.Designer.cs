namespace ProjetoRhForm.Apresentação
{
    partial class BemVindo
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
            btnUsuario = new Button();
            btnCadFunc = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(-1, 0);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(149, 23);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Cadastrar Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnCadFunc
            // 
            btnCadFunc.Location = new Point(154, 0);
            btnCadFunc.Name = "btnCadFunc";
            btnCadFunc.Size = new Size(152, 23);
            btnCadFunc.TabIndex = 1;
            btnCadFunc.Text = "Cadastrar Funcionario";
            btnCadFunc.UseVisualStyleBackColor = true;
            btnCadFunc.Click += btnCadFunc_Click;
            // 
            // BemVindo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadFunc);
            Controls.Add(btnUsuario);
            Name = "BemVindo";
            Text = "Inicio";
            Load += BemVindo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnCadFunc;
    }
}