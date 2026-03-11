using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsCalculator
{
    internal interface IMemoryService
    {
        void MemoryAdd(double value);
        void MemorySubtract(double value);
        void MemorySave(double value);
        void MemoryClear();
        double Memory { get; }
    }
}
