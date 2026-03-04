using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WinFormsCalculator
{
    public sealed class AdditionOperation : IOperation
    {
        public string Operation { get; } = "+";
        public double Calculate(double a, double b)
        {
            return a + b; 
        }
    }
    public sealed class SubstractionOperation : IOperation
    {
        public string Operation { get; } = "-";
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
    public sealed class MultiplicationOperation : IOperation
    {
        public string Operation { get; } = "*";
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
    public sealed class DivisionOperation : IOperation
    {
        public string Operation { get; } = "/";
        public double Calculate(double a, double b)
        {
            if (b == 0)
                return 0;
            return a / b;
        }
    }
    public class Operations
    {
        private readonly Dictionary<string, IOperation> _operations;
        public Operations()
        {
            _operations = new Dictionary<string, IOperation>
            {
                { "+", new AdditionOperation() },
                { "-", new SubstractionOperation() },
                { "*", new MultiplicationOperation() },
                { "/", new DivisionOperation() }
            };
        }
        public IOperation GetOperation(string operation)
        {
            if (operation.Contains(operation))
                return _operations[operation];
            throw new ArgumentException("Operation not found");
        }
    }
}
