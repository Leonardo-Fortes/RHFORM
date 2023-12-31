﻿namespace ProjetoRhForm.Apresentação
{
    partial class ExibirFolha
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
            btnBuscar = new Button();
            lbData = new Label();
            lbINF = new Label();
            panel1 = new Panel();
            lbValeAliResul = new Label();
            lbValeTransResul = new Label();
            lbValeAli = new Label();
            lbValeTrans = new Label();
            lbValorIRRF = new Label();
            lbIRRF = new Label();
            lbValorFGTS = new Label();
            lbFGTS = new Label();
            lbValorINSS = new Label();
            lbINSS = new Label();
            lbValorSalarioLiquido = new Label();
            lbValorSalarioBase = new Label();
            label3 = new Label();
            lb_salarioBase = new Label();
            label2 = new Label();
            lbVencimento = new Label();
            lbDesc = new Label();
            lbDataFolha = new Label();
            lbNomeEmpresa = new Label();
            MTxbData = new MaskedTextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnImprimir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(117, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbData.Location = new Point(8, 43);
            lbData.Name = "lbData";
            lbData.Size = new Size(43, 21);
            lbData.TabIndex = 5;
            lbData.Text = "Data";
            // 
            // lbINF
            // 
            lbINF.AutoSize = true;
            lbINF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbINF.Location = new Point(12, 9);
            lbINF.Name = "lbINF";
            lbINF.Size = new Size(226, 21);
            lbINF.TabIndex = 6;
            lbINF.Text = "Informe a DATA da consulta!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lbValeAliResul);
            panel1.Controls.Add(lbValeTransResul);
            panel1.Controls.Add(lbValeAli);
            panel1.Controls.Add(lbValeTrans);
            panel1.Controls.Add(lbValorIRRF);
            panel1.Controls.Add(lbIRRF);
            panel1.Controls.Add(lbValorFGTS);
            panel1.Controls.Add(lbFGTS);
            panel1.Controls.Add(lbValorINSS);
            panel1.Controls.Add(lbINSS);
            panel1.Controls.Add(lbValorSalarioLiquido);
            panel1.Controls.Add(lbValorSalarioBase);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lb_salarioBase);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbVencimento);
            panel1.Controls.Add(lbDesc);
            panel1.Location = new Point(12, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 313);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // lbValeAliResul
            // 
            lbValeAliResul.AutoSize = true;
            lbValeAliResul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeAliResul.Location = new Point(437, 267);
            lbValeAliResul.Name = "lbValeAliResul";
            lbValeAliResul.Size = new Size(0, 21);
            lbValeAliResul.TabIndex = 21;
            // 
            // lbValeTransResul
            // 
            lbValeTransResul.AutoSize = true;
            lbValeTransResul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeTransResul.Location = new Point(437, 233);
            lbValeTransResul.Name = "lbValeTransResul";
            lbValeTransResul.Size = new Size(0, 21);
            lbValeTransResul.TabIndex = 20;
            // 
            // lbValeAli
            // 
            lbValeAli.AutoSize = true;
            lbValeAli.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeAli.Location = new Point(32, 267);
            lbValeAli.Name = "lbValeAli";
            lbValeAli.Size = new Size(144, 21);
            lbValeAli.TabIndex = 19;
            lbValeAli.Text = "Vale Alimentacao";
            // 
            // lbValeTrans
            // 
            lbValeTrans.AutoSize = true;
            lbValeTrans.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValeTrans.Location = new Point(32, 233);
            lbValeTrans.Name = "lbValeTrans";
            lbValeTrans.Size = new Size(128, 21);
            lbValeTrans.TabIndex = 18;
            lbValeTrans.Text = "Vale Transporte";
            lbValeTrans.Click += lbValeTrans_Click;
            // 
            // lbValorIRRF
            // 
            lbValorIRRF.AutoSize = true;
            lbValorIRRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorIRRF.Location = new Point(437, 201);
            lbValorIRRF.Name = "lbValorIRRF";
            lbValorIRRF.Size = new Size(0, 21);
            lbValorIRRF.TabIndex = 17;
            // 
            // lbIRRF
            // 
            lbIRRF.AutoSize = true;
            lbIRRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIRRF.Location = new Point(32, 201);
            lbIRRF.Name = "lbIRRF";
            lbIRRF.Size = new Size(43, 21);
            lbIRRF.TabIndex = 16;
            lbIRRF.Text = "IRRF";
            // 
            // lbValorFGTS
            // 
            lbValorFGTS.AutoSize = true;
            lbValorFGTS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorFGTS.Location = new Point(437, 165);
            lbValorFGTS.Name = "lbValorFGTS";
            lbValorFGTS.Size = new Size(0, 21);
            lbValorFGTS.TabIndex = 15;
            // 
            // lbFGTS
            // 
            lbFGTS.AutoSize = true;
            lbFGTS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFGTS.Location = new Point(32, 165);
            lbFGTS.Name = "lbFGTS";
            lbFGTS.Size = new Size(47, 21);
            lbFGTS.TabIndex = 14;
            lbFGTS.Text = "FGTS";
            // 
            // lbValorINSS
            // 
            lbValorINSS.AutoSize = true;
            lbValorINSS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorINSS.Location = new Point(437, 131);
            lbValorINSS.Name = "lbValorINSS";
            lbValorINSS.Size = new Size(0, 21);
            lbValorINSS.TabIndex = 13;
            // 
            // lbINSS
            // 
            lbINSS.AutoSize = true;
            lbINSS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbINSS.Location = new Point(32, 131);
            lbINSS.Name = "lbINSS";
            lbINSS.Size = new Size(46, 21);
            lbINSS.TabIndex = 12;
            lbINSS.Text = "INSS";
            // 
            // lbValorSalarioLiquido
            // 
            lbValorSalarioLiquido.AutoSize = true;
            lbValorSalarioLiquido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorSalarioLiquido.Location = new Point(216, 90);
            lbValorSalarioLiquido.Name = "lbValorSalarioLiquido";
            lbValorSalarioLiquido.Size = new Size(0, 21);
            lbValorSalarioLiquido.TabIndex = 9;
            // 
            // lbValorSalarioBase
            // 
            lbValorSalarioBase.AutoSize = true;
            lbValorSalarioBase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorSalarioBase.Location = new Point(216, 54);
            lbValorSalarioBase.Name = "lbValorSalarioBase";
            lbValorSalarioBase.Size = new Size(0, 21);
            lbValorSalarioBase.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 90);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 6;
            label3.Text = "Sálario Liquido";
            label3.Click += label3_Click;
            // 
            // lb_salarioBase
            // 
            lb_salarioBase.AutoSize = true;
            lb_salarioBase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_salarioBase.Location = new Point(32, 54);
            lb_salarioBase.Name = "lb_salarioBase";
            lb_salarioBase.Size = new Size(102, 21);
            lb_salarioBase.TabIndex = 4;
            lb_salarioBase.Text = "Sálario Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(437, 14);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 2;
            label2.Text = "DESCONTO";
            // 
            // lbVencimento
            // 
            lbVencimento.AutoSize = true;
            lbVencimento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbVencimento.Location = new Point(216, 14);
            lbVencimento.Name = "lbVencimento";
            lbVencimento.Size = new Size(115, 21);
            lbVencimento.TabIndex = 1;
            lbVencimento.Text = "VENCIMENTO";
            // 
            // lbDesc
            // 
            lbDesc.AutoSize = true;
            lbDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDesc.Location = new Point(32, 14);
            lbDesc.Name = "lbDesc";
            lbDesc.Size = new Size(98, 21);
            lbDesc.TabIndex = 0;
            lbDesc.Text = "DESCRIÇÃO";
            // 
            // lbDataFolha
            // 
            lbDataFolha.AutoSize = true;
            lbDataFolha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDataFolha.Location = new Point(526, 113);
            lbDataFolha.Name = "lbDataFolha";
            lbDataFolha.Size = new Size(0, 21);
            lbDataFolha.TabIndex = 18;
            // 
            // lbNomeEmpresa
            // 
            lbNomeEmpresa.AutoSize = true;
            lbNomeEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeEmpresa.ForeColor = SystemColors.Highlight;
            lbNomeEmpresa.Location = new Point(12, 90);
            lbNomeEmpresa.Name = "lbNomeEmpresa";
            lbNomeEmpresa.Size = new Size(0, 21);
            lbNomeEmpresa.TabIndex = 18;
            // 
            // MTxbData
            // 
            MTxbData.Location = new Point(57, 46);
            MTxbData.Mask = "00-0000";
            MTxbData.Name = "MTxbData";
            MTxbData.Size = new Size(54, 23);
            MTxbData.TabIndex = 19;
            MTxbData.KeyPress += MTxbData_KeyPress;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(198, 46);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 20;
            btnImprimir.Text = "imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // ExibirFolha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(636, 462);
            Controls.Add(btnImprimir);
            Controls.Add(MTxbData);
            Controls.Add(lbNomeEmpresa);
            Controls.Add(lbDataFolha);
            Controls.Add(panel1);
            Controls.Add(lbINF);
            Controls.Add(lbData);
            Controls.Add(btnBuscar);
            Name = "ExibirFolha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechInnovate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuscar;
        private Label lbData;
        private Label lbINF;
        private Panel panel1;
        private Label lbVencimento;
        private Label lbDesc;
        private Label lb_salarioBase;
        private Label label2;
        private Label label3;
        private Label lbValorSalarioLiquido;
        private Label lbValorSalarioBase;
        private Label lbINSS;
        private Label lbValorINSS;
        private Label lbValorFGTS;
        private Label lbFGTS;
        private Label lbValorIRRF;
        private Label lbIRRF;
        private Label lbDataFolha;
        private Label lbNomeEmpresa;
        private MaskedTextBox MTxbData;
        private Label lbValeAliResul;
        private Label lbValeTransResul;
        private Label lbValeAli;
        private Label lbValeTrans;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnImprimir;
    }
}