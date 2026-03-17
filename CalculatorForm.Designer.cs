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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(211, 416);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(60, 60);
            btnAnswer.TabIndex = 0;
            btnAnswer.Text = "=";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnSubstraction
            // 
            btnSubstraction.Location = new Point(211, 350);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(60, 60);
            btnSubstraction.TabIndex = 1;
            btnSubstraction.Text = "-";
            btnSubstraction.UseVisualStyleBackColor = true;
            btnSubstraction.Click += btnSubstraction_Click;
            // 
            // btnAddition
            // 
            btnAddition.Location = new Point(211, 284);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(60, 60);
            btnAddition.TabIndex = 2;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(211, 218);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(60, 60);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Location = new Point(211, 152);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(60, 60);
            btnMultiplication.TabIndex = 4;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(145, 152);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(60, 60);
            btnBackspace.TabIndex = 5;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(79, 152);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 60);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Location = new Point(11, 152);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(60, 60);
            btnClearEntry.TabIndex = 7;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(145, 218);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(60, 60);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(77, 218);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(60, 60);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(11, 218);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(60, 60);
            btnSeven.TabIndex = 10;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(145, 284);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(60, 60);
            btnSix.TabIndex = 11;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(77, 284);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(60, 60);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(11, 284);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(60, 60);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(145, 350);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(60, 60);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(77, 350);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(60, 60);
            btnTwo.TabIndex = 15;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(11, 350);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(60, 60);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(145, 416);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 60);
            btnDot.TabIndex = 17;
            btnDot.Text = ",";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(79, 416);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(60, 60);
            btnZero.TabIndex = 18;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnChangeSign
            // 
            btnChangeSign.Location = new Point(13, 416);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Size = new Size(60, 60);
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
            lblLastNumber.Size = new Size(0, 15);
            lblLastNumber.TabIndex = 21;
            // 
            // lblCurrentNumber
            // 
            lblCurrentNumber.BackColor = SystemColors.Control;
            lblCurrentNumber.BorderStyle = BorderStyle.None;
            lblCurrentNumber.Font = new Font("Segoe UI", 14F);
            lblCurrentNumber.Location = new Point(97, 55);
            lblCurrentNumber.Name = "lblCurrentNumber";
            lblCurrentNumber.Size = new Size(174, 25);
            lblCurrentNumber.TabIndex = 23;
            lblCurrentNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(145, 86);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(60, 60);
            btnSqrt.TabIndex = 25;
            btnSqrt.Text = "sqrt()";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(77, 86);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(60, 60);
            btnSquare.TabIndex = 26;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnReverseX
            // 
            btnReverseX.Location = new Point(13, 86);
            btnReverseX.Name = "btnReverseX";
            btnReverseX.Size = new Size(60, 60);
            btnReverseX.TabIndex = 27;
            btnReverseX.Text = "1/x";
            btnReverseX.UseVisualStyleBackColor = true;
            btnReverseX.Click += btnReverseX_Click;
            // 
            // btnPercent
            // 
            btnPercent.Location = new Point(211, 86);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(60, 60);
            btnPercent.TabIndex = 28;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // lblMemoryNumber
            // 
            lblMemoryNumber.AutoSize = true;
            lblMemoryNumber.Location = new Point(211, 9);
            lblMemoryNumber.Name = "lblMemoryNumber";
            lblMemoryNumber.Size = new Size(13, 15);
            lblMemoryNumber.TabIndex = 29;
            lblMemoryNumber.Text = "0";
            // 
            // btnMemoryPlus
            // 
            btnMemoryPlus.Location = new Point(211, 482);
            btnMemoryPlus.Name = "btnMemoryPlus";
            btnMemoryPlus.Size = new Size(60, 60);
            btnMemoryPlus.TabIndex = 30;
            btnMemoryPlus.Text = "M+";
            btnMemoryPlus.UseVisualStyleBackColor = true;
            btnMemoryPlus.Click += btnMemoryPlus_Click;
            // 
            // btnMemoryMinus
            // 
            btnMemoryMinus.Location = new Point(145, 482);
            btnMemoryMinus.Name = "btnMemoryMinus";
            btnMemoryMinus.Size = new Size(60, 60);
            btnMemoryMinus.TabIndex = 31;
            btnMemoryMinus.Text = "M-";
            btnMemoryMinus.UseVisualStyleBackColor = true;
            btnMemoryMinus.Click += btnMemoryMinus_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Location = new Point(77, 482);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(60, 60);
            btnMemorySave.TabIndex = 32;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Location = new Point(11, 482);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(60, 60);
            btnMemoryClear.TabIndex = 33;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(117, 51);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.TabIndex = 34;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 550);
            Controls.Add(splitContainer1);
            Controls.Add(btnMemoryClear);
            Controls.Add(btnMemorySave);
            Controls.Add(btnMemoryMinus);
            Controls.Add(btnMemoryPlus);
            Controls.Add(lblMemoryNumber);
            Controls.Add(btnPercent);
            Controls.Add(btnReverseX);
            Controls.Add(btnSquare);
            Controls.Add(btnSqrt);
            Controls.Add(lblCurrentNumber);
            Controls.Add(lblLastNumber);
            Controls.Add(btnChangeSign);
            Controls.Add(btnZero);
            Controls.Add(btnDot);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnFour);
            Controls.Add(btnFive);
            Controls.Add(btnSix);
            Controls.Add(btnSeven);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(btnClearEntry);
            Controls.Add(btnClear);
            Controls.Add(btnBackspace);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDivision);
            Controls.Add(btnAddition);
            Controls.Add(btnSubstraction);
            Controls.Add(btnAnswer);
            Name = "CalculatorForm";
            Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
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
    }
}
