namespace WinFormsCalculator
{
    public class MemoryItem
    {
        private double _memoryValue;
        public Guid Guid { get; set; }
        public event EventHandler<Guid> RequestDelete;

        public MemoryItem(double value)
        {
            _memoryValue = value;
            Guid = Guid.NewGuid();
        }
        public Panel GetGroupBox(int panelSize)
        {
            var groupBox = new Panel()
            {
                Size = new Size(panelSize, 60),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3, 3, 3, 3)
            };

            var valueLabel = new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                Text = _memoryValue.ToString()
            };

            var actionsPanel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Bottom,
                Height = 25,
                Visible = false
            };

            var btnMC = new Button() { Text = "MC", Width = 40, Height = 20 };
            var btnMMinus = new Button() { Text = "M-", Width = 40, Height = 20 };
            var btnMPlus = new Button() { Text = "M+", Width = 40, Height = 20 };

            btnMC.Click += (_, __) =>
            {
                RequestDelete.Invoke(this, this.Guid);
            };

            btnMPlus.Click += (_, __) =>
            {
                _memoryValue += CalculatorModel.CurrentValue;
                valueLabel.Text = _memoryValue.ToString();
            };

            btnMMinus.Click += (_, __) =>
            {
                _memoryValue -= CalculatorModel.CurrentValue;
                valueLabel.Text = _memoryValue.ToString();
            };

            actionsPanel.Controls.Add(btnMC);
            actionsPanel.Controls.Add(btnMMinus);
            actionsPanel.Controls.Add(btnMPlus);

            groupBox.Controls.Add(valueLabel);
            groupBox.Controls.Add(actionsPanel);

            groupBox.MouseEnter += (_, __) =>
            {
                groupBox.BackColor = Color.LightGray;
                actionsPanel.Visible = true;
            };

            groupBox.MouseLeave += (_, __) =>
            {
                if (!groupBox.ClientRectangle.Contains(groupBox.PointToClient(Cursor.Position)))
                {
                    actionsPanel.Visible = false;
                    groupBox.BackColor = Color.Transparent;
                }
            };

            foreach (Control control in groupBox.Controls)
            {
                control.MouseEnter += (_, __) =>
                {
                    actionsPanel.Visible = true;
                };
                control.MouseLeave += (_, __) =>
                {
                    if (!groupBox.ClientRectangle.Contains(groupBox.PointToClient(Cursor.Position)))
                    {
                        actionsPanel.Visible = false;
                        groupBox.BackColor = Color.Transparent;
                    }
                };
            }

            foreach (Control control in actionsPanel.Controls)
            {
                control.MouseEnter += (_, __) =>
                {
                    groupBox.BackColor = Color.LightGray;
                    actionsPanel.Visible = true;
                };
                control.MouseLeave += (_, __) =>
                {
                    if (!groupBox.ClientRectangle.Contains(groupBox.PointToClient(Cursor.Position)))
                    {
                        actionsPanel.Visible = false;
                        groupBox.BackColor = Color.Transparent;
                    }
                };
            }
            return groupBox;
        }
    }
}