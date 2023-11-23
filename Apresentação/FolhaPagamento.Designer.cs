namespace ProjetoRhForm.Apresentação
{
    partial class FolhaPagamento
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
            btnGerar = new Button();
            lbBuscarCPF = new Label();
            txbCpfFunc = new TextBox();
            txbData = new TextBox();
            lbData = new Label();
            txbCNPJ = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGerar
            // 
            btnGerar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerar.Location = new Point(369, 108);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 36);
            btnGerar.TabIndex = 0;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lbBuscarCPF
            // 
            lbBuscarCPF.AutoSize = true;
            lbBuscarCPF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbBuscarCPF.Location = new Point(21, 31);
            lbBuscarCPF.Name = "lbBuscarCPF";
            lbBuscarCPF.Size = new Size(222, 21);
            lbBuscarCPF.TabIndex = 1;
            lbBuscarCPF.Text = "CPF (Colaborador específico)";
            // 
            // txbCpfFunc
            // 
            txbCpfFunc.Location = new Point(21, 64);
            txbCpfFunc.Name = "txbCpfFunc";
            txbCpfFunc.Size = new Size(228, 23);
            txbCpfFunc.TabIndex = 2;
            // 
            // txbData
            // 
            txbData.Location = new Point(317, 64);
            txbData.Name = "txbData";
            txbData.Size = new Size(127, 23);
            txbData.TabIndex = 3;
            txbData.TextChanged += textBox1_TextChanged;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbData.Location = new Point(317, 31);
            lbData.Name = "lbData";
            lbData.Size = new Size(131, 21);
            lbData.TabIndex = 4;
            lbData.Text = "DATA (Mês-Ano)";
            // 
            // txbCNPJ
            // 
            txbCNPJ.Location = new Point(21, 118);
            txbCNPJ.Name = "txbCNPJ";
            txbCNPJ.Size = new Size(128, 23);
            txbCNPJ.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 94);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 6;
            label1.Text = "CNPJ ";
            // 
            // FolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 189);
            Controls.Add(label1);
            Controls.Add(txbCNPJ);
            Controls.Add(lbData);
            Controls.Add(txbData);
            Controls.Add(txbCpfFunc);
            Controls.Add(lbBuscarCPF);
            Controls.Add(btnGerar);
            Name = "FolhaPagamento";
            Text = "FolhaPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGerar;
        private Label lbBuscarCPF;
        private TextBox txbCpfFunc;
        private TextBox txbData;
        private Label lbData;
        private TextBox txbCNPJ;
        private Label label1;
    }
}