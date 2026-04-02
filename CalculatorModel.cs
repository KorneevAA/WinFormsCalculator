using System;

namespace WinFormsCalculator
{
    internal static class CalculatorModel
    {
        public static double CurrentValue { get; set; }
        public  static double LastValue { get; set; }
        public static OperationType CurrentOperation { get; set; }

        public static void Reset()
        {
            CurrentValue = 0;
            LastValue = 0;
            CurrentOperation = OperationType.None;
        }
    }
}

