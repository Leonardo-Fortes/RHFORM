﻿namespace ProjetoRhForm.Apresentação
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            ínicioToolStripMenuItem = new ToolStripMenuItem();
            trocarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            saírToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            beneficiosToolStripMenuItem = new ToolStripMenuItem();
            descontosToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem = new ToolStripMenuItem();
            empresaToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem1 = new ToolStripMenuItem();
            folhaToolStripMenuItem = new ToolStripMenuItem();
            gerarFolhaToolStripMenuItem = new ToolStripMenuItem();
            consultarFolhaToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            btnEntrada = new Button();
            btnInicio = new Button();
            btnFIm = new Button();
            btnSaida = new Button();
            lbEntrada = new Label();
            lbInicio = new Label();
            lbFim = new Label();
            lbSaida = new Label();
            lbDataInicio = new Label();
            lbUsu = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonShadow;
            menuStrip1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ínicioToolStripMenuItem, funcionárioToolStripMenuItem, empresaToolStripMenuItem, folhaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(519, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ínicioToolStripMenuItem
            // 
            ínicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trocarUsuárioToolStripMenuItem, saírToolStripMenuItem, sairToolStripMenuItem });
            ínicioToolStripMenuItem.Name = "ínicioToolStripMenuItem";
            ínicioToolStripMenuItem.Size = new Size(71, 29);
            ínicioToolStripMenuItem.Text = "Início";
            // 
            // trocarUsuárioToolStripMenuItem
            // 
            trocarUsuárioToolStripMenuItem.Name = "trocarUsuárioToolStripMenuItem";
            trocarUsuárioToolStripMenuItem.Size = new Size(234, 30);
            trocarUsuárioToolStripMenuItem.Text = "Trocar usuário";
            trocarUsuárioToolStripMenuItem.Click += trocarUsuárioToolStripMenuItem_Click;
            // 
            // saírToolStripMenuItem
            // 
            saírToolStripMenuItem.Name = "saírToolStripMenuItem";
            saírToolStripMenuItem.Size = new Size(234, 30);
            saírToolStripMenuItem.Text = "Adicionar usuário";
            saírToolStripMenuItem.Click += saírToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(234, 30);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beneficiosToolStripMenuItem, descontosToolStripMenuItem, alterarToolStripMenuItem });
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(125, 29);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // beneficiosToolStripMenuItem
            // 
            beneficiosToolStripMenuItem.Name = "beneficiosToolStripMenuItem";
            beneficiosToolStripMenuItem.Size = new Size(166, 30);
            beneficiosToolStripMenuItem.Text = "Consultar";
            beneficiosToolStripMenuItem.Click += beneficiosToolStripMenuItem_Click;
            // 
            // descontosToolStripMenuItem
            // 
            descontosToolStripMenuItem.Name = "descontosToolStripMenuItem";
            descontosToolStripMenuItem.Size = new Size(166, 30);
            descontosToolStripMenuItem.Text = "Adicionar";
            descontosToolStripMenuItem.Visible = false;
            descontosToolStripMenuItem.Click += descontosToolStripMenuItem_Click;
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(166, 30);
            alterarToolStripMenuItem.Text = "Alterar";
            alterarToolStripMenuItem.Click += alterarToolStripMenuItem_Click_1;
            // 
            // empresaToolStripMenuItem
            // 
            empresaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, adicionarToolStripMenuItem, alterarToolStripMenuItem1 });
            empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            empresaToolStripMenuItem.Size = new Size(97, 29);
            empresaToolStripMenuItem.Text = "Empresa";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(166, 30);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(166, 30);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click_1;
            // 
            // alterarToolStripMenuItem1
            // 
            alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            alterarToolStripMenuItem1.Size = new Size(166, 30);
            alterarToolStripMenuItem1.Text = "Alterar";
            alterarToolStripMenuItem1.Click += alterarToolStripMenuItem1_Click;
            // 
            // folhaToolStripMenuItem
            // 
            folhaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarFolhaToolStripMenuItem, consultarFolhaToolStripMenuItem });
            folhaToolStripMenuItem.Name = "folhaToolStripMenuItem";
            folhaToolStripMenuItem.Size = new Size(71, 29);
            folhaToolStripMenuItem.Text = "Folha";
            // 
            // gerarFolhaToolStripMenuItem
            // 
            gerarFolhaToolStripMenuItem.Name = "gerarFolhaToolStripMenuItem";
            gerarFolhaToolStripMenuItem.Size = new Size(218, 30);
            gerarFolhaToolStripMenuItem.Text = "Gerar Folha";
            gerarFolhaToolStripMenuItem.Click += gerarFolhaToolStripMenuItem_Click;
            // 
            // consultarFolhaToolStripMenuItem
            // 
            consultarFolhaToolStripMenuItem.Name = "consultarFolhaToolStripMenuItem";
            consultarFolhaToolStripMenuItem.Size = new Size(218, 30);
            consultarFolhaToolStripMenuItem.Text = "Consultar Folha";
            consultarFolhaToolStripMenuItem.Click += consultarFolhaToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // btnEntrada
            // 
            btnEntrada.BackColor = SystemColors.ControlLightLight;
            btnEntrada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrada.Location = new Point(9, 177);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(75, 33);
            btnEntrada.TabIndex = 4;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.ControlLightLight;
            btnInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.Location = new Point(90, 177);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(142, 33);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Início Invervalo";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnFIm
            // 
            btnFIm.BackColor = SystemColors.ControlLightLight;
            btnFIm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFIm.Location = new Point(247, 177);
            btnFIm.Name = "btnFIm";
            btnFIm.Size = new Size(142, 33);
            btnFIm.TabIndex = 6;
            btnFIm.Text = "Fim Invervalo";
            btnFIm.UseVisualStyleBackColor = false;
            btnFIm.Click += btnFIm_Click;
            // 
            // btnSaida
            // 
            btnSaida.BackColor = SystemColors.ControlLightLight;
            btnSaida.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaida.Location = new Point(416, 177);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(75, 33);
            btnSaida.TabIndex = 7;
            btnSaida.Text = "Saída";
            btnSaida.UseVisualStyleBackColor = false;
            btnSaida.Click += btnSaida_Click;
            // 
            // lbEntrada
            // 
            lbEntrada.AutoSize = true;
            lbEntrada.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbEntrada.Location = new Point(8, 136);
            lbEntrada.Name = "lbEntrada";
            lbEntrada.Size = new Size(76, 30);
            lbEntrada.TabIndex = 14;
            lbEntrada.Text = "-------";
            lbEntrada.Click += lbteste_Click;
            // 
            // lbInicio
            // 
            lbInicio.AutoSize = true;
            lbInicio.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbInicio.Location = new Point(121, 136);
            lbInicio.Name = "lbInicio";
            lbInicio.Size = new Size(76, 30);
            lbInicio.TabIndex = 15;
            lbInicio.Text = "-------";
            // 
            // lbFim
            // 
            lbFim.AutoSize = true;
            lbFim.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbFim.Location = new Point(276, 136);
            lbFim.Name = "lbFim";
            lbFim.Size = new Size(76, 30);
            lbFim.TabIndex = 16;
            lbFim.Text = "-------";
            lbFim.Click += lbFim_Click;
            // 
            // lbSaida
            // 
            lbSaida.AutoSize = true;
            lbSaida.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbSaida.Location = new Point(416, 136);
            lbSaida.Name = "lbSaida";
            lbSaida.Size = new Size(76, 30);
            lbSaida.TabIndex = 17;
            lbSaida.Text = "-------";
            // 
            // lbDataInicio
            // 
            lbDataInicio.AutoSize = true;
            lbDataInicio.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDataInicio.Location = new Point(424, 51);
            lbDataInicio.Name = "lbDataInicio";
            lbDataInicio.Size = new Size(68, 25);
            lbDataInicio.TabIndex = 18;
            lbDataInicio.Text = "-------";
            lbDataInicio.Click += lbDataInicio_Click;
            // 
            // lbUsu
            // 
            lbUsu.AutoSize = true;
            lbUsu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsu.Location = new Point(35, 48);
            lbUsu.Name = "lbUsu";
            lbUsu.Size = new Size(0, 25);
            lbUsu.TabIndex = 22;
            lbUsu.Click += lbUsu_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(519, 222);
            Controls.Add(lbUsu);
            Controls.Add(lbSaida);
            Controls.Add(lbFim);
            Controls.Add(btnSaida);
            Controls.Add(lbDataInicio);
            Controls.Add(btnFIm);
            Controls.Add(lbInicio);
            Controls.Add(lbEntrada);
            Controls.Add(btnInicio);
            Controls.Add(menuStrip1);
            Controls.Add(btnEntrada);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(535, 261);
            MinimumSize = new Size(535, 261);
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechInnovate";
            FormClosing += inicio_FormClosing;
            Load += inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ínicioToolStripMenuItem;
        private ToolStripMenuItem trocarUsuárioToolStripMenuItem;
        private ToolStripMenuItem saírToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem beneficiosToolStripMenuItem;
        private ToolStripMenuItem descontosToolStripMenuItem;
        private ToolStripMenuItem empresaToolStripMenuItem;
        private ToolStripMenuItem folhaToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem1;
        private ToolStripMenuItem gerarFolhaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Button btnEntrada;
        private Button btnInicio;
        private Button btnFIm;
        private Button btnSaida;
        private Label lbEntrada;
        private Label lbInicio;
        private Label lbFim;
        private Label lbSaida;
        private Label lbDataInicio;
        private Label lbUsu;
        private ToolStripMenuItem consultarFolhaToolStripMenuItem;
    }
}