﻿namespace ProjetoRhForm.Apresentação
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
            btnBeneficio = new Button();
            SuspendLayout();
            // 
            // lbConvenio
            // 
            lbConvenio.AutoSize = true;
            lbConvenio.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbConvenio.Location = new Point(409, 74);
            lbConvenio.Name = "lbConvenio";
            lbConvenio.Size = new Size(108, 30);
            lbConvenio.TabIndex = 0;
            lbConvenio.Text = "Cônvenio";
            // 
            // txbConvenio
            // 
            txbConvenio.Location = new Point(523, 81);
            txbConvenio.Name = "txbConvenio";
            txbConvenio.Size = new Size(94, 23);
            txbConvenio.TabIndex = 1;
            // 
            // txbValeTransporte
            // 
            txbValeTransporte.Location = new Point(184, 40);
            txbValeTransporte.Name = "txbValeTransporte";
            txbValeTransporte.Size = new Size(111, 23);
            txbValeTransporte.TabIndex = 3;
            txbValeTransporte.TextChanged += textBox2_TextChanged;
            // 
            // lbValeTransporte
            // 
            lbValeTransporte.AutoSize = true;
            lbValeTransporte.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeTransporte.Location = new Point(12, 33);
            lbValeTransporte.Name = "lbValeTransporte";
            lbValeTransporte.Size = new Size(166, 30);
            lbValeTransporte.TabIndex = 2;
            lbValeTransporte.Text = "Vale Transporte";
            lbValeTransporte.Click += label1_Click;
            // 
            // txbValeRefeicao
            // 
            txbValeRefeicao.Location = new Point(184, 83);
            txbValeRefeicao.Name = "txbValeRefeicao";
            txbValeRefeicao.Size = new Size(111, 23);
            txbValeRefeicao.TabIndex = 5;
            // 
            // lbValeRefeicao
            // 
            lbValeRefeicao.AutoSize = true;
            lbValeRefeicao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeRefeicao.Location = new Point(12, 74);
            lbValeRefeicao.Name = "lbValeRefeicao";
            lbValeRefeicao.Size = new Size(145, 30);
            lbValeRefeicao.TabIndex = 4;
            lbValeRefeicao.Text = "Vale Refeição";
            // 
            // txbAlimentacao
            // 
            txbAlimentacao.Location = new Point(523, 40);
            txbAlimentacao.Name = "txbAlimentacao";
            txbAlimentacao.Size = new Size(94, 23);
            txbAlimentacao.TabIndex = 7;
            // 
            // lbValeAlimentacao
            // 
            lbValeAlimentacao.AutoSize = true;
            lbValeAlimentacao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeAlimentacao.Location = new Point(333, 33);
            lbValeAlimentacao.Name = "lbValeAlimentacao";
            lbValeAlimentacao.Size = new Size(184, 30);
            lbValeAlimentacao.TabIndex = 6;
            lbValeAlimentacao.Text = "Vale Alimentação";
            // 
            // txbFerias
            // 
            txbFerias.Location = new Point(523, 122);
            txbFerias.Name = "txbFerias";
            txbFerias.Size = new Size(94, 23);
            txbFerias.TabIndex = 9;
            // 
            // lbferias
            // 
            lbferias.AutoSize = true;
            lbferias.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbferias.Location = new Point(431, 113);
            lbferias.Name = "lbferias";
            lbferias.Size = new Size(70, 30);
            lbferias.TabIndex = 8;
            lbferias.Text = "Férias";
            // 
            // txbDecimo
            // 
            txbDecimo.Location = new Point(184, 129);
            txbDecimo.Name = "txbDecimo";
            txbDecimo.Size = new Size(111, 23);
            txbDecimo.TabIndex = 11;
            // 
            // lbDecimo
            // 
            lbDecimo.AutoSize = true;
            lbDecimo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbDecimo.Location = new Point(12, 122);
            lbDecimo.Name = "lbDecimo";
            lbDecimo.Size = new Size(174, 30);
            lbDecimo.TabIndex = 10;
            lbDecimo.Text = "Décimo Terceiro";
            // 
            // btnBeneficio
            // 
            btnBeneficio.BackColor = SystemColors.ButtonHighlight;
            btnBeneficio.BackgroundImageLayout = ImageLayout.Center;
            btnBeneficio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBeneficio.Location = new Point(535, 156);
            btnBeneficio.Name = "btnBeneficio";
            btnBeneficio.Size = new Size(82, 37);
            btnBeneficio.TabIndex = 12;
            btnBeneficio.Text = "OK";
            btnBeneficio.UseVisualStyleBackColor = false;
            btnBeneficio.Click += btnBeneficio_Click;
            // 
            // Beneficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 205);
            Controls.Add(btnBeneficio);
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
            Name = "Beneficios";
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
        private Button btnBeneficio;
    }
}