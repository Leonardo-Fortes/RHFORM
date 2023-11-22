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
            label1 = new Label();
            txbCpfFunc = new TextBox();
            txbData = new TextBox();
            lbData = new Label();
            txbCNPJ = new TextBox();
            SuspendLayout();
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(59, 113);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 0;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 30);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "Apenas um colaborador";
            // 
            // txbCpfFunc
            // 
            txbCpfFunc.Location = new Point(59, 63);
            txbCpfFunc.Name = "txbCpfFunc";
            txbCpfFunc.Size = new Size(228, 23);
            txbCpfFunc.TabIndex = 2;
            // 
            // txbData
            // 
            txbData.Location = new Point(396, 63);
            txbData.Name = "txbData";
            txbData.Size = new Size(128, 23);
            txbData.TabIndex = 3;
            txbData.TextChanged += textBox1_TextChanged;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(396, 30);
            lbData.Name = "lbData";
            lbData.Size = new Size(128, 15);
            lbData.TabIndex = 4;
            lbData.Text = "Inserir data MÊS - ANO";
            // 
            // txbCNPJ
            // 
            txbCNPJ.Location = new Point(336, 214);
            txbCNPJ.Name = "txbCNPJ";
            txbCNPJ.Size = new Size(128, 23);
            txbCNPJ.TabIndex = 5;
            // 
            // FolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbCNPJ);
            Controls.Add(lbData);
            Controls.Add(txbData);
            Controls.Add(txbCpfFunc);
            Controls.Add(label1);
            Controls.Add(btnGerar);
            Name = "FolhaPagamento";
            Text = "FolhaPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGerar;
        private Label label1;
        private TextBox txbCpfFunc;
        private TextBox txbData;
        private Label lbData;
        private TextBox txbCNPJ;
    }
}