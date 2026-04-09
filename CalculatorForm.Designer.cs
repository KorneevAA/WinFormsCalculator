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
            btnBackspace = new Button();
            btnClear = new Button();
            btnClearEntry = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            lblLastNumber = new Label();
            lblCurrentNumber = new TextBox();
            btnSqrt = new Button();
            btnSquare = new Button();
            btnReverseX = new Button();
            btnPercent = new Button();
            btnMemorySave = new Button();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAnswer = new Button();
            btnDot = new Button();
            btnZero = new Button();
            btnChangeSign = new Button();
            btnThree = new Button();
            btnMultiplication = new Button();
            btnSeven = new Button();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tpHistoryPage = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            btn_ClearHistory = new Button();
            tpMemoryPage = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnMemoryClear = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tpHistoryPage.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tpMemoryPage.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubstraction
            // 
            btnSubstraction.Dock = DockStyle.Fill;
            btnSubstraction.Location = new Point(189, 180);
            btnSubstraction.Margin = new Padding(0);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(64, 60);
            btnSubstraction.TabIndex = 1;
            btnSubstraction.Text = "-";
            btnSubstraction.UseVisualStyleBackColor = true;
            btnSubstraction.Click += btnSubstraction_Click;
            // 
            // btnAddition
            // 
            btnAddition.Dock = DockStyle.Fill;
            btnAddition.Location = new Point(189, 240);
            btnAddition.Margin = new Padding(0);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(64, 60);
            btnAddition.TabIndex = 2;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnDivision
            // 
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Location = new Point(189, 60);
            btnDivision.Margin = new Padding(0);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(64, 60);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Location = new Point(189, 0);
            btnBackspace.Margin = new Padding(0);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(64, 60);
            btnBackspace.TabIndex = 5;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(126, 0);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(63, 60);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Dock = DockStyle.Fill;
            btnClearEntry.Location = new Point(63, 0);
            btnClearEntry.Margin = new Padding(0);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(63, 60);
            btnClearEntry.TabIndex = 7;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnNine
            // 
            btnNine.Dock = DockStyle.Fill;
            btnNine.Location = new Point(126, 120);
            btnNine.Margin = new Padding(0);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(63, 60);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.Dock = DockStyle.Fill;
            btnEight.Location = new Point(63, 120);
            btnEight.Margin = new Padding(0);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(63, 60);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSix
            // 
            btnSix.Dock = DockStyle.Fill;
            btnSix.Location = new Point(126, 180);
            btnSix.Margin = new Padding(0);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(63, 60);
            btnSix.TabIndex = 11;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.Dock = DockStyle.Fill;
            btnFive.Location = new Point(63, 180);
            btnFive.Margin = new Padding(0);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(63, 60);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.Dock = DockStyle.Fill;
            btnFour.Location = new Point(0, 180);
            btnFour.Margin = new Padding(0);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(63, 60);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnTwo
            // 
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.Location = new Point(63, 240);
            btnTwo.Margin = new Padding(0);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(63, 60);
            btnTwo.TabIndex = 15;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.Dock = DockStyle.Fill;
            btnOne.Location = new Point(0, 240);
            btnOne.Margin = new Padding(0);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(63, 60);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // lblLastNumber
            // 
            lblLastNumber.AutoSize = true;
            lblLastNumber.Location = new Point(9, 6);
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
            lblCurrentNumber.Location = new Point(76, 58);
            lblCurrentNumber.Name = "lblCurrentNumber";
            lblCurrentNumber.Size = new Size(174, 25);
            lblCurrentNumber.TabIndex = 23;
            lblCurrentNumber.Text = "0";
            lblCurrentNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSqrt
            // 
            btnSqrt.Dock = DockStyle.Fill;
            btnSqrt.Location = new Point(126, 60);
            btnSqrt.Margin = new Padding(0);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(63, 60);
            btnSqrt.TabIndex = 25;
            btnSqrt.Text = "sqrt()";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnSquare
            // 
            btnSquare.Dock = DockStyle.Fill;
            btnSquare.Location = new Point(63, 60);
            btnSquare.Margin = new Padding(0);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(63, 60);
            btnSquare.TabIndex = 26;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnReverseX
            // 
            btnReverseX.Dock = DockStyle.Fill;
            btnReverseX.Location = new Point(0, 60);
            btnReverseX.Margin = new Padding(0);
            btnReverseX.Name = "btnReverseX";
            btnReverseX.Size = new Size(63, 60);
            btnReverseX.TabIndex = 27;
            btnReverseX.Text = "1/x";
            btnReverseX.UseVisualStyleBackColor = true;
            btnReverseX.Click += btnReverseX_Click;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Location = new Point(0, 0);
            btnPercent.Margin = new Padding(0);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(63, 60);
            btnPercent.TabIndex = 28;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMemorySave.Location = new Point(0, 0);
            btnMemorySave.Margin = new Padding(0);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(64, 59);
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
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(259, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnSquare, 1, 1);
            tableLayoutPanel2.Controls.Add(btnPercent, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAnswer, 3, 5);
            tableLayoutPanel2.Controls.Add(btnReverseX, 0, 1);
            tableLayoutPanel2.Controls.Add(btnClearEntry, 1, 0);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel2.Controls.Add(btnDot, 2, 5);
            tableLayoutPanel2.Controls.Add(btnZero, 1, 5);
            tableLayoutPanel2.Controls.Add(btnBackspace, 3, 0);
            tableLayoutPanel2.Controls.Add(btnChangeSign, 0, 5);
            tableLayoutPanel2.Controls.Add(btnOne, 0, 4);
            tableLayoutPanel2.Controls.Add(btnDivision, 3, 1);
            tableLayoutPanel2.Controls.Add(btnTwo, 1, 4);
            tableLayoutPanel2.Controls.Add(btnThree, 2, 4);
            tableLayoutPanel2.Controls.Add(btnAddition, 3, 4);
            tableLayoutPanel2.Controls.Add(btnSubstraction, 3, 3);
            tableLayoutPanel2.Controls.Add(btnSix, 2, 3);
            tableLayoutPanel2.Controls.Add(btnFive, 1, 3);
            tableLayoutPanel2.Controls.Add(btnFour, 0, 3);
            tableLayoutPanel2.Controls.Add(btnEight, 1, 2);
            tableLayoutPanel2.Controls.Add(btnNine, 2, 2);
            tableLayoutPanel2.Controls.Add(btnSqrt, 2, 1);
            tableLayoutPanel2.Controls.Add(btnMultiplication, 3, 2);
            tableLayoutPanel2.Controls.Add(btnSeven, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 95);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(253, 363);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAnswer
            // 
            btnAnswer.Dock = DockStyle.Fill;
            btnAnswer.Location = new Point(189, 300);
            btnAnswer.Margin = new Padding(0);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(64, 63);
            btnAnswer.TabIndex = 0;
            btnAnswer.Text = "=";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.Location = new Point(126, 300);
            btnDot.Margin = new Padding(0);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(63, 63);
            btnDot.TabIndex = 17;
            btnDot.Text = ",";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnZero
            // 
            btnZero.Dock = DockStyle.Fill;
            btnZero.Location = new Point(63, 300);
            btnZero.Margin = new Padding(0);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(63, 63);
            btnZero.TabIndex = 18;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnChangeSign
            // 
            btnChangeSign.Dock = DockStyle.Fill;
            btnChangeSign.Location = new Point(0, 300);
            btnChangeSign.Margin = new Padding(0);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Size = new Size(63, 63);
            btnChangeSign.TabIndex = 19;
            btnChangeSign.Text = "+/-";
            btnChangeSign.UseVisualStyleBackColor = true;
            btnChangeSign.Click += btnChangeSign_Click;
            // 
            // btnThree
            // 
            btnThree.Dock = DockStyle.Fill;
            btnThree.Location = new Point(126, 240);
            btnThree.Margin = new Padding(0);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(63, 60);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Dock = DockStyle.Fill;
            btnMultiplication.Location = new Point(189, 120);
            btnMultiplication.Margin = new Padding(0);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(64, 60);
            btnMultiplication.TabIndex = 29;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnSeven
            // 
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.Location = new Point(0, 120);
            btnSeven.Margin = new Padding(0);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(63, 60);
            btnSeven.TabIndex = 30;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblLastNumber);
            panel3.Controls.Add(lblCurrentNumber);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 86);
            panel3.TabIndex = 1;
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
            tpHistoryPage.Controls.Add(tableLayoutPanel3);
            tpHistoryPage.Location = new Point(4, 24);
            tpHistoryPage.Name = "tpHistoryPage";
            tpHistoryPage.Padding = new Padding(3);
            tpHistoryPage.Size = new Size(399, 433);
            tpHistoryPage.TabIndex = 0;
            tpHistoryPage.Text = "History";
            tpHistoryPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(btn_ClearHistory, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 84.21053F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15.78947F));
            tableLayoutPanel3.Size = new Size(393, 427);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 353);
            panel1.TabIndex = 1;
            // 
            // btn_ClearHistory
            // 
            btn_ClearHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ClearHistory.Location = new Point(326, 364);
            btn_ClearHistory.Name = "btn_ClearHistory";
            btn_ClearHistory.Size = new Size(64, 60);
            btn_ClearHistory.TabIndex = 0;
            btn_ClearHistory.Text = "CH";
            btn_ClearHistory.UseVisualStyleBackColor = true;
            btn_ClearHistory.Click += btn_ClearHistory_Click;
            // 
            // tpMemoryPage
            // 
            tpMemoryPage.Controls.Add(tableLayoutPanel4);
            tpMemoryPage.Location = new Point(4, 24);
            tpMemoryPage.Name = "tpMemoryPage";
            tpMemoryPage.Padding = new Padding(3);
            tpMemoryPage.Size = new Size(399, 433);
            tpMemoryPage.TabIndex = 1;
            tpMemoryPage.Text = "Memory";
            tpMemoryPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(panel2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.Size = new Size(393, 427);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnMemoryClear, 1, 0);
            tableLayoutPanel5.Controls.Add(btnMemorySave, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 365);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(387, 59);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMemoryClear.Location = new Point(323, 0);
            btnMemoryClear.Margin = new Padding(0);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(64, 59);
            btnMemoryClear.TabIndex = 1;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 356);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpHistoryPage.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tpMemoryPage.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnSubstraction;
        private Button btnAddition;
        private Button btnDivision;
        private Button btnBackspace;
        private Button btnClear;
        private Button btnClearEntry;
        private Button btnNine;
        private Button btnEight;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnTwo;
        private Button btnOne;
        private Label lblLastNumber;
        private TextBox lblCurrentNumber;
        private Button btnSqrt;
        private Button btnSquare;
        private Button btnReverseX;
        private Button btnPercent;
        private Button btnMemorySave;
        private SplitContainer splitContainer1;
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
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnThree;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Button btnMultiplication;
        private Button btnSeven;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
    }
}
