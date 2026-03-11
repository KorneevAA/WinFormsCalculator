using System;
using System.Globalization;

namespace WinFormsCalculator
{
    internal class DisplayFormatter
    {
        public string FormatNumber(double number)
        {
            if (double.IsNaN(number) || double.IsInfinity(number))
                return "Ошибка";

            return number.ToString();
        }

        public double ParseInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input == "Ошибка")
                return 0;

            if (!double.TryParse(input, out double result))
                throw new FormatException("Неверный формат числа");

            return result;
        }
    }
}

