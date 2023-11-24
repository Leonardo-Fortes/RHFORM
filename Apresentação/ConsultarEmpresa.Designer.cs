namespace ProjetoRhForm.Apresentação
{
    partial class ConsultarEmpresa
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
            btnConsultar = new Button();
            lbConsul = new Label();
            dataGridView1 = new DataGridView();
            MTxbCNPJ = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(424, 48);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(84, 25);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button1_Click;
            // 
            // lbConsul
            // 
            lbConsul.AutoSize = true;
            lbConsul.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbConsul.Location = new Point(31, 48);
            lbConsul.Name = "lbConsul";
            lbConsul.Size = new Size(251, 25);
            lbConsul.TabIndex = 2;
            lbConsul.Text = "CNPJ (Buscar uma empresa)";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(747, 318);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MTxbCNPJ
            // 
            MTxbCNPJ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MTxbCNPJ.Location = new Point(288, 46);
            MTxbCNPJ.Mask = "00.000.000/0000-00";
            MTxbCNPJ.Name = "MTxbCNPJ";
            MTxbCNPJ.Size = new Size(130, 29);
            MTxbCNPJ.TabIndex = 21;
            MTxbCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MTxbCNPJ.KeyPress += MTxbCNPJ_KeyPress;
            // 
            // ConsultarEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MTxbCNPJ);
            Controls.Add(dataGridView1);
            Controls.Add(lbConsul);
            Controls.Add(btnConsultar);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "ConsultarEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarEmpresa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Label lbConsul;
        private DataGridView dataGridView1;
        private MaskedTextBox MTxbCNPJ;
    }
}