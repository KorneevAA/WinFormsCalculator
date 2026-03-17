using System;

namespace WinFormsCalculator
{
    internal class CalculatorModel
    {
        public double CurrentValue { get; set; }
        public double LastValue { get; set; }
        public OperationType CurrentOperation { get; set; }

        public void Reset()
        {
            CurrentValue = 0;
            LastValue = 0;
            CurrentOperation = OperationType.None;
        }
    }
}

