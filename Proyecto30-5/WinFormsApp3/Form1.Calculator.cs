using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1
    {
        private readonly Calculator calc = new Calculator();

        private void UpdateDisplay()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateDisplay));
                return;
            }
            textBoxDisplay.Text = calc.Display;
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (sender is Button b) calc.InputDigit(b.Text);
            UpdateDisplay();
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            calc.InputDigit(".");
            UpdateDisplay();
        }

        private void OpButton_Click(object sender, EventArgs e)
        {
            if (sender is Button b) calc.SetOperator(b.Text);
            UpdateDisplay();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            calc.Compute();
            UpdateDisplay();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            calc.Clear();
            UpdateDisplay();
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            calc.InputBackspace();
            UpdateDisplay();
        }

        private void ToggleSignButton_Click(object sender, EventArgs e)
        {
            calc.ToggleSign();
            UpdateDisplay();
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            calc.Percent();
            UpdateDisplay();
        }
    }
}