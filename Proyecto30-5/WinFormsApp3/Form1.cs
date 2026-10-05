using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyButtonStyles(); // llamada fuera del código generado
        }

        private void ApplyButtonStyles()
        {
            var buttons = new[]
            {
                btnClear, btnBackspace, btnPercent, btnDivide,
                btn7, btn8, btn9, btnMultiply,
                btn4, btn5, btn6, btnSubtract,
                btn1, btn2, btn3, btnAdd,
                btnToggleSign, btn0, btnDecimal, btnEquals
            };

            foreach (var b in buttons)
            {
                if (b == null) continue;
                b.Dock = DockStyle.Fill;
                b.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            }
        }
    }
}