namespace ClientForm
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
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            txtCantidad = new TextBox();
            btnConvertir = new Button();
            txtResultado = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(8, 27);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(129, 23);
            txtOrigen.TabIndex = 0;
            txtOrigen.TextChanged += txtOrigen_TextChanged;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(155, 27);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(129, 23);
            txtDestino.TabIndex = 1;
            txtDestino.TextChanged += txtDestino_TextChanged_1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(8, 79);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(276, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextChanged += txtDestino_TextChanged;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(95, 119);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(100, 23);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.TextAlign = ContentAlignment.TopCenter;
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click_1;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(11, 160);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(273, 72);
            txtResultado.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Divisa de origen";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 9);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 6;
            label3.Text = "Divisa de destino";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Cantidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 243);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(btnConvertir);
            Controls.Add(txtCantidad);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Name = "Form1";
            Text = "Conversor de Moneda";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtCantidad;
        private Button btnConvertir;
        private TextBox txtResultado;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
