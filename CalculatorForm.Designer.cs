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
            lstHistory = new ListBox();
            btnClearHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnswer  col3=208, row6=411
            // 
            btnAnswer.Location = new Point(208, 411);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(60, 60);
            btnAnswer.TabIndex = 0;
            btnAnswer.Text = "=";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnSubstraction  col3=208, row5=346
            // 
            btnSubstraction.Location = new Point(208, 346);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(60, 60);
            btnSubstraction.TabIndex = 1;
            btnSubstraction.Text = "-";
            btnSubstraction.UseVisualStyleBackColor = true;
            btnSubstraction.Click += btnSubstraction_Click;
            // 
            // btnAddition  col3=208, row4=281
            // 
            btnAddition.Location = new Point(208, 281);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(60, 60);
            btnAddition.TabIndex = 2;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnDivision  col3=208, row3=216
            // 
            btnDivision.Location = new Point(208, 216);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(60, 60);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplication  col3=208, row2=151
            // 
            btnMultiplication.Location = new Point(208, 151);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(60, 60);
            btnMultiplication.TabIndex = 4;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnBackspace  col2=143, row2=151
            // 
            btnBackspace.Location = new Point(143, 151);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(60, 60);
            btnBackspace.TabIndex = 5;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnClear  col1=78, row2=151
            // 
            btnClear.Location = new Point(78, 151);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 60);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearEntry  col0=13, row2=151
            // 
            btnClearEntry.Location = new Point(13, 151);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(60, 60);
            btnClearEntry.TabIndex = 7;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnNine  col2=143, row3=216
            // 
            btnNine.Location = new Point(143, 216);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(60, 60);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight  col1=78, row3=216
            // 
            btnEight.Location = new Point(78, 216);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(60, 60);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven  col0=13, row3=216
            // 
            btnSeven.Location = new Point(13, 216);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(60, 60);
            btnSeven.TabIndex = 10;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnSix  col2=143, row4=281
            // 
            btnSix.Location = new Point(143, 281);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(60, 60);
            btnSix.TabIndex = 11;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive  col1=78, row4=281
            // 
            btnFive.Location = new Point(78, 281);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(60, 60);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour  col0=13, row4=281
            // 
            btnFour.Location = new Point(13, 281);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(60, 60);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnThree  col2=143, row5=346
            // 
            btnThree.Location = new Point(143, 346);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(60, 60);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo  col1=78, row5=346
            // 
            btnTwo.Location = new Point(78, 346);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(60, 60);
            btnTwo.TabIndex = 15;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne  col0=13, row5=346
            // 
            btnOne.Location = new Point(13, 346);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(60, 60);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnDot  col2=143, row6=411
            // 
            btnDot.Location = new Point(143, 411);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 60);
            btnDot.TabIndex = 17;
            btnDot.Text = ",";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnZero  col1=78, row6=411
            // 
            btnZero.Location = new Point(78, 411);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(60, 60);
            btnZero.TabIndex = 18;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnChangeSign  col0=13, row6=411
            // 
            btnChangeSign.Location = new Point(13, 411);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Size = new Size(60, 60);
            btnChangeSign.TabIndex = 19;
            btnChangeSign.Text = "+/-";
            btnChangeSign.UseVisualStyleBackColor = true;
            btnChangeSign.Click += btnChangeSign_Click;
            // 
            // lblLastNumber
            // 
            lblLastNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLastNumber.Location = new Point(13, 8);
            lblLastNumber.Name = "lblLastNumber";
            lblLastNumber.Size = new Size(215, 15);
            lblLastNumber.TabIndex = 21;
            lblLastNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentNumber
            // 
            lblCurrentNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentNumber.BackColor = SystemColors.Control;
            lblCurrentNumber.BorderStyle = BorderStyle.None;
            lblCurrentNumber.Font = new Font("Segoe UI", 14F);
            lblCurrentNumber.Location = new Point(13, 30);
            lblCurrentNumber.Name = "lblCurrentNumber";
            lblCurrentNumber.Size = new Size(255, 25);
            lblCurrentNumber.TabIndex = 23;
            lblCurrentNumber.Text = "0";
            lblCurrentNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSqrt  col2=143, row1=86
            // 
            btnSqrt.Location = new Point(143, 86);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(60, 60);
            btnSqrt.TabIndex = 25;
            btnSqrt.Text = "sqrt()";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnSquare  col1=78, row1=86
            // 
            btnSquare.Location = new Point(78, 86);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(60, 60);
            btnSquare.TabIndex = 26;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnReverseX  col0=13, row1=86
            // 
            btnReverseX.Location = new Point(13, 86);
            btnReverseX.Name = "btnReverseX";
            btnReverseX.Size = new Size(60, 60);
            btnReverseX.TabIndex = 27;
            btnReverseX.Text = "1/x";
            btnReverseX.UseVisualStyleBackColor = true;
            btnReverseX.Click += btnReverseX_Click;
            // 
            // btnPercent  col3=208, row1=86
            // 
            btnPercent.Location = new Point(208, 86);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(60, 60);
            btnPercent.TabIndex = 28;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // lblMemoryNumber
            // 
            lblMemoryNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMemoryNumber.AutoSize = true;
            lblMemoryNumber.Location = new Point(252, 8);
            lblMemoryNumber.Name = "lblMemoryNumber";
            lblMemoryNumber.Size = new Size(13, 15);
            lblMemoryNumber.TabIndex = 29;
            lblMemoryNumber.Text = "0";
            // 
            // btnMemoryPlus  col3=208, row7=476
            // 
            btnMemoryPlus.Location = new Point(208, 476);
            btnMemoryPlus.Name = "btnMemoryPlus";
            btnMemoryPlus.Size = new Size(60, 60);
            btnMemoryPlus.TabIndex = 30;
            btnMemoryPlus.Text = "M+";
            btnMemoryPlus.UseVisualStyleBackColor = true;
            btnMemoryPlus.Click += btnMemoryPlus_Click;
            // 
            // btnMemoryMinus  col2=143, row7=476
            // 
            btnMemoryMinus.Location = new Point(143, 476);
            btnMemoryMinus.Name = "btnMemoryMinus";
            btnMemoryMinus.Size = new Size(60, 60);
            btnMemoryMinus.TabIndex = 31;
            btnMemoryMinus.Text = "M-";
            btnMemoryMinus.UseVisualStyleBackColor = true;
            btnMemoryMinus.Click += btnMemoryMinus_Click;
            // 
            // btnMemorySave  col1=78, row7=476
            // 
            btnMemorySave.Location = new Point(78, 476);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(60, 60);
            btnMemorySave.TabIndex = 32;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // btnMemoryClear  col0=13, row7=476
            // 
            btnMemoryClear.Location = new Point(13, 476);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(60, 60);
            btnMemoryClear.TabIndex = 33;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // lstHistory - fills Panel2, history items shown newest-first
            // 
            lstHistory.Dock = DockStyle.Fill;
            lstHistory.BorderStyle = BorderStyle.None;
            lstHistory.Font = new Font("Segoe UI", 9F);
            lstHistory.Name = "lstHistory";
            lstHistory.TabIndex = 0;
            // 
            // btnClearHistory - floats at top-right of Panel2, overlaid on history list
            // 
            btnClearHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearHistory.Location = new Point(65, 5);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(80, 25);
            btnClearHistory.TabIndex = 1;
            btnClearHistory.Text = "Очистить";
            btnClearHistory.UseVisualStyleBackColor = true;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // splitContainer1 - Panel1=calculator, Panel2=history
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Vertical;
            splitContainer1.Panel1MinSize = 281;
            splitContainer1.Panel2MinSize = 150;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.SplitterDistance = 281;
            splitContainer1.TabIndex = 34;
            splitContainer1.Panel2Collapsed = true;
            // 
            // Panel1 - all calculator controls
            // 
            splitContainer1.Panel1.Controls.Add(lblMemoryNumber);
            splitContainer1.Panel1.Controls.Add(lblLastNumber);
            splitContainer1.Panel1.Controls.Add(lblCurrentNumber);
            splitContainer1.Panel1.Controls.Add(btnReverseX);
            splitContainer1.Panel1.Controls.Add(btnSquare);
            splitContainer1.Panel1.Controls.Add(btnSqrt);
            splitContainer1.Panel1.Controls.Add(btnPercent);
            splitContainer1.Panel1.Controls.Add(btnClearEntry);
            splitContainer1.Panel1.Controls.Add(btnClear);
            splitContainer1.Panel1.Controls.Add(btnBackspace);
            splitContainer1.Panel1.Controls.Add(btnMultiplication);
            splitContainer1.Panel1.Controls.Add(btnSeven);
            splitContainer1.Panel1.Controls.Add(btnEight);
            splitContainer1.Panel1.Controls.Add(btnNine);
            splitContainer1.Panel1.Controls.Add(btnDivision);
            splitContainer1.Panel1.Controls.Add(btnFour);
            splitContainer1.Panel1.Controls.Add(btnFive);
            splitContainer1.Panel1.Controls.Add(btnSix);
            splitContainer1.Panel1.Controls.Add(btnAddition);
            splitContainer1.Panel1.Controls.Add(btnOne);
            splitContainer1.Panel1.Controls.Add(btnTwo);
            splitContainer1.Panel1.Controls.Add(btnThree);
            splitContainer1.Panel1.Controls.Add(btnSubstraction);
            splitContainer1.Panel1.Controls.Add(btnChangeSign);
            splitContainer1.Panel1.Controls.Add(btnZero);
            splitContainer1.Panel1.Controls.Add(btnDot);
            splitContainer1.Panel1.Controls.Add(btnAnswer);
            splitContainer1.Panel1.Controls.Add(btnMemoryClear);
            splitContainer1.Panel1.Controls.Add(btnMemorySave);
            splitContainer1.Panel1.Controls.Add(btnMemoryMinus);
            splitContainer1.Panel1.Controls.Add(btnMemoryPlus);
            // 
            // Panel2 - history list with floating clear button
            // 
            splitContainer1.Panel2.Controls.Add(lstHistory);
            splitContainer1.Panel2.Controls.Add(btnClearHistory);
            btnClearHistory.BringToFront();
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 550);
            Controls.Add(splitContainer1);
            Name = "CalculatorForm";
            Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ListBox lstHistory;
        private Button btnClearHistory;
    }
}
