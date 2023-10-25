namespace ProjetoRhForm.Apresentação
{
    partial class Ponto
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
            button1 = new Button();
            lbHoraEntrada = new Label();
            txbEntrada = new TextBox();
            txbSaída = new TextBox();
            lbSaida = new Label();
            textBox3 = new TextBox();
            lbCPF = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(319, 87);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbHoraEntrada
            // 
            lbHoraEntrada.AutoSize = true;
            lbHoraEntrada.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbHoraEntrada.Location = new Point(22, 40);
            lbHoraEntrada.Name = "lbHoraEntrada";
            lbHoraEntrada.Size = new Size(83, 25);
            lbHoraEntrada.TabIndex = 1;
            lbHoraEntrada.Text = "Entrada ";
            // 
            // txbEntrada
            // 
            txbEntrada.Location = new Point(99, 45);
            txbEntrada.Name = "txbEntrada";
            txbEntrada.Size = new Size(100, 23);
            txbEntrada.TabIndex = 2;
            // 
            // txbSaída
            // 
            txbSaída.Location = new Point(294, 48);
            txbSaída.Name = "txbSaída";
            txbSaída.Size = new Size(100, 23);
            txbSaída.TabIndex = 4;
            // 
            // lbSaida
            // 
            lbSaida.AutoSize = true;
            lbSaida.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbSaida.Location = new Point(230, 43);
            lbSaida.Name = "lbSaida";
            lbSaida.Size = new Size(58, 25);
            lbSaida.TabIndex = 3;
            lbSaida.Text = "Saída";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 16);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 23);
            textBox3.TabIndex = 6;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPF.Location = new Point(22, 11);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(45, 25);
            lbCPF.TabIndex = 5;
            lbCPF.Text = "CPF";
            // 
            // Ponto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 135);
            Controls.Add(textBox3);
            Controls.Add(lbCPF);
            Controls.Add(txbSaída);
            Controls.Add(lbSaida);
            Controls.Add(txbEntrada);
            Controls.Add(lbHoraEntrada);
            Controls.Add(button1);
            Name = "Ponto";
            Text = "Ponto";
            Load += Ponto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbHoraEntrada;
        private TextBox txbEntrada;
        private TextBox txbSaída;
        private Label lbSaida;
        private TextBox textBox3;
        private Label lbCPF;
    }
}