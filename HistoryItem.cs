namespace WinFormsCalculator
{
    public class HistoryItem
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
        public GroupBox GetGroupBox(int panelSize)
        {
            var groupBox = new GroupBox()
            {
                Size = new Size(panelSize, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Right
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
            groupBox.MouseEnter += (_, __) =>
            {
                groupBox.BackColor = Color.LightGray;
            };
            groupBox.MouseLeave += (_, __) =>
            {
                if (!groupBox.ClientRectangle.Contains(groupBox.PointToClient(Cursor.Position)))
                {
                    groupBox.BackColor = Color.Transparent;
                }
            };
            lblEx1.MouseLeave += (_, __) =>
            {
                if (!groupBox.ClientRectangle.Contains(groupBox.PointToClient(Cursor.Position)))
                {
                    groupBox.BackColor = Color.Transparent;
                }
            };
            return groupBox;
        }
    }
}
