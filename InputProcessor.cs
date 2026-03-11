using System;

namespace WinFormsCalculator
{
    internal class InputProcessor : IInputProcessor
    {
        public string ProcessNumberInput(string currentInput, string newDigit)
        {
            if (string.IsNullOrEmpty(currentInput) || currentInput == "0")
                return newDigit;

            return currentInput + newDigit;
        }

        public string ProcessDecimalPoint(string currentInput)
        {
            if (currentInput == "Ошибка" || currentInput.Contains(","))
                return currentInput;

            return currentInput + ",";
        }

        public string ProcessChangeSign(string currentInput)
        {
            if (currentInput == "0" || currentInput == "Ошибка")
                return currentInput;

            if (currentInput.StartsWith("-"))
                return currentInput.Substring(1);

            return "-" + currentInput;
        }

        public string ProcessBackspace(string currentInput)
        {
            if (currentInput == "Ошибка" || currentInput.Length <= 1)
                return "0";

            if (currentInput.Length == 2 && currentInput.StartsWith("-"))
                return "0";

            return currentInput.Substring(0, currentInput.Length - 1);
        }
    }
}
