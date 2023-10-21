namespace ProjetoRhForm.Apresentação
{
    partial class inicio
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
            btnCadastros = new Button();
            SuspendLayout();
            // 
            // btnCadastros
            // 
            btnCadastros.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastros.Location = new Point(399, 12);
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Size = new Size(235, 45);
            btnCadastros.TabIndex = 0;
            btnCadastros.Text = "Cadastros";
            btnCadastros.UseVisualStyleBackColor = true;
            btnCadastros.Click += btnCadastros_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastros);
            Name = "inicio";
            Text = "inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastros;
    }
}