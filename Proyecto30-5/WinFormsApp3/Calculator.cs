using System;
using System.Globalization;

namespace WinFormsApp3
{
    public class Calculator
    {
        public string Display { get; private set; } = "0";
        private double? leftOperand;
        private string? op;
        private bool newInput = true;

        public void InputDigit(string digit)
        {
            if (string.IsNullOrEmpty(digit)) return;

            if (newInput)
            {
                Display = digit == "." ? "0." : digit;
                newInput = false;
                return;
            }

            if (digit == ".")
            {
                if (Display.Contains(".")) return;
                Display += ".";
            }
            else
            {
                Display = Display == "0" ? digit : Display + digit;
            }
        }

        public void InputBackspace()
        {
            if (newInput) return;
            if (Display.Length <= 1)
            {
                Display = "0";
                newInput = true;
                return;
            }
            Display = Display[..^1];
        }

        public void Clear()
        {
            Display = "0";
            leftOperand = null;
            op = null;
            newInput = true;
        }

        public void SetOperator(string operatorSymbol)
        {
            if (!double.TryParse(Display, NumberStyles.Float, CultureInfo.InvariantCulture, out double current))
                return;

            if (leftOperand is null)
            {
                leftOperand = current;
            }
            else if (!newInput)
            {
                leftOperand = EvaluateInternal(leftOperand.Value, op, current);
                Display = leftOperand.Value.ToString(CultureInfo.InvariantCulture);
            }

            op = operatorSymbol;
            newInput = true;
        }

        public void ToggleSign()
        {
            if (Display == "0") return;
            if (Display.StartsWith("-")) Display = Display[1..];
            else Display = "-" + Display;
        }

        public void Percent()
        {
            if (!double.TryParse(Display, NumberStyles.Float, CultureInfo.InvariantCulture, out double current)) return;
            current /= 100.0;
            Display = current.ToString(CultureInfo.InvariantCulture);
            newInput = true;
        }

        public void Compute()
        {
            if (leftOperand is null || op is null) return;
            if (!double.TryParse(Display, NumberStyles.Float, CultureInfo.InvariantCulture, out double right)) return;

            double result = EvaluateInternal(leftOperand.Value, op, right);
            Display = result.ToString(CultureInfo.InvariantCulture);
            leftOperand = null;
            op = null;
            newInput = true;
        }

        private static double EvaluateInternal(double left, string? operatorSymbol, double right)
        {
            if (operatorSymbol is null) return right;
            return operatorSymbol switch
            {
                "+" => left + right,
                "-" => left - right,
                "*" or "×" => left * right,
                "/" or "÷" => right == 0 ? double.NaN : left / right,
                "^" => Math.Pow(left, right),
                _ => right,
            };
        }
    }
}