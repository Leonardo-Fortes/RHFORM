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
            button1 = new Button();
            panel1 = new Panel();
            lbConsul = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(642, 301);
            button1.Name = "button1";
            button1.Size = new Size(59, 25);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(31, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 286);
            panel1.TabIndex = 1;
            // 
            // lbConsul
            // 
            lbConsul.AutoSize = true;
            lbConsul.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbConsul.Location = new Point(31, 48);
            lbConsul.Name = "lbConsul";
            lbConsul.Size = new Size(321, 50);
            lbConsul.TabIndex = 2;
            lbConsul.Text = "Inserir o Nome ou CNPJ da empresa\r\n\r\n";
            // 
            // ConsultarEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbConsul);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "ConsultarEmpresa";
            Text = "ConsultarEmpresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label lbConsul;
    }
}