using System.ComponentModel;
using WinFormsApp3;

namespace WinFormsApp3
{
    partial class Form1
    {
        private IContainer components = null;
        private TextBox textBoxDisplay;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnClear;
        private Button btnBackspace;
        private Button btnPercent;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtract;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btnToggleSign;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEquals;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.textBoxDisplay = new TextBox();
            this.tableLayoutPanelButtons = new TableLayoutPanel();
            this.btnClear = new Button();
            this.btnBackspace = new Button();
            this.btnPercent = new Button();
            this.btnDivide = new Button();
            this.btn7 = new Button();
            this.btn8 = new Button();
            this.btn9 = new Button();
            this.btnMultiply = new Button();
            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btnSubtract = new Button();
            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btnAdd = new Button();
            this.btnToggleSign = new Button();
            this.btn0 = new Button();
            this.btnDecimal = new Button();
            this.btnEquals = new Button();

            this.SuspendLayout();

            // Form
            this.ClientSize = new Size(384, 520);
            this.Name = "Form1";
            this.Text = "Calculadora";

            // textBoxDisplay
            this.textBoxDisplay.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            this.textBoxDisplay.Location = new Point(12, 12);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new Size(360, 62);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.Text = "0";
            this.textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            this.textBoxDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // tableLayoutPanelButtons
            this.tableLayoutPanelButtons.ColumnCount = 4;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.RowCount = 5;
            this.tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.Location = new Point(12, 86);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.Size = new Size(360, 422);
            this.tableLayoutPanelButtons.TabIndex = 1;
            this.tableLayoutPanelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // Buttons - propiedades explícitas (evita funciones locales dentro de InitializeComponent)
            this.btnClear.Dock = DockStyle.Fill;
            this.btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "C";

            this.btnBackspace.Dock = DockStyle.Fill;
            this.btnBackspace.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Text = "⌫";

            this.btnPercent.Dock = DockStyle.Fill;
            this.btnPercent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Text = "%";

            this.btnDivide.Dock = DockStyle.Fill;
            this.btnDivide.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Text = "÷";

            this.btn7.Dock = DockStyle.Fill;
            this.btn7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn7.Name = "btn7";
            this.btn7.Text = "7";

            this.btn8.Dock = DockStyle.Fill;
            this.btn8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn8.Name = "btn8";
            this.btn8.Text = "8";

            this.btn9.Dock = DockStyle.Fill;
            this.btn9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn9.Name = "btn9";
            this.btn9.Text = "9";

            this.btnMultiply.Dock = DockStyle.Fill;
            this.btnMultiply.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Text = "×";

            this.btn4.Dock = DockStyle.Fill;
            this.btn4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn4.Name = "btn4";
            this.btn4.Text = "4";

            this.btn5.Dock = DockStyle.Fill;
            this.btn5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn5.Name = "btn5";
            this.btn5.Text = "5";

            this.btn6.Dock = DockStyle.Fill;
            this.btn6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn6.Name = "btn6";
            this.btn6.Text = "6";

            this.btnSubtract.Dock = DockStyle.Fill;
            this.btnSubtract.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Text = "-";

            this.btn1.Dock = DockStyle.Fill;
            this.btn1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn1.Name = "btn1";
            this.btn1.Text = "1";

            this.btn2.Dock = DockStyle.Fill;
            this.btn2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn2.Name = "btn2";
            this.btn2.Text = "2";

            this.btn3.Dock = DockStyle.Fill;
            this.btn3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn3.Name = "btn3";
            this.btn3.Text = "3";

            this.btnAdd.Dock = DockStyle.Fill;
            this.btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+";

            this.btnToggleSign.Dock = DockStyle.Fill;
            this.btnToggleSign.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnToggleSign.Name = "btnToggleSign";
            this.btnToggleSign.Text = "+/-";

            this.btn0.Dock = DockStyle.Fill;
            this.btn0.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btn0.Name = "btn0";
            this.btn0.Text = "0";

            this.btnDecimal.Dock = DockStyle.Fill;
            this.btnDecimal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Text = ".";

            this.btnEquals.Dock = DockStyle.Fill;
            this.btnEquals.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Text = "=";

            // Add controls to table (col, row)
            this.tableLayoutPanelButtons.Controls.Add(btnClear, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(btnBackspace, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(btnPercent, 2, 0);
            this.tableLayoutPanelButtons.Controls.Add(btnDivide, 3, 0);

            this.tableLayoutPanelButtons.Controls.Add(btn7, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(btn8, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(btn9, 2, 1);
            this.tableLayoutPanelButtons.Controls.Add(btnMultiply, 3, 1);

            this.tableLayoutPanelButtons.Controls.Add(btn4, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(btn5, 1, 2);
            this.tableLayoutPanelButtons.Controls.Add(btn6, 2, 2);
            this.tableLayoutPanelButtons.Controls.Add(btnSubtract, 3, 2);

            this.tableLayoutPanelButtons.Controls.Add(btn1, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(btn2, 1, 3);
            this.tableLayoutPanelButtons.Controls.Add(btn3, 2, 3);
            this.tableLayoutPanelButtons.Controls.Add(btnAdd, 3, 3);

            this.tableLayoutPanelButtons.Controls.Add(btnToggleSign, 0, 4);
            this.tableLayoutPanelButtons.Controls.Add(btn0, 1, 4);
            this.tableLayoutPanelButtons.Controls.Add(btnDecimal, 2, 4);
            this.tableLayoutPanelButtons.Controls.Add(btnEquals, 3, 4);

            // Event wiring
            btnClear.Click += ClearButton_Click;
            btnBackspace.Click += BackspaceButton_Click;
            btnPercent.Click += PercentButton_Click;
            btnDivide.Click += OpButton_Click;

            btn7.Click += DigitButton_Click;
            btn8.Click += DigitButton_Click;
            btn9.Click += DigitButton_Click;
            btnMultiply.Click += OpButton_Click;

            btn4.Click += DigitButton_Click;
            btn5.Click += DigitButton_Click;
            btn6.Click += DigitButton_Click;
            btnSubtract.Click += OpButton_Click;

            btn1.Click += DigitButton_Click;
            btn2.Click += DigitButton_Click;
            btn3.Click += DigitButton_Click;
            btnAdd.Click += OpButton_Click;

            btnToggleSign.Click += ToggleSignButton_Click;
            btn0.Click += DigitButton_Click;
            btnDecimal.Click += DecimalButton_Click;
            btnEquals.Click += EqualsButton_Click;

            // Add controls to form
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.Controls.Add(this.textBoxDisplay);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}