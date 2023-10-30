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
            removerToolStripMenuItem = new ToolStripMenuItem();
            empresaToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem1 = new ToolStripMenuItem();
            removerToolStripMenuItem1 = new ToolStripMenuItem();
            folhaToolStripMenuItem = new ToolStripMenuItem();
            beneficiosToolStripMenuItem1 = new ToolStripMenuItem();
            descontosToolStripMenuItem1 = new ToolStripMenuItem();
            gerarFolhaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lbteste = new Label();
            txbData = new TextBox();
            lbData = new Label();
            txbSaida = new TextBox();
            lbCPF = new Label();
            txbFim = new TextBox();
            txbCPF = new TextBox();
            txbInicio = new TextBox();
            txbEntrada = new TextBox();
            btnSaida = new Button();
            btnFIm = new Button();
            btnInicio = new Button();
            btnEntrada = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ínicioToolStripMenuItem
            // 
            ínicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trocarUsuárioToolStripMenuItem, saírToolStripMenuItem, sairToolStripMenuItem });
            ínicioToolStripMenuItem.Name = "ínicioToolStripMenuItem";
            ínicioToolStripMenuItem.Size = new Size(70, 29);
            ínicioToolStripMenuItem.Text = "ínicio";
            // 
            // trocarUsuárioToolStripMenuItem
            // 
            trocarUsuárioToolStripMenuItem.Name = "trocarUsuárioToolStripMenuItem";
            trocarUsuárioToolStripMenuItem.Size = new Size(234, 30);
            trocarUsuárioToolStripMenuItem.Text = "Trocar usuário";
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
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beneficiosToolStripMenuItem, descontosToolStripMenuItem, alterarToolStripMenuItem, removerToolStripMenuItem });
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
            descontosToolStripMenuItem.Click += descontosToolStripMenuItem_Click;
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(166, 30);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(166, 30);
            removerToolStripMenuItem.Text = "Remover";
            // 
            // empresaToolStripMenuItem
            // 
            empresaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, adicionarToolStripMenuItem, alterarToolStripMenuItem1, removerToolStripMenuItem1 });
            empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            empresaToolStripMenuItem.Size = new Size(97, 29);
            empresaToolStripMenuItem.Text = "Empresa";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(166, 30);
            consultarToolStripMenuItem.Text = "Consultar";
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
            // 
            // removerToolStripMenuItem1
            // 
            removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            removerToolStripMenuItem1.Size = new Size(166, 30);
            removerToolStripMenuItem1.Text = "Remover";
            // 
            // folhaToolStripMenuItem
            // 
            folhaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beneficiosToolStripMenuItem1, descontosToolStripMenuItem1, gerarFolhaToolStripMenuItem });
            folhaToolStripMenuItem.Name = "folhaToolStripMenuItem";
            folhaToolStripMenuItem.Size = new Size(71, 29);
            folhaToolStripMenuItem.Text = "Folha";
            // 
            // beneficiosToolStripMenuItem1
            // 
            beneficiosToolStripMenuItem1.Name = "beneficiosToolStripMenuItem1";
            beneficiosToolStripMenuItem1.Size = new Size(183, 30);
            beneficiosToolStripMenuItem1.Text = "Beneficios";
            beneficiosToolStripMenuItem1.Click += beneficiosToolStripMenuItem1_Click;
            // 
            // descontosToolStripMenuItem1
            // 
            descontosToolStripMenuItem1.Name = "descontosToolStripMenuItem1";
            descontosToolStripMenuItem1.Size = new Size(183, 30);
            descontosToolStripMenuItem1.Text = "Descontos";
            // 
            // gerarFolhaToolStripMenuItem
            // 
            gerarFolhaToolStripMenuItem.Name = "gerarFolhaToolStripMenuItem";
            gerarFolhaToolStripMenuItem.Size = new Size(183, 30);
            gerarFolhaToolStripMenuItem.Text = "Gerar Folha";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbteste);
            panel1.Controls.Add(txbData);
            panel1.Controls.Add(lbData);
            panel1.Controls.Add(txbSaida);
            panel1.Controls.Add(lbCPF);
            panel1.Controls.Add(txbFim);
            panel1.Controls.Add(txbCPF);
            panel1.Controls.Add(txbInicio);
            panel1.Controls.Add(txbEntrada);
            panel1.Controls.Add(btnSaida);
            panel1.Controls.Add(btnFIm);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnEntrada);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 223);
            panel1.TabIndex = 11;
            // 
            // lbteste
            // 
            lbteste.AutoSize = true;
            lbteste.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbteste.Location = new Point(21, 62);
            lbteste.Name = "lbteste";
            lbteste.Size = new Size(68, 25);
            lbteste.TabIndex = 14;
            lbteste.Text = "-------";
            lbteste.Click += lbteste_Click;
            // 
            // txbData
            // 
            txbData.Location = new Point(682, 21);
            txbData.Name = "txbData";
            txbData.Size = new Size(75, 25);
            txbData.TabIndex = 13;
            txbData.TextChanged += txbData_TextChanged;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbData.Location = new Point(601, 18);
            lbData.Name = "lbData";
            lbData.Size = new Size(75, 25);
            lbData.TabIndex = 12;
            lbData.Text = "DATA : ";
            // 
            // txbSaida
            // 
            txbSaida.Location = new Point(539, 62);
            txbSaida.Name = "txbSaida";
            txbSaida.Size = new Size(75, 25);
            txbSaida.TabIndex = 11;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPF.Location = new Point(15, 13);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(45, 25);
            lbCPF.TabIndex = 10;
            lbCPF.Text = "CPF";
            // 
            // txbFim
            // 
            txbFim.Location = new Point(344, 62);
            txbFim.Name = "txbFim";
            txbFim.Size = new Size(142, 25);
            txbFim.TabIndex = 10;
            // 
            // txbCPF
            // 
            txbCPF.Location = new Point(66, 18);
            txbCPF.Name = "txbCPF";
            txbCPF.Size = new Size(201, 25);
            txbCPF.TabIndex = 9;
            // 
            // txbInicio
            // 
            txbInicio.Location = new Point(134, 62);
            txbInicio.Name = "txbInicio";
            txbInicio.Size = new Size(142, 25);
            txbInicio.TabIndex = 9;
            // 
            // txbEntrada
            // 
            txbEntrada.Location = new Point(181, 155);
            txbEntrada.Name = "txbEntrada";
            txbEntrada.Size = new Size(75, 25);
            txbEntrada.TabIndex = 8;
            // 
            // btnSaida
            // 
            btnSaida.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaida.Location = new Point(539, 103);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(75, 33);
            btnSaida.TabIndex = 7;
            btnSaida.Text = "Saída";
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // btnFIm
            // 
            btnFIm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFIm.Location = new Point(344, 103);
            btnFIm.Name = "btnFIm";
            btnFIm.Size = new Size(142, 33);
            btnFIm.TabIndex = 6;
            btnFIm.Text = "Fim Invervalo";
            btnFIm.UseVisualStyleBackColor = true;
            btnFIm.Click += btnFIm_Click;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.Location = new Point(134, 103);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(142, 33);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Início Invervalo";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrada.Location = new Point(14, 103);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(75, 33);
            btnEntrada.TabIndex = 4;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 285);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "inicio";
            Text = "inicio";
            FormClosing += inicio_FormClosing;
            Load += inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private ToolStripMenuItem removerToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem1;
        private ToolStripMenuItem removerToolStripMenuItem1;
        private ToolStripMenuItem beneficiosToolStripMenuItem1;
        private ToolStripMenuItem descontosToolStripMenuItem1;
        private ToolStripMenuItem gerarFolhaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Panel panel1;
        private TextBox txbSaida;
        private TextBox txbFim;
        private TextBox txbInicio;
        private TextBox txbEntrada;
        private Button btnSaida;
        private Button btnFIm;
        private Button btnInicio;
        private Button btnEntrada;
        private Label lbCPF;
        private TextBox txbCPF;
        private TextBox txbData;
        private Label lbData;
        private System.Windows.Forms.Timer timer1;
        private Label lbteste;
    }
}