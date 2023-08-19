namespace MistryR1
{
    partial class MainForm
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
            txtBox = new TextBox();
            btnClear = new Button();
            btnNo2 = new Button();
            btnNo1 = new Button();
            btnNo6 = new Button();
            btnNo5 = new Button();
            btnNo4 = new Button();
            btnNo9 = new Button();
            btnNo8 = new Button();
            btnNo7 = new Button();
            btnClearEntry = new Button();
            btnDecimalPoint = new Button();
            btnNo3 = new Button();
            btnNo0 = new Button();
            btnEquals = new Button();
            btnDivision = new Button();
            btnMultiplication = new Button();
            btnSubstraction = new Button();
            btnAdd = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.BackColor = SystemColors.GradientActiveCaption;
            txtBox.Location = new Point(55, 102);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(402, 39);
            txtBox.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Location = new Point(55, 177);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 44);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnNo2
            // 
            btnNo2.Location = new Point(161, 384);
            btnNo2.Name = "btnNo2";
            btnNo2.Size = new Size(69, 44);
            btnNo2.TabIndex = 3;
            btnNo2.Text = "2";
            btnNo2.UseVisualStyleBackColor = true;
            // 
            // btnNo1
            // 
            btnNo1.Location = new Point(55, 384);
            btnNo1.Name = "btnNo1";
            btnNo1.Size = new Size(69, 44);
            btnNo1.TabIndex = 4;
            btnNo1.Text = "1";
            btnNo1.UseVisualStyleBackColor = true;
            // 
            // btnNo6
            // 
            btnNo6.BackColor = Color.LightGray;
            btnNo6.Location = new Point(273, 312);
            btnNo6.Name = "btnNo6";
            btnNo6.Size = new Size(69, 44);
            btnNo6.TabIndex = 5;
            btnNo6.Text = "6";
            btnNo6.UseVisualStyleBackColor = false;
            btnNo6.Click += DigitButton;
            // 
            // btnNo5
            // 
            btnNo5.BackColor = Color.LightGray;
            btnNo5.Location = new Point(161, 312);
            btnNo5.Name = "btnNo5";
            btnNo5.Size = new Size(69, 44);
            btnNo5.TabIndex = 6;
            btnNo5.Text = "5";
            btnNo5.UseVisualStyleBackColor = false;
            btnNo5.Click += DigitButton;
            // 
            // btnNo4
            // 
            btnNo4.BackColor = Color.LightGray;
            btnNo4.Location = new Point(55, 312);
            btnNo4.Name = "btnNo4";
            btnNo4.Size = new Size(69, 44);
            btnNo4.TabIndex = 7;
            btnNo4.Text = "4";
            btnNo4.UseVisualStyleBackColor = false;
            btnNo4.Click += DigitButton;
            // 
            // btnNo9
            // 
            btnNo9.BackColor = Color.LightGray;
            btnNo9.Location = new Point(273, 243);
            btnNo9.Name = "btnNo9";
            btnNo9.Size = new Size(69, 44);
            btnNo9.TabIndex = 8;
            btnNo9.Text = "9";
            btnNo9.UseVisualStyleBackColor = false;
            btnNo9.Click += DigitButton;
            // 
            // btnNo8
            // 
            btnNo8.BackColor = Color.LightGray;
            btnNo8.Location = new Point(161, 243);
            btnNo8.Name = "btnNo8";
            btnNo8.Size = new Size(69, 44);
            btnNo8.TabIndex = 9;
            btnNo8.Text = "8";
            btnNo8.UseVisualStyleBackColor = false;
            btnNo8.Click += DigitButton;
            // 
            // btnNo7
            // 
            btnNo7.BackColor = Color.LightGray;
            btnNo7.Location = new Point(55, 243);
            btnNo7.Name = "btnNo7";
            btnNo7.Size = new Size(69, 44);
            btnNo7.TabIndex = 10;
            btnNo7.Text = "7";
            btnNo7.UseVisualStyleBackColor = false;
            btnNo7.Click += DigitButton;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.LightGray;
            btnClearEntry.Location = new Point(161, 177);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(69, 44);
            btnClearEntry.TabIndex = 11;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.BackColor = Color.LightGray;
            btnDecimalPoint.Location = new Point(273, 464);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(69, 44);
            btnDecimalPoint.TabIndex = 12;
            btnDecimalPoint.Text = ".";
            btnDecimalPoint.UseVisualStyleBackColor = false;
            btnDecimalPoint.Click += DigitButton;
            // 
            // btnNo3
            // 
            btnNo3.Location = new Point(273, 384);
            btnNo3.Name = "btnNo3";
            btnNo3.Size = new Size(69, 44);
            btnNo3.TabIndex = 13;
            btnNo3.Text = "3";
            btnNo3.UseVisualStyleBackColor = true;
            btnNo3.Click += button12_Click;
            // 
            // btnNo0
            // 
            btnNo0.BackColor = Color.LightGray;
            btnNo0.Location = new Point(161, 464);
            btnNo0.Name = "btnNo0";
            btnNo0.Size = new Size(69, 44);
            btnNo0.TabIndex = 14;
            btnNo0.Text = "0";
            btnNo0.UseVisualStyleBackColor = false;
            btnNo0.Click += DigitButton;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.LightGray;
            btnEquals.Location = new Point(388, 464);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(69, 44);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click_1;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.LightGray;
            btnDivision.Location = new Point(388, 384);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(69, 44);
            btnDivision.TabIndex = 16;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += OperatorButton_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.LightGray;
            btnMultiplication.Location = new Point(388, 312);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(69, 44);
            btnMultiplication.TabIndex = 17;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += OperatorButton_Click;
            // 
            // btnSubstraction
            // 
            btnSubstraction.BackColor = Color.LightGray;
            btnSubstraction.Location = new Point(388, 243);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(69, 44);
            btnSubstraction.TabIndex = 18;
            btnSubstraction.Text = "-";
            btnSubstraction.UseVisualStyleBackColor = false;
            btnSubstraction.Click += OperatorButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGray;
            btnAdd.Location = new Point(388, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 44);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += OperatorButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(161, 384);
            button1.Name = "button1";
            button1.Size = new Size(69, 44);
            button1.TabIndex = 3;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = false;
            button1.Click += DigitButton;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(55, 384);
            button2.Name = "button2";
            button2.Size = new Size(69, 44);
            button2.TabIndex = 4;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DigitButton;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Location = new Point(273, 384);
            button3.Name = "button3";
            button3.Size = new Size(69, 44);
            button3.TabIndex = 13;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += DigitButton;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(64, 46);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(90, 32);
            lblResult.TabIndex = 20;
            lblResult.Text = "Result: ";
            lblResult.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(535, 576);
            Controls.Add(lblResult);
            Controls.Add(btnAdd);
            Controls.Add(btnSubstraction);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDivision);
            Controls.Add(btnEquals);
            Controls.Add(btnNo0);
            Controls.Add(button3);
            Controls.Add(btnNo3);
            Controls.Add(btnDecimalPoint);
            Controls.Add(btnClearEntry);
            Controls.Add(btnNo7);
            Controls.Add(btnNo8);
            Controls.Add(btnNo9);
            Controls.Add(btnNo4);
            Controls.Add(btnNo5);
            Controls.Add(button2);
            Controls.Add(btnNo6);
            Controls.Add(button1);
            Controls.Add(btnNo1);
            Controls.Add(btnNo2);
            Controls.Add(btnClear);
            Controls.Add(txtBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBox;
        private Button btnClear;
        private Button btnNo2;
        private Button btnNo1;
        private Button btnNo6;
        private Button btnNo5;
        private Button btnNo4;
        private Button btnNo9;
        private Button btnNo8;
        private Button btnNo7;
        private Button btnClearEntry;
        private Button btnDecimalPoint;
        private Button btnNo3;
        private Button btnNo0;
        private Button btnEquals;
        private Button btnDivision;
        private Button btnMultiplication;
        private Button btnSubstraction;
        private Button btnAdd;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblResult;
    }
}