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
            txtCNPJEmp = new TextBox();
            SuspendLayout();
            // 
            // btnCadEmp
            // 
            btnCadEmp.Location = new Point(326, 106);
            btnCadEmp.Name = "btnCadEmp";
            btnCadEmp.Size = new Size(75, 23);
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
            txtNomeEmp.Location = new Point(114, 24);
            txtNomeEmp.Name = "txtNomeEmp";
            txtNomeEmp.Size = new Size(323, 25);
            txtNomeEmp.TabIndex = 2;
            txtNomeEmp.TextChanged += txtNomeEmp_TextChanged;
            // 
            // lbCNPJ
            // 
            lbCNPJ.AutoSize = true;
            lbCNPJ.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCNPJ.Location = new Point(12, 89);
            lbCNPJ.Name = "lbCNPJ";
            lbCNPJ.Size = new Size(81, 40);
            lbCNPJ.TabIndex = 3;
            lbCNPJ.Text = "CNPJ";
            // 
            // txtCNPJEmp
            // 
            txtCNPJEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCNPJEmp.Location = new Point(114, 104);
            txtCNPJEmp.Name = "txtCNPJEmp";
            txtCNPJEmp.Size = new Size(116, 25);
            txtCNPJEmp.TabIndex = 4;
            // 
            // CadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 162);
            Controls.Add(txtCNPJEmp);
            Controls.Add(lbCNPJ);
            Controls.Add(txtNomeEmp);
            Controls.Add(lbNomeEmp);
            Controls.Add(btnCadEmp);
            MaximumSize = new Size(463, 201);
            MinimumSize = new Size(463, 201);
            Name = "CadastroEmpresa";
            Text = "CadastroEmpresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadEmp;
        private Label lbNomeEmp;
        private TextBox txtNomeEmp;
        private Label lbCNPJ;
        private TextBox txtCNPJEmp;
    }
}