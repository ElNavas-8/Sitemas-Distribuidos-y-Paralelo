namespace ClienteForms
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
            Enviar = new Button();
            SuspendLayout();
            // 
            // Enviar
            // 
            Enviar.Location = new Point(713, 415);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(75, 23);
            Enviar.TabIndex = 0;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Enviar);
            Name = "Form1";
            Text = "Cliente Sistema Distribuido";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Enviar;
    }
}
