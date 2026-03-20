using System;

namespace WinFormsCalculator
{
    internal class MemoryService : IMemoryService
    {
        public double Memory { get; private set; }

        public List<string> MemoryHistory { get; private set; } = new List<string>();

        public void MemoryAdd(double value) => Memory += value;

        public void MemorySubtract(double value) => Memory -= value;

        public void MemorySave(double value) => Memory = value;

        public void MemoryClear() => Memory = 0;
    }
}
