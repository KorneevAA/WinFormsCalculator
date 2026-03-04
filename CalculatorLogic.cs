using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsCalculator
{
    internal class CalculatorLogic
    {
        private Operations _operations = new Operations();
        public double Calculate(double a, double b, string operationSymbol)
        {
            IOperation operation = _operations.GetOperation(operationSymbol);
            return operation.Calculate(a, b);
        }
    }
}
