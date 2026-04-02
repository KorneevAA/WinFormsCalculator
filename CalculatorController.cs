using System;

namespace WinFormsCalculator
{
    internal class CalculatorController
    {

        public double Calculate(double a, double b, OperationType operationType)
        {
            var operation = OperationFactory.GetOperation(operationType);
            double result = operation.Calculate(a, b);
            return result;
        }

        public double CalculateUnary(double value, OperationType operationType)
        {
            double result = operationType switch
            {
                OperationType.Percent => value / 100,
                OperationType.SquareRoot => CalculateSquareRoot(value),
                OperationType.Square => value * value,
                OperationType.Reciprocal => CalculateReciprocal(value),
                _ => throw new ArgumentException($"Неподдерживаемая операция: {operationType}")
            };

            return result;
        }

        private double CalculateSquareRoot(double value)
        {
            if (value < 0)
                throw new InvalidOperationException("Невозможно извлечь корень из отрицательного числа");

            return Math.Sqrt(value);
        }

        private double CalculateReciprocal(double value)
        {
            if (value == 0)
                throw new DivideByZeroException("Деление на ноль");

            return 1 / value;
        }
    }
}

