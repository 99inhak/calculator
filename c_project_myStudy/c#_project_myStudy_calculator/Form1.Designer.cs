namespace c__project_myStudy_calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxResult = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEquals = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 12);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(260, 23);
            textBoxResult.TabIndex = 0;
            // 
            // button0
            // 
            button0.Location = new Point(12, 204);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 1;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 148);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 148);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(124, 148);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 92);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(68, 92);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(124, 92);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 36);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(68, 36);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(124, 36);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(180, 36);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 50);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += operator_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(180, 92);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(50, 50);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += operator_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(180, 148);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(50, 50);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operator_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(180, 204);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(50, 50);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(236, 148);
            buttonEquals.Margin = new Padding(4, 3, 4, 3);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(50, 106);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(236, 36);
            buttonClear.Margin = new Padding(4, 3, 4, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 106);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 284);
            Controls.Add(buttonClear);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(textBoxResult);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "계산기";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
