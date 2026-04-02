using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Swift;
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
        public void AddToHistroy(Panel panel)
        {
            var groupBox = new GroupBox()
            {
                Size = new Size(panel.ClientSize.Width, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Right,
            };
            var operationSymbol = OperationFactory.GetOperationSymbol(OperationType);
            var lblEx1 = new Label()
            {
                Size = new Size(groupBox.Size.Width, groupBox.Size.Height),
                Text = $"{LastValue} {operationSymbol} {CurrentValue} = {Result}",
                Dock = DockStyle.Right,
                TextAlign = ContentAlignment.MiddleRight,
            };
            groupBox.Controls.Add(lblEx1);
            var lastControl = panel.GetLastControl();
            if (lastControl == null)
            {
                panel.Controls.Add(groupBox);
                return;
            }
            groupBox.Location = new Point(groupBox.Location.X, lastControl.Location.Y + lastControl.Height);
            panel.Controls.Add(groupBox);
        }
    }
}
