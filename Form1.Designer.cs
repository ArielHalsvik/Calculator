namespace Calculator
{
    partial class Calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonClear = new Button();
            buttonEqual = new Button();
            buttonDivide = new Button();
            buttonMultiply = new Button();
            buttonSubtract = new Button();
            buttonAdd = new Button();
            textBox = new TextBox();
            buttonBackspace = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 216);
            button1.Name = "button1";
            button1.Size = new Size(68, 65);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(86, 216);
            button2.Name = "button2";
            button2.Size = new Size(68, 65);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 216);
            button3.Name = "button3";
            button3.Size = new Size(68, 65);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 145);
            button4.Name = "button4";
            button4.Size = new Size(68, 65);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(86, 145);
            button5.Name = "button5";
            button5.Size = new Size(68, 65);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(160, 145);
            button6.Name = "button6";
            button6.Size = new Size(68, 65);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 74);
            button7.Name = "button7";
            button7.Size = new Size(68, 65);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(86, 74);
            button8.Name = "button8";
            button8.Size = new Size(68, 65);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(160, 74);
            button9.Name = "button9";
            button9.Size = new Size(68, 65);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(12, 285);
            button0.Name = "button0";
            button0.Size = new Size(68, 65);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(86, 285);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(68, 65);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(160, 285);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(68, 65);
            buttonEqual.TabIndex = 11;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(234, 74);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(68, 65);
            buttonDivide.TabIndex = 12;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(234, 145);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(68, 65);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "X";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(234, 216);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(68, 65);
            buttonSubtract.TabIndex = 14;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(234, 285);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(68, 65);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(216, 56);
            textBox.TabIndex = 16;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Location = new Point(235, 12);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(68, 56);
            buttonBackspace.TabIndex = 17;
            buttonBackspace.Text = "<";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(315, 363);
            Controls.Add(buttonBackspace);
            Controls.Add(textBox);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonDivide);
            Controls.Add(buttonEqual);
            Controls.Add(buttonClear);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonClear;
        private Button buttonEqual;
        private Button buttonDivide;
        private Button buttonMultiply;
        private Button buttonSubtract;
        private Button buttonAdd;
        private TextBox textBox;
        private Button buttonBackspace;
    }
}
