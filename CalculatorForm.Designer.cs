using System.Xml.Linq;

namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubstraction = new Button();
            btnAddition = new Button();
            btnDivision = new Button();
            btnMultiplication = new Button();
            btnBackspace = new Button();
            btnClear = new Button();
            btnClearEntry = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            lblLastNumber = new Label();
            lblCurrentNumber = new TextBox();
            btnSqrt = new Button();
            btnSquare = new Button();
            btnReverseX = new Button();
            btnPercent = new Button();
            lblMemoryNumber = new Label();
            btnMemorySave = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            menuStrip1 = new MenuStrip();
            историяToolStripMenuItem = new ToolStripMenuItem();
            показатьToolStripMenuItem = new ToolStripMenuItem();
            спрятатьToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAnswer = new Button();
            btnDot = new Button();
            btnZero = new Button();
            btnChangeSign = new Button();
            tabControl1 = new TabControl();
            tpHistoryPage = new TabPage();
            panel1 = new Panel();
            btn_ClearHistory = new Button();
            tpMemoryPage = new TabPage();
            btnMemoryClear = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpHistoryPage.SuspendLayout();
            tpMemoryPage.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubstraction
            // 
            btnSubstraction.Dock = DockStyle.Fill;
            btnSubstraction.Location = new Point(192, 216);
            btnSubstraction.Margin = new Padding(0);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(67, 54);
            btnSubstraction.TabIndex = 1;
            btnSubstraction.Text = "-";
            btnSubstraction.UseVisualStyleBackColor = true;
            btnSubstraction.Click += btnSubstraction_Click;
            // 
            // btnAddition
            // 
            btnAddition.Dock = DockStyle.Fill;
            btnAddition.Location = new Point(192, 270);
            btnAddition.Margin = new Padding(0);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(67, 54);
            btnAddition.TabIndex = 2;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnDivision
            // 
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Location = new Point(192, 108);
            btnDivision.Margin = new Padding(0);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(67, 54);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Dock = DockStyle.Fill;
            btnMultiplication.Location = new Point(192, 162);
            btnMultiplication.Margin = new Padding(0);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(67, 54);
            btnMultiplication.TabIndex = 4;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Location = new Point(192, 54);
            btnBackspace.Margin = new Padding(0);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(67, 54);
            btnBackspace.TabIndex = 5;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(128, 54);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(64, 54);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Dock = DockStyle.Fill;
            btnClearEntry.Location = new Point(64, 54);
            btnClearEntry.Margin = new Padding(0);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(64, 54);
            btnClearEntry.TabIndex = 7;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnNine
            // 
            btnNine.Dock = DockStyle.Fill;
            btnNine.Location = new Point(128, 162);
            btnNine.Margin = new Padding(0);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(64, 54);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.Dock = DockStyle.Fill;
            btnEight.Location = new Point(64, 162);
            btnEight.Margin = new Padding(0);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(64, 54);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.Location = new Point(0, 162);
            btnSeven.Margin = new Padding(0);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(64, 54);
            btnSeven.TabIndex = 10;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnSix
            // 
            btnSix.Dock = DockStyle.Fill;
            btnSix.Location = new Point(128, 216);
            btnSix.Margin = new Padding(0);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(64, 54);
            btnSix.TabIndex = 11;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.Dock = DockStyle.Fill;
            btnFive.Location = new Point(64, 216);
            btnFive.Margin = new Padding(0);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(64, 54);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.Dock = DockStyle.Fill;
            btnFour.Location = new Point(0, 216);
            btnFour.Margin = new Padding(0);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(64, 54);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnThree
            // 
            btnThree.Dock = DockStyle.Fill;
            btnThree.Location = new Point(128, 270);
            btnThree.Margin = new Padding(0);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(64, 54);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.Location = new Point(64, 270);
            btnTwo.Margin = new Padding(0);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(64, 54);
            btnTwo.TabIndex = 15;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.Dock = DockStyle.Fill;
            btnOne.Location = new Point(0, 270);
            btnOne.Margin = new Padding(0);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(64, 54);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // lblLastNumber
            // 
            lblLastNumber.AutoSize = true;
            lblLastNumber.Location = new Point(12, 24);
            lblLastNumber.Name = "lblLastNumber";
            lblLastNumber.Size = new Size(13, 15);
            lblLastNumber.TabIndex = 21;
            lblLastNumber.Text = "0";
            // 
            // lblCurrentNumber
            // 
            lblCurrentNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCurrentNumber.BackColor = SystemColors.Control;
            lblCurrentNumber.BorderStyle = BorderStyle.None;
            lblCurrentNumber.Font = new Font("Segoe UI", 14F);
            lblCurrentNumber.Location = new Point(74, 45);
            lblCurrentNumber.Name = "lblCurrentNumber";
            lblCurrentNumber.Size = new Size(174, 25);
            lblCurrentNumber.TabIndex = 23;
            lblCurrentNumber.Text = "0";
            lblCurrentNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSqrt
            // 
            btnSqrt.Dock = DockStyle.Fill;
            btnSqrt.Location = new Point(128, 108);
            btnSqrt.Margin = new Padding(0);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(64, 54);
            btnSqrt.TabIndex = 25;
            btnSqrt.Text = "sqrt()";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnSquare
            // 
            btnSquare.Dock = DockStyle.Fill;
            btnSquare.Location = new Point(64, 108);
            btnSquare.Margin = new Padding(0);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(64, 54);
            btnSquare.TabIndex = 26;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnReverseX
            // 
            btnReverseX.Dock = DockStyle.Fill;
            btnReverseX.Location = new Point(0, 108);
            btnReverseX.Margin = new Padding(0);
            btnReverseX.Name = "btnReverseX";
            btnReverseX.Size = new Size(64, 54);
            btnReverseX.TabIndex = 27;
            btnReverseX.Text = "1/x";
            btnReverseX.UseVisualStyleBackColor = true;
            btnReverseX.Click += btnReverseX_Click;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Location = new Point(0, 54);
            btnPercent.Margin = new Padding(0);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(64, 54);
            btnPercent.TabIndex = 28;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // lblMemoryNumber
            // 
            lblMemoryNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMemoryNumber.AutoSize = true;
            lblMemoryNumber.Location = new Point(214, 28);
            lblMemoryNumber.Name = "lblMemoryNumber";
            lblMemoryNumber.Size = new Size(13, 15);
            lblMemoryNumber.TabIndex = 29;
            lblMemoryNumber.Text = "0";
            lblMemoryNumber.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Dock = DockStyle.Left;
            btnMemorySave.Location = new Point(3, 376);
            btnMemorySave.Margin = new Padding(0);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(67, 54);
            btnMemorySave.TabIndex = 32;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Panel2MinSize = 0;
            splitContainer1.Size = new Size(670, 461);
            splitContainer1.SplitterDistance = 259;
            splitContainer1.TabIndex = 34;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lblLastNumber);
            splitContainer2.Panel1.Controls.Add(lblCurrentNumber);
            splitContainer2.Panel1.Controls.Add(lblMemoryNumber);
            splitContainer2.Panel1.Controls.Add(menuStrip1);
            splitContainer2.Panel1MinSize = 0;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Panel2MinSize = 0;
            splitContainer2.Size = new Size(259, 461);
            splitContainer2.SplitterDistance = 78;
            splitContainer2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { историяToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(259, 24);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // историяToolStripMenuItem
            // 
            историяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатьToolStripMenuItem, спрятатьToolStripMenuItem });
            историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            историяToolStripMenuItem.Size = new Size(66, 20);
            историяToolStripMenuItem.Text = "История";
            // 
            // показатьToolStripMenuItem
            // 
            показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            показатьToolStripMenuItem.Size = new Size(124, 22);
            показатьToolStripMenuItem.Text = "Показать";
            показатьToolStripMenuItem.Click += показатьToolStripMenuItem_Click;
            // 
            // спрятатьToolStripMenuItem
            // 
            спрятатьToolStripMenuItem.Name = "спрятатьToolStripMenuItem";
            спрятатьToolStripMenuItem.Size = new Size(124, 22);
            спрятатьToolStripMenuItem.Text = "Спрятать";
            спрятатьToolStripMenuItem.Click += спрятатьToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnPercent, 0, 1);
            tableLayoutPanel1.Controls.Add(btnClearEntry, 1, 1);
            tableLayoutPanel1.Controls.Add(btnAnswer, 3, 6);
            tableLayoutPanel1.Controls.Add(btnDot, 2, 6);
            tableLayoutPanel1.Controls.Add(btnZero, 1, 6);
            tableLayoutPanel1.Controls.Add(btnChangeSign, 0, 6);
            tableLayoutPanel1.Controls.Add(btnSqrt, 2, 2);
            tableLayoutPanel1.Controls.Add(btnTwo, 1, 5);
            tableLayoutPanel1.Controls.Add(btnAddition, 3, 5);
            tableLayoutPanel1.Controls.Add(btnOne, 0, 5);
            tableLayoutPanel1.Controls.Add(btnFour, 0, 4);
            tableLayoutPanel1.Controls.Add(btnThree, 2, 5);
            tableLayoutPanel1.Controls.Add(btnReverseX, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSquare, 1, 2);
            tableLayoutPanel1.Controls.Add(btnFive, 1, 4);
            tableLayoutPanel1.Controls.Add(btnSix, 2, 4);
            tableLayoutPanel1.Controls.Add(btnSubstraction, 3, 4);
            tableLayoutPanel1.Controls.Add(btnMultiplication, 3, 3);
            tableLayoutPanel1.Controls.Add(btnSeven, 0, 3);
            tableLayoutPanel1.Controls.Add(btnNine, 2, 3);
            tableLayoutPanel1.Controls.Add(btnClear, 2, 1);
            tableLayoutPanel1.Controls.Add(btnDivision, 3, 2);
            tableLayoutPanel1.Controls.Add(btnEight, 1, 3);
            tableLayoutPanel1.Controls.Add(btnBackspace, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(259, 379);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAnswer
            // 
            btnAnswer.Dock = DockStyle.Fill;
            btnAnswer.Location = new Point(192, 324);
            btnAnswer.Margin = new Padding(0);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(67, 55);
            btnAnswer.TabIndex = 0;
            btnAnswer.Text = "=";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.Location = new Point(128, 324);
            btnDot.Margin = new Padding(0);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(64, 55);
            btnDot.TabIndex = 17;
            btnDot.Text = ",";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnZero
            // 
            btnZero.Dock = DockStyle.Fill;
            btnZero.Location = new Point(64, 324);
            btnZero.Margin = new Padding(0);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(64, 55);
            btnZero.TabIndex = 18;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnChangeSign
            // 
            btnChangeSign.Dock = DockStyle.Fill;
            btnChangeSign.Location = new Point(0, 324);
            btnChangeSign.Margin = new Padding(0);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Size = new Size(64, 55);
            btnChangeSign.TabIndex = 19;
            btnChangeSign.Text = "+/-";
            btnChangeSign.UseVisualStyleBackColor = true;
            btnChangeSign.Click += btnChangeSign_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpHistoryPage);
            tabControl1.Controls.Add(tpMemoryPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(407, 461);
            tabControl1.TabIndex = 1;
            // 
            // tpHistoryPage
            // 
            tpHistoryPage.Controls.Add(panel1);
            tpHistoryPage.Controls.Add(btn_ClearHistory);
            tpHistoryPage.Location = new Point(4, 24);
            tpHistoryPage.Name = "tpHistoryPage";
            tpHistoryPage.Padding = new Padding(3);
            tpHistoryPage.Size = new Size(399, 433);
            tpHistoryPage.TabIndex = 0;
            tpHistoryPage.Text = "History";
            tpHistoryPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 388);
            panel1.TabIndex = 1;
            // 
            // btn_ClearHistory
            // 
            btn_ClearHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ClearHistory.Location = new Point(298, 397);
            btn_ClearHistory.Name = "btn_ClearHistory";
            btn_ClearHistory.Size = new Size(98, 33);
            btn_ClearHistory.TabIndex = 0;
            btn_ClearHistory.Text = "CH";
            btn_ClearHistory.UseVisualStyleBackColor = true;
            btn_ClearHistory.Click += btn_ClearHistory_Click;
            // 
            // tpMemoryPage
            // 
            tpMemoryPage.Controls.Add(btnMemoryClear);
            tpMemoryPage.Controls.Add(btnMemorySave);
            tpMemoryPage.Controls.Add(panel2);
            tpMemoryPage.Location = new Point(4, 24);
            tpMemoryPage.Name = "tpMemoryPage";
            tpMemoryPage.Padding = new Padding(3);
            tpMemoryPage.Size = new Size(399, 433);
            tpMemoryPage.TabIndex = 1;
            tpMemoryPage.Text = "Memory";
            tpMemoryPage.UseVisualStyleBackColor = true;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Dock = DockStyle.Right;
            btnMemoryClear.Location = new Point(329, 376);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(67, 54);
            btnMemoryClear.TabIndex = 1;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 373);
            panel2.TabIndex = 0;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(670, 461);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(300, 300);
            Name = "CalculatorForm";
            Text = "Калькулятор";
            Resize += CalculatorForm_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tpHistoryPage.ResumeLayout(false);
            tpMemoryPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSubstraction;
        private Button btnAddition;
        private Button btnDivision;
        private Button btnMultiplication;
        private Button btnBackspace;
        private Button btnClear;
        private Button btnClearEntry;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Label lblLastNumber;
        private TextBox lblCurrentNumber;
        private Button btnSqrt;
        private Button btnSquare;
        private Button btnReverseX;
        private Button btnPercent;
        private Label lblMemoryNumber;
        private Button btnMemorySave;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem историяToolStripMenuItem;
        private ToolStripMenuItem показатьToolStripMenuItem;
        private ToolStripMenuItem спрятатьToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tpHistoryPage;
        private TabPage tpMemoryPage;
        private Button btn_ClearHistory;
        private Panel panel1;
        private Panel panel2;
        private Button btnMemoryClear;
        private Button btnAnswer;
        private Button btnDot;
        private Button btnZero;
        private Button btnChangeSign;
    }
}
