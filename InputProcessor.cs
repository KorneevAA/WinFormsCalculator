using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsCalculator
{
    internal class InputProcessor : IInputProcessor
    {
        public string ProcessNumberInput(string currentInput, string newDigit)
        {
            if (currentInput == "" || currentInput == "0")
                return newDigit;
            else
                return currentInput + newDigit;
        }
        public string ProcessDecimalPoint(string currentInput)
        {
            if (currentInput == "Ошибка")
                return currentInput;
            else if (!currentInput.Contains(","))
                return currentInput + ",";
            else
                return currentInput;
        }
        public string ProcessChangeSign(string currentInput)
        {
            if (currentInput == "0" || currentInput == "Ошибка")
                return currentInput;
            else if (currentInput.StartsWith("-"))
                return currentInput.Substring(1);
            else
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
