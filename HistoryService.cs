using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsCalculator
{
    public class HistoryService
    {
        private Panel _historyPanel;
        private Label _noHistoryLabel;
        private List<HistoryItem> _historyItems = new List<HistoryItem>();
        private Button _historyClear;
        public HistoryService(Panel historyPanel, Button historyClear)
        {
            _historyPanel = historyPanel;
            _historyClear = historyClear;
            _historyClear.Enabled = false;
            _noHistoryLabel = new Label()
            {
                Dock = DockStyle.Fill,
                Text = "История пуста",
                TextAlign = ContentAlignment.MiddleCenter
            };
            _historyPanel.Controls.Add(_noHistoryLabel);
        }

        public void HistorySave(double lastValue, OperationType operationType, double currentValue, double result)
        {
            if (_historyPanel.Controls.Contains(_noHistoryLabel))
            {
                _historyClear.Enabled = true;
                _historyPanel.Controls.Remove(_noHistoryLabel);
            }
            HistoryItem historyItem = new HistoryItem(lastValue, operationType, currentValue, result);
            
            var lastControl = _historyPanel.GetLastControl();
            var groupBox = historyItem.GetGroupBox(_historyPanel.ClientSize.Width);
            if (lastControl == null)
            {
                _historyItems.Add(historyItem);
                _historyPanel.Controls.Add(groupBox);
                return;
            }
            groupBox.Location = new Point(groupBox.Location.X, lastControl.Location.Y + lastControl.Height);
            _historyPanel.Controls.Add(groupBox);

        }
        public void HistoryClear()
        {
            _historyItems.Clear();
            _historyPanel.Controls.Clear();
            _historyPanel.Controls.Add(_noHistoryLabel);
            _historyClear.Enabled = false;
        }
    }
}
