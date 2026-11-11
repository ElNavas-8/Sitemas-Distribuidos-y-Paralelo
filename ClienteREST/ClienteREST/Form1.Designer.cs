namespace ClienteREST
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
            btnTodosLosCarritos = new Button();
            btnCrearCarrito = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnTodosLosCarritos
            // 
            btnTodosLosCarritos.Location = new Point(319, 364);
            btnTodosLosCarritos.Name = "btnTodosLosCarritos";
            btnTodosLosCarritos.Size = new Size(75, 23);
            btnTodosLosCarritos.TabIndex = 0;
            btnTodosLosCarritos.Text = "button1";
            btnTodosLosCarritos.UseVisualStyleBackColor = true;
            btnTodosLosCarritos.Click += btnTodosLosCarritos_Click;
            // 
            // btnCrearCarrito
            // 
            btnCrearCarrito.Location = new Point(400, 364);
            btnCrearCarrito.Name = "btnCrearCarrito";
            btnCrearCarrito.Size = new Size(75, 23);
            btnCrearCarrito.TabIndex = 1;
            btnCrearCarrito.Text = "Crear Carrito";
            btnCrearCarrito.UseVisualStyleBackColor = true;
            btnCrearCarrito.Click += btnCrearCarrito_Click;
            // 
            // button1
            // 
            button1.Location = new Point(363, 214);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Crear Carrito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnCrearCarrito);
            Controls.Add(btnTodosLosCarritos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTodosLosCarritos;
        private Button btnCrearCarrito;
        private Button button1;
    }
}
