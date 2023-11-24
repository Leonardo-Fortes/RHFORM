namespace ProjetoRhForm.Apresentação
{
    partial class Beneficios
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
            lbConvenio = new Label();
            txbConvenio = new TextBox();
            txbValeTransporte = new TextBox();
            lbValeTransporte = new Label();
            txbValeRefeicao = new TextBox();
            lbValeRefeicao = new Label();
            txbAlimentacao = new TextBox();
            lbValeAlimentacao = new Label();
            txbFerias = new TextBox();
            lbferias = new Label();
            txbDecimo = new TextBox();
            lbDecimo = new Label();
            lbData = new Label();
            btnAlterar = new Button();
            MTxbData = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbConvenio
            // 
            lbConvenio.AutoSize = true;
            lbConvenio.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbConvenio.Location = new Point(77, 26);
            lbConvenio.Name = "lbConvenio";
            lbConvenio.Size = new Size(108, 30);
            lbConvenio.TabIndex = 0;
            lbConvenio.Text = "Cônvenio";
            // 
            // txbConvenio
            // 
            txbConvenio.Location = new Point(209, 33);
            txbConvenio.Name = "txbConvenio";
            txbConvenio.Size = new Size(94, 23);
            txbConvenio.TabIndex = 1;
            txbConvenio.KeyPress += txbConvenio_KeyPress;
            // 
            // txbValeTransporte
            // 
            txbValeTransporte.Location = new Point(514, 33);
            txbValeTransporte.Name = "txbValeTransporte";
            txbValeTransporte.Size = new Size(111, 23);
            txbValeTransporte.TabIndex = 3;
            txbValeTransporte.TextChanged += textBox2_TextChanged;
            txbValeTransporte.KeyPress += txbValeTransporte_KeyPress;
            // 
            // lbValeTransporte
            // 
            lbValeTransporte.AutoSize = true;
            lbValeTransporte.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeTransporte.Location = new Point(342, 26);
            lbValeTransporte.Name = "lbValeTransporte";
            lbValeTransporte.Size = new Size(166, 30);
            lbValeTransporte.TabIndex = 2;
            lbValeTransporte.Text = "Vale Transporte";
            lbValeTransporte.Click += label1_Click;
            // 
            // txbValeRefeicao
            // 
            txbValeRefeicao.Location = new Point(514, 77);
            txbValeRefeicao.Name = "txbValeRefeicao";
            txbValeRefeicao.Size = new Size(111, 23);
            txbValeRefeicao.TabIndex = 5;
            txbValeRefeicao.TextChanged += txbValeRefeicao_TextChanged;
            txbValeRefeicao.KeyPress += txbValeRefeicao_KeyPress;
            // 
            // lbValeRefeicao
            // 
            lbValeRefeicao.AutoSize = true;
            lbValeRefeicao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeRefeicao.Location = new Point(342, 70);
            lbValeRefeicao.Name = "lbValeRefeicao";
            lbValeRefeicao.Size = new Size(145, 30);
            lbValeRefeicao.TabIndex = 4;
            lbValeRefeicao.Text = "Vale Refeição";
            // 
            // txbAlimentacao
            // 
            txbAlimentacao.Location = new Point(209, 79);
            txbAlimentacao.Name = "txbAlimentacao";
            txbAlimentacao.Size = new Size(94, 23);
            txbAlimentacao.TabIndex = 7;
            txbAlimentacao.KeyPress += txbAlimentacao_KeyPress;
            // 
            // lbValeAlimentacao
            // 
            lbValeAlimentacao.AutoSize = true;
            lbValeAlimentacao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeAlimentacao.Location = new Point(19, 70);
            lbValeAlimentacao.Name = "lbValeAlimentacao";
            lbValeAlimentacao.Size = new Size(184, 30);
            lbValeAlimentacao.TabIndex = 6;
            lbValeAlimentacao.Text = "Vale Alimentação";
            // 
            // txbFerias
            // 
            txbFerias.Location = new Point(209, 122);
            txbFerias.Name = "txbFerias";
            txbFerias.Size = new Size(94, 23);
            txbFerias.TabIndex = 9;
            txbFerias.KeyPress += txbFerias_KeyPress;
            // 
            // lbferias
            // 
            lbferias.AutoSize = true;
            lbferias.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbferias.Location = new Point(115, 117);
            lbferias.Name = "lbferias";
            lbferias.Size = new Size(70, 30);
            lbferias.TabIndex = 8;
            lbferias.Text = "Férias";
            // 
            // txbDecimo
            // 
            txbDecimo.Location = new Point(514, 124);
            txbDecimo.Name = "txbDecimo";
            txbDecimo.Size = new Size(111, 23);
            txbDecimo.TabIndex = 11;
            txbDecimo.KeyPress += txbDecimo_KeyPress;
            // 
            // lbDecimo
            // 
            lbDecimo.AutoSize = true;
            lbDecimo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbDecimo.Location = new Point(342, 117);
            lbDecimo.Name = "lbDecimo";
            lbDecimo.Size = new Size(174, 30);
            lbDecimo.TabIndex = 10;
            lbDecimo.Text = "Décimo Terceiro";
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbData.Location = new Point(99, 155);
            lbData.Name = "lbData";
            lbData.Size = new Size(104, 30);
            lbData.TabIndex = 13;
            lbData.Text = "Mês/Ano";
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = SystemColors.ButtonHighlight;
            btnAlterar.BackgroundImageLayout = ImageLayout.Center;
            btnAlterar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(543, 162);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(82, 37);
            btnAlterar.TabIndex = 15;
            btnAlterar.Text = "OK";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click_1;
            // 
            // MTxbData
            // 
            MTxbData.Location = new Point(209, 162);
            MTxbData.Mask = "00-0000";
            MTxbData.Name = "MTxbData";
            MTxbData.Size = new Size(43, 23);
            MTxbData.TabIndex = 16;
            MTxbData.MaskInputRejected += MTxbData_MaskInputRejected;
            // 
            // Beneficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 205);
            Controls.Add(MTxbData);
            Controls.Add(btnAlterar);
            Controls.Add(lbData);
            Controls.Add(txbDecimo);
            Controls.Add(lbDecimo);
            Controls.Add(txbFerias);
            Controls.Add(lbferias);
            Controls.Add(txbAlimentacao);
            Controls.Add(lbValeAlimentacao);
            Controls.Add(txbValeRefeicao);
            Controls.Add(lbValeRefeicao);
            Controls.Add(txbValeTransporte);
            Controls.Add(lbValeTransporte);
            Controls.Add(txbConvenio);
            Controls.Add(lbConvenio);
            MaximumSize = new Size(668, 244);
            MinimumSize = new Size(668, 244);
            Name = "Beneficios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beneficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbConvenio;
        private TextBox txbConvenio;
        private TextBox txbValeTransporte;
        private Label lbValeTransporte;
        private TextBox txbValeRefeicao;
        private Label lbValeRefeicao;
        private TextBox txbAlimentacao;
        private Label lbValeAlimentacao;
        private TextBox txbFerias;
        private Label lbferias;
        private TextBox txbDecimo;
        private Label lbDecimo;
        private Label lbData;
        private Button btnAlterar;
        private MaskedTextBox MTxbData;
    }
}