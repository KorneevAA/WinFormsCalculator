using System;

namespace WinFormsCalculator
{
    public sealed class AdditionOperation : IOperation
    {
        public double Calculate(double a, double b) => a + b;
        public OperationType OperationType => OperationType.Addition;
    }

    public sealed class SubtractionOperation : IOperation
    {
        public double Calculate(double a, double b) => a - b;
        public OperationType OperationType => OperationType.Subtraction;
    }

    public sealed class MultiplicationOperation : IOperation
    {
        public double Calculate(double a, double b) => a * b;
        public OperationType OperationType => OperationType.Multiplication;
    }

    public sealed class DivisionOperation : IOperation
    {
        public double Calculate(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль");

            return a / b;
        }
        public OperationType OperationType => OperationType.Division;
    }

    public class OperationFactory
    {
        public IOperation GetOperation(OperationType operationType)
        {
            return operationType switch
            {
                OperationType.Addition => new AdditionOperation(),
                OperationType.Subtraction => new SubtractionOperation(),
                OperationType.Multiplication => new MultiplicationOperation(),
                OperationType.Division => new DivisionOperation(),
                _ => throw new ArgumentException($"Неизвестная операция: {operationType}")
            };
        }
    }
}
