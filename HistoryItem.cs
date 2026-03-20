using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WinFormsCalculator
{
    internal class HistoryItem
    {
        public string CurrentValue { get; set; }
        public OperationType OperationType { get; set; }
        public string LastValue { get; set; }
        public string Result { get; set; }
        public HistoryItem(double lastValue, OperationType operationType, double currentValue, double result)
        {
            CurrentValue = currentValue.ToString();
            LastValue = lastValue.ToString();
            OperationType = operationType;
            Result = result.ToString();
        }
        public override string ToString()
        {
            var operationSymbol = OperationType switch
            {
                OperationType.Addition => "+",
                OperationType.Subtraction => "-",
                OperationType.Division => "/",
                OperationType.Multiplication => "*",
                _ => ""
            };
            return $"{LastValue} {operationSymbol} {CurrentValue} = {Result}";
        }
    }
}
