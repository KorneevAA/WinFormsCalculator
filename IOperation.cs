using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsCalculator
{
    public interface IOperation
    {
        double Calculate(double a, double b);
        OperationType OperationType { get; }
    }
}
