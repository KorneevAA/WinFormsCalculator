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
            btnAnswer = new Button();
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
            btnDot = new Button();
            btnZero = new Button();
            btnChangeSign = new Button();
            lblLastNumber = new Label();
            lblCurrentNumber = new TextBox();
            btnSqrt = new Button();
            btnSquare = new Button();
            btnReverseX = new Button();
            btnPercent = new Button();
            lblMemoryNumber = new Label();
            btnMemoryPlus = new Button();
            btnMemoryMinus = new Button();
            btnMemorySave = new Button();
            btnMemoryClear = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnswer
            // 
            btnAnswer.Dock = DockStyle.Fill;
            btnAnswer.Location = new Point(231, 432);
            btnAnswer.Margin = new Padding(0);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(79, 78);
            btnAnswer.TabIndex = 0;
            btnAnswer.Text = "=";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnSubstraction
            // 
            btnSubstraction.Dock = DockStyle.Fill;
            btnSubstraction.Location = new Point(231, 288);
            btnSubstraction.Margin = new Padding(0);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(79, 72);
            btnSubstraction.TabIndex = 1;
            btnSubstraction.Text = "-";
            btnSubstraction.UseVisualStyleBackColor = true;
            btnSubstraction.Click += btnSubstraction_Click;
            // 
            // btnAddition
            // 
            btnAddition.Dock = DockStyle.Fill;
            btnAddition.Location = new Point(231, 360);
            btnAddition.Margin = new Padding(0);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(79, 72);
            btnAddition.TabIndex = 2;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnDivision
            // 
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Location = new Point(231, 144);
            btnDivision.Margin = new Padding(0);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(79, 72);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Dock = DockStyle.Fill;
            btnMultiplication.Location = new Point(231, 216);
            btnMultiplication.Margin = new Padding(0);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(79, 72);
            btnMultiplication.TabIndex = 4;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Location = new Point(231, 72);
            btnBackspace.Margin = new Padding(0);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(79, 72);
            btnBackspace.TabIndex = 5;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(154, 72);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 72);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Dock = DockStyle.Fill;
            btnClearEntry.Location = new Point(77, 72);
            btnClearEntry.Margin = new Padding(0);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(77, 72);
            btnClearEntry.TabIndex = 7;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnNine
            // 
            btnNine.Dock = DockStyle.Fill;
            btnNine.Location = new Point(154, 216);
            btnNine.Margin = new Padding(0);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(77, 72);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.Dock = DockStyle.Fill;
            btnEight.Location = new Point(77, 216);
            btnEight.Margin = new Padding(0);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(77, 72);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.Location = new Point(0, 216);
            btnSeven.Margin = new Padding(0);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(77, 72);
            btnSeven.TabIndex = 10;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnSix
            // 
            btnSix.Dock = DockStyle.Fill;
            btnSix.Location = new Point(154, 288);
            btnSix.Margin = new Padding(0);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(77, 72);
            btnSix.TabIndex = 11;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.Dock = DockStyle.Fill;
            btnFive.Location = new Point(77, 288);
            btnFive.Margin = new Padding(0);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(77, 72);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.Dock = DockStyle.Fill;
            btnFour.Location = new Point(0, 288);
            btnFour.Margin = new Padding(0);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(77, 72);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnThree
            // 
            btnThree.Dock = DockStyle.Fill;
            btnThree.Location = new Point(154, 360);
            btnThree.Margin = new Padding(0);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(77, 72);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.Location = new Point(77, 360);
            btnTwo.Margin = new Padding(0);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(77, 72);
            btnTwo.TabIndex = 15;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.Dock = DockStyle.Fill;
            btnOne.Location = new Point(0, 360);
            btnOne.Margin = new Padding(0);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(77, 72);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.Location = new Point(154, 432);
            btnDot.Margin = new Padding(0);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(77, 78);
            btnDot.TabIndex = 17;
            btnDot.Text = ",";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnZero
            // 
            btnZero.Dock = DockStyle.Fill;
            btnZero.Location = new Point(77, 432);
            btnZero.Margin = new Padding(0);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(77, 78);
            btnZero.TabIndex = 18;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnChangeSign
            // 
            btnChangeSign.Dock = DockStyle.Fill;
            btnChangeSign.Location = new Point(0, 432);
            btnChangeSign.Margin = new Padding(0);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Size = new Size(77, 78);
            btnChangeSign.TabIndex = 19;
            btnChangeSign.Text = "+/-";
            btnChangeSign.UseVisualStyleBackColor = true;
            btnChangeSign.Click += btnChangeSign_Click;
            // 
            // lblLastNumber
            // 
            lblLastNumber.AutoSize = true;
            lblLastNumber.Location = new Point(12, 9);
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
            lblCurrentNumber.Location = new Point(133, 71);
            lblCurrentNumber.Name = "lblCurrentNumber";
            lblCurrentNumber.Size = new Size(174, 25);
            lblCurrentNumber.TabIndex = 23;
            lblCurrentNumber.Text = "0";
            lblCurrentNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSqrt
            // 
            btnSqrt.Dock = DockStyle.Fill;
            btnSqrt.Location = new Point(154, 144);
            btnSqrt.Margin = new Padding(0);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(77, 72);
            btnSqrt.TabIndex = 25;
            btnSqrt.Text = "sqrt()";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnSquare
            // 
            btnSquare.Dock = DockStyle.Fill;
            btnSquare.Location = new Point(77, 144);
            btnSquare.Margin = new Padding(0);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(77, 72);
            btnSquare.TabIndex = 26;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnReverseX
            // 
            btnReverseX.Dock = DockStyle.Fill;
            btnReverseX.Location = new Point(0, 144);
            btnReverseX.Margin = new Padding(0);
            btnReverseX.Name = "btnReverseX";
            btnReverseX.Size = new Size(77, 72);
            btnReverseX.TabIndex = 27;
            btnReverseX.Text = "1/x";
            btnReverseX.UseVisualStyleBackColor = true;
            btnReverseX.Click += btnReverseX_Click;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Location = new Point(0, 72);
            btnPercent.Margin = new Padding(0);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(77, 72);
            btnPercent.TabIndex = 28;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // lblMemoryNumber
            // 
            lblMemoryNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMemoryNumber.AutoSize = true;
            lblMemoryNumber.Location = new Point(235, 9);
            lblMemoryNumber.Name = "lblMemoryNumber";
            lblMemoryNumber.Size = new Size(13, 15);
            lblMemoryNumber.TabIndex = 29;
            lblMemoryNumber.Text = "0";
            lblMemoryNumber.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnMemoryPlus
            // 
            btnMemoryPlus.Dock = DockStyle.Fill;
            btnMemoryPlus.Location = new Point(77, 0);
            btnMemoryPlus.Margin = new Padding(0);
            btnMemoryPlus.Name = "btnMemoryPlus";
            btnMemoryPlus.Size = new Size(77, 72);
            btnMemoryPlus.TabIndex = 30;
            btnMemoryPlus.Text = "M+";
            btnMemoryPlus.UseVisualStyleBackColor = true;
            btnMemoryPlus.Click += btnMemoryPlus_Click;
            // 
            // btnMemoryMinus
            // 
            btnMemoryMinus.Dock = DockStyle.Fill;
            btnMemoryMinus.Location = new Point(154, 0);
            btnMemoryMinus.Margin = new Padding(0);
            btnMemoryMinus.Name = "btnMemoryMinus";
            btnMemoryMinus.Size = new Size(77, 72);
            btnMemoryMinus.TabIndex = 31;
            btnMemoryMinus.Text = "M-";
            btnMemoryMinus.UseVisualStyleBackColor = true;
            btnMemoryMinus.Click += btnMemoryMinus_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Dock = DockStyle.Fill;
            btnMemorySave.Location = new Point(231, 0);
            btnMemorySave.Margin = new Padding(0);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(79, 72);
            btnMemorySave.TabIndex = 32;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Dock = DockStyle.Fill;
            btnMemoryClear.Location = new Point(0, 0);
            btnMemoryClear.Margin = new Padding(0);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(77, 72);
            btnMemoryClear.TabIndex = 33;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Panel2Collapsed = true;
            splitContainer1.Size = new Size(310, 613);
            splitContainer1.SplitterDistance = 322;
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
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(310, 613);
            splitContainer2.SplitterDistance = 99;
            splitContainer2.TabIndex = 0;
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
            tableLayoutPanel1.Controls.Add(btnMemoryClear, 0, 0);
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
            tableLayoutPanel1.Controls.Add(btnMemoryPlus, 1, 0);
            tableLayoutPanel1.Controls.Add(btnMemorySave, 3, 0);
            tableLayoutPanel1.Controls.Add(btnMemoryMinus, 2, 0);
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
            tableLayoutPanel1.Size = new Size(310, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 613);
            Controls.Add(splitContainer1);
            Name = "CalculatorForm";
            Text = "Калькулятор";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnswer;
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
        private Button btnDot;
        private Button btnZero;
        private Button btnChangeSign;
        private Label lblLastNumber;
        private TextBox lblCurrentNumber;
        private Button btnSqrt;
        private Button btnSquare;
        private Button btnReverseX;
        private Button btnPercent;
        private Label lblMemoryNumber;
        private Button btnMemoryPlus;
        private Button btnMemoryMinus;
        private Button btnMemorySave;
        private Button btnMemoryClear;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
