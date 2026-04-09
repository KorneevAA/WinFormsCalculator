namespace WinFormsCalculator
{
    public class MemoryService
    {
        private Panel _memoryPanel;
        private List<MemoryItem> _memoryItems = new List<MemoryItem>();
        private Label _noMemoryLabel;
        private Button _memoryClear;
        public MemoryService(Panel memoryPanel, Button memoryClear)
        {
            _memoryPanel = memoryPanel;
            _noMemoryLabel = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "Память пуста",
                TextAlign = ContentAlignment.MiddleCenter
            };
            _memoryPanel.Controls.Add(_noMemoryLabel);
            _memoryClear = memoryClear;
            _memoryClear.Enabled = false;
        }

        public void MemorySave(double value)
        {
            if (_memoryPanel.Controls.Contains(_noMemoryLabel))
            {
                _memoryPanel.Controls.Remove(_noMemoryLabel);
                _memoryClear.Enabled = true;
            }
            MemoryItem memoryItem = new MemoryItem(value);
            var lastControl = _memoryPanel.GetLastControl();
            var groupBox = memoryItem.GetGroupBox(_memoryPanel.ClientSize.Width);
            if (lastControl == null)
            {
                memoryItem.RequestDelete += OnMemoryItemDeleteRequest;
                _memoryPanel.Controls.Add(groupBox);
                _memoryItems.Add(memoryItem);
                return;
            }
            groupBox.Location = new Point(groupBox.Location.X, lastControl.Location.Y + lastControl.Height + 3);
            memoryItem.RequestDelete += OnMemoryItemDeleteRequest;
            _memoryPanel.Controls.Add(groupBox);
            _memoryItems.Add(memoryItem);
            
        }
        private void OnMemoryItemDeleteRequest(object sender, Guid guid)
        {
            DeleteMemoryItem(guid);
        }
        public void DeleteMemoryItem(Guid guid)
        {
            var memoryItem = _memoryItems.FirstOrDefault(item => item.Guid == guid);
            int index = _memoryItems.IndexOf(memoryItem);
            _memoryItems.RemoveAt(index);
            _memoryPanel.Controls.RemoveAt(index);
            RefreshMemoryItemsPosition();
            if (_memoryItems.Count == 0 && !_memoryPanel.Controls.Contains(_noMemoryLabel))
            {
                _memoryPanel.Controls.Add(_noMemoryLabel);
                _noMemoryLabel.Dock = DockStyle.Fill;
                _memoryClear.Enabled = false;
            }
        }
        public void MemoryClear()
        {
            _memoryItems.Clear();
            _memoryPanel.Controls.Clear();
            _memoryPanel.Controls.Add(_noMemoryLabel);
            _memoryClear.Enabled = false;
        }
        private void RefreshMemoryItemsPosition()
        {
            int currentY = 0;

            foreach (Control control in _memoryPanel.Controls)
            {
                control.Location = new Point(control.Location.X, currentY);
                currentY += control.Height + 3;
            }

            _memoryPanel.Refresh();
        }

    }
}