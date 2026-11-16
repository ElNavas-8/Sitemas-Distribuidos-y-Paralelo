namespace ClienteWinForms
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
            btnConectar = new Button();
            txtCantidad = new TextBox();
            cmbDe = new ComboBox();
            cmbA = new ComboBox();
            btnConvertir = new Button();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(185, 64);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "button1";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(88, 185);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(273, 23);
            txtCantidad.TabIndex = 1;
            // 
            // cmbDe
            // 
            cmbDe.FormattingEnabled = true;
            cmbDe.Location = new Point(88, 142);
            cmbDe.Name = "cmbDe";
            cmbDe.Size = new Size(121, 23);
            cmbDe.TabIndex = 2;
            // 
            // cmbA
            // 
            cmbA.FormattingEnabled = true;
            cmbA.Location = new Point(240, 142);
            cmbA.Name = "cmbA";
            cmbA.Size = new Size(121, 23);
            cmbA.TabIndex = 3;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(185, 230);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 324);
            Controls.Add(btnConvertir);
            Controls.Add(cmbA);
            Controls.Add(cmbDe);
            Controls.Add(txtCantidad);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private TextBox txtCantidad;
        private ComboBox cmbDe;
        private ComboBox cmbA;
        private Button btnConvertir;
    }
}
