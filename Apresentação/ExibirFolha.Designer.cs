namespace ProjetoRhForm.Apresentação
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
            label1 = new Label();
            txbCPF = new TextBox();
            txbData = new TextBox();
            lbTESTE = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 109);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // txbCPF
            // 
            txbCPF.Location = new Point(110, 149);
            txbCPF.Name = "txbCPF";
            txbCPF.Size = new Size(100, 23);
            txbCPF.TabIndex = 1;
            // 
            // txbData
            // 
            txbData.Location = new Point(278, 149);
            txbData.Name = "txbData";
            txbData.Size = new Size(100, 23);
            txbData.TabIndex = 2;
            // 
            // lbTESTE
            // 
            lbTESTE.AutoSize = true;
            lbTESTE.Location = new Point(278, 53);
            lbTESTE.Name = "lbTESTE";
            lbTESTE.Size = new Size(37, 15);
            lbTESTE.TabIndex = 3;
            lbTESTE.Text = "TESTE";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(550, 302);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ExibirFolha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(lbTESTE);
            Controls.Add(txbData);
            Controls.Add(txbCPF);
            Controls.Add(label1);
            Name = "ExibirFolha";
            Text = "ExibirFolha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbCPF;
        private TextBox txbData;
        private Label lbTESTE;
        private Button btnBuscar;
    }
}