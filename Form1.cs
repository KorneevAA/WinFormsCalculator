using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private Control? GetLastControl(Panel panel)
        {
            if (panel.Controls.Count == 0)
                return null;
            return panel.Controls[panel.Controls.Count - 1];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var groupBox = new GroupBox() { Size = new Size(320, 50)};
            var lblEx1 = new Label() { Text = "12345"};
            var lblEx2 = new Label() { Text = "54321"};
            groupBox.Controls.Add(lblEx1);
            groupBox.Controls.Add(lblEx2);
            var lastControl = GetLastControl(panel1);
            if (lastControl == null) 
            {
                panel1.Controls.Add(groupBox);
                return;
            }
            groupBox.Location = new Point(groupBox.Location.X, lastControl.Location.Y + lastControl.Height);
            panel1.Controls.Add(groupBox);
        }
    }
}
