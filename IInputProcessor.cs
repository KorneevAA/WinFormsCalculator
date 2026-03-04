using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsCalculator
{
    internal interface IInputProcessor
    {
        string ProcessDecimalPoint(string currentInput);
        string ProcessNumberInput(string currentInput, string newDigit);
        string ProcessChangeSign(string currentInput);
        string ProcessBackspace(string currentInput);
    }
}
