namespace ClienteSoap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nUD1 = new NumericUpDown();
            nUD2 = new NumericUpDown();
            btnCalcular = new Button();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            lblResultadoTitulo = new Label();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)nUD1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD2).BeginInit();
            SuspendLayout();

            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(50, 40);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(58, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Número 1:";

            // 
            // nUD1
            // 
            nUD1.Location = new Point(130, 38);
            nUD1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nUD1.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            nUD1.Name = "nUD1";
            nUD1.Size = new Size(120, 23);
            nUD1.TabIndex = 1;

            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(50, 80);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(58, 15);
            lblNumero2.TabIndex = 2;
            lblNumero2.Text = "Número 2:";

            // 
            // nUD2
            // 
            nUD2.Location = new Point(130, 78);
            nUD2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nUD2.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            nUD2.Name = "nUD2";
            nUD2.Size = new Size(120, 23);
            nUD2.TabIndex = 3;

            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(130, 120);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;

            // 
            // lblResultadoTitulo
            // 
            lblResultadoTitulo.AutoSize = true;
            lblResultadoTitulo.Location = new Point(50, 180);
            lblResultadoTitulo.Name = "lblResultadoTitulo";
            lblResultadoTitulo.Size = new Size(63, 15);
            lblResultadoTitulo.TabIndex = 5;
            lblResultadoTitulo.Text = "Resultado:";

            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResultado.Location = new Point(130, 180);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(14, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "0";

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 250);
            Controls.Add(lblResultado);
            Controls.Add(lblResultadoTitulo);
            Controls.Add(btnCalcular);
            Controls.Add(nUD2);
            Controls.Add(lblNumero2);
            Controls.Add(nUD1);
            Controls.Add(lblNumero1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora SOAP";
            ((System.ComponentModel.ISupportInitialize)nUD1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nUD1;
        private NumericUpDown nUD2;
        private Button btnCalcular;
        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblResultadoTitulo;
        private Label lblResultado;
    }
}
