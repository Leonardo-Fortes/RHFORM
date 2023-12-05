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
            lbData = new Label();
            label1 = new Label();
            MTxbCNPJ = new MaskedTextBox();
            MTxbCpfFunc = new MaskedTextBox();
            MTxbData = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnGerar
            // 
            btnGerar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerar.ForeColor = SystemColors.ControlText;
            btnGerar.Location = new Point(369, 107);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 33);
            btnGerar.TabIndex = 0;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
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
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbData.Location = new Point(356, 31);
            lbData.Name = "lbData";
            lbData.Size = new Size(131, 21);
            lbData.TabIndex = 4;
            lbData.Text = "DATA (Mês-Ano)";
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
            // MTxbCNPJ
            // 
            MTxbCNPJ.BorderStyle = BorderStyle.None;
            MTxbCNPJ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MTxbCNPJ.Location = new Point(21, 118);
            MTxbCNPJ.Mask = "00.000.000/0000-00";
            MTxbCNPJ.Name = "MTxbCNPJ";
            MTxbCNPJ.Size = new Size(100, 22);
            MTxbCNPJ.TabIndex = 20;
            MTxbCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MTxbCNPJ.KeyPress += MTxbCNPJ_KeyPress;
            // 
            // MTxbCpfFunc
            // 
            MTxbCpfFunc.BorderStyle = BorderStyle.None;
            MTxbCpfFunc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MTxbCpfFunc.Location = new Point(21, 58);
            MTxbCpfFunc.Mask = "000.000.000-00";
            MTxbCpfFunc.Name = "MTxbCpfFunc";
            MTxbCpfFunc.Size = new Size(100, 22);
            MTxbCpfFunc.TabIndex = 21;
            MTxbCpfFunc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MTxbCpfFunc.KeyPress += MTxbCpfFunc_KeyPress;
            // 
            // MTxbData
            // 
            MTxbData.BorderStyle = BorderStyle.None;
            MTxbData.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MTxbData.Location = new Point(393, 55);
            MTxbData.Mask = "00-0000";
            MTxbData.Name = "MTxbData";
            MTxbData.Size = new Size(51, 18);
            MTxbData.TabIndex = 22;
            MTxbData.KeyPress += MTxbData_KeyPress;
            // 
            // FolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(499, 189);
            Controls.Add(MTxbData);
            Controls.Add(MTxbCpfFunc);
            Controls.Add(MTxbCNPJ);
            Controls.Add(label1);
            Controls.Add(lbData);
            Controls.Add(lbBuscarCPF);
            Controls.Add(btnGerar);
            MaximumSize = new Size(515, 228);
            MinimumSize = new Size(515, 228);
            Name = "FolhaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechInnovate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGerar;
        private Label lbBuscarCPF;
        private Label lbData;
        private Label label1;
        private MaskedTextBox MTxbCNPJ;
        private MaskedTextBox MTxbCpfFunc;
        private MaskedTextBox MTxbData;
    }
}