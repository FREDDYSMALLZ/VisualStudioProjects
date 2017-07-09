namespace MyCalculatorUI
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.Clear_Entry_Button = new System.Windows.Forms.Button();
            this.Seven_Button = new System.Windows.Forms.Button();
            this.Four_Button = new System.Windows.Forms.Button();
            this.One_Button = new System.Windows.Forms.Button();
            this.Zero_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Division_Button = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.Addition_Button = new System.Windows.Forms.Button();
            this.Equal_Button = new System.Windows.Forms.Button();
            this.Eight_Button = new System.Windows.Forms.Button();
            this.Five_Button = new System.Windows.Forms.Button();
            this.Two_Button = new System.Windows.Forms.Button();
            this.Nine_Button = new System.Windows.Forms.Button();
            this.Six_Button = new System.Windows.Forms.Button();
            this.Three_Button = new System.Windows.Forms.Button();
            this.Dot_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(22, 21);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(565, 78);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear_Entry_Button
            // 
            this.Clear_Entry_Button.Location = new System.Drawing.Point(22, 107);
            this.Clear_Entry_Button.Name = "Clear_Entry_Button";
            this.Clear_Entry_Button.Size = new System.Drawing.Size(108, 108);
            this.Clear_Entry_Button.TabIndex = 1;
            this.Clear_Entry_Button.Text = "CE";
            this.Clear_Entry_Button.UseVisualStyleBackColor = true;
            this.Clear_Entry_Button.Click += new System.EventHandler(this.Clear_Entry_Button_Click);
            // 
            // Seven_Button
            // 
            this.Seven_Button.Location = new System.Drawing.Point(22, 222);
            this.Seven_Button.Name = "Seven_Button";
            this.Seven_Button.Size = new System.Drawing.Size(108, 108);
            this.Seven_Button.TabIndex = 1;
            this.Seven_Button.Text = "7";
            this.Seven_Button.UseVisualStyleBackColor = true;
            this.Seven_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Four_Button
            // 
            this.Four_Button.Location = new System.Drawing.Point(22, 336);
            this.Four_Button.Name = "Four_Button";
            this.Four_Button.Size = new System.Drawing.Size(108, 108);
            this.Four_Button.TabIndex = 1;
            this.Four_Button.Text = "4";
            this.Four_Button.UseVisualStyleBackColor = true;
            this.Four_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // One_Button
            // 
            this.One_Button.Location = new System.Drawing.Point(22, 451);
            this.One_Button.Name = "One_Button";
            this.One_Button.Size = new System.Drawing.Size(108, 108);
            this.One_Button.TabIndex = 1;
            this.One_Button.Text = "1";
            this.One_Button.UseVisualStyleBackColor = true;
            this.One_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Zero_Button
            // 
            this.Zero_Button.Location = new System.Drawing.Point(22, 566);
            this.Zero_Button.Name = "Zero_Button";
            this.Zero_Button.Size = new System.Drawing.Size(222, 108);
            this.Zero_Button.TabIndex = 1;
            this.Zero_Button.Text = "0";
            this.Zero_Button.UseVisualStyleBackColor = true;
            this.Zero_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(251, 107);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(129, 108);
            this.Clear_Button.TabIndex = 1;
            this.Clear_Button.Text = "C";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Division_Button
            // 
            this.Division_Button.Location = new System.Drawing.Point(386, 107);
            this.Division_Button.Name = "Division_Button";
            this.Division_Button.Size = new System.Drawing.Size(201, 108);
            this.Division_Button.TabIndex = 1;
            this.Division_Button.Text = "/";
            this.Division_Button.UseVisualStyleBackColor = true;
            this.Division_Button.Click += new System.EventHandler(this.operator_Click);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.Location = new System.Drawing.Point(386, 222);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(201, 108);
            this.Multiply_Button.TabIndex = 1;
            this.Multiply_Button.Text = "*";
            this.Multiply_Button.UseVisualStyleBackColor = true;
            this.Multiply_Button.Click += new System.EventHandler(this.operator_Click);
            // 
            // Minus_Button
            // 
            this.Minus_Button.Location = new System.Drawing.Point(386, 337);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(202, 108);
            this.Minus_Button.TabIndex = 1;
            this.Minus_Button.Text = "-";
            this.Minus_Button.UseVisualStyleBackColor = true;
            this.Minus_Button.Click += new System.EventHandler(this.operator_Click);
            // 
            // Addition_Button
            // 
            this.Addition_Button.Location = new System.Drawing.Point(386, 451);
            this.Addition_Button.Name = "Addition_Button";
            this.Addition_Button.Size = new System.Drawing.Size(201, 108);
            this.Addition_Button.TabIndex = 1;
            this.Addition_Button.Text = "+";
            this.Addition_Button.UseVisualStyleBackColor = true;
            this.Addition_Button.Click += new System.EventHandler(this.operator_Click);
            // 
            // Equal_Button
            // 
            this.Equal_Button.Location = new System.Drawing.Point(386, 566);
            this.Equal_Button.Name = "Equal_Button";
            this.Equal_Button.Size = new System.Drawing.Size(201, 108);
            this.Equal_Button.TabIndex = 1;
            this.Equal_Button.Text = "=";
            this.Equal_Button.UseVisualStyleBackColor = true;
            this.Equal_Button.Click += new System.EventHandler(this.Equal_Button_Click);
            // 
            // Eight_Button
            // 
            this.Eight_Button.Location = new System.Drawing.Point(137, 222);
            this.Eight_Button.Name = "Eight_Button";
            this.Eight_Button.Size = new System.Drawing.Size(108, 108);
            this.Eight_Button.TabIndex = 1;
            this.Eight_Button.Text = "8";
            this.Eight_Button.UseVisualStyleBackColor = true;
            this.Eight_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Five_Button
            // 
            this.Five_Button.Location = new System.Drawing.Point(137, 336);
            this.Five_Button.Name = "Five_Button";
            this.Five_Button.Size = new System.Drawing.Size(108, 108);
            this.Five_Button.TabIndex = 1;
            this.Five_Button.Text = "5";
            this.Five_Button.UseVisualStyleBackColor = true;
            this.Five_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Two_Button
            // 
            this.Two_Button.Location = new System.Drawing.Point(137, 451);
            this.Two_Button.Name = "Two_Button";
            this.Two_Button.Size = new System.Drawing.Size(108, 108);
            this.Two_Button.TabIndex = 1;
            this.Two_Button.Text = "2";
            this.Two_Button.UseVisualStyleBackColor = true;
            this.Two_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Nine_Button
            // 
            this.Nine_Button.Location = new System.Drawing.Point(251, 222);
            this.Nine_Button.Name = "Nine_Button";
            this.Nine_Button.Size = new System.Drawing.Size(129, 108);
            this.Nine_Button.TabIndex = 1;
            this.Nine_Button.Text = "9";
            this.Nine_Button.UseVisualStyleBackColor = true;
            this.Nine_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Six_Button
            // 
            this.Six_Button.Location = new System.Drawing.Point(251, 336);
            this.Six_Button.Name = "Six_Button";
            this.Six_Button.Size = new System.Drawing.Size(129, 108);
            this.Six_Button.TabIndex = 1;
            this.Six_Button.Text = "6";
            this.Six_Button.UseVisualStyleBackColor = true;
            this.Six_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Three_Button
            // 
            this.Three_Button.Location = new System.Drawing.Point(251, 451);
            this.Three_Button.Name = "Three_Button";
            this.Three_Button.Size = new System.Drawing.Size(129, 108);
            this.Three_Button.TabIndex = 1;
            this.Three_Button.Text = "3";
            this.Three_Button.UseVisualStyleBackColor = true;
            this.Three_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Dot_Button
            // 
            this.Dot_Button.Location = new System.Drawing.Point(251, 566);
            this.Dot_Button.Name = "Dot_Button";
            this.Dot_Button.Size = new System.Drawing.Size(129, 108);
            this.Dot_Button.TabIndex = 1;
            this.Dot_Button.Text = ".";
            this.Dot_Button.UseVisualStyleBackColor = true;
            this.Dot_Button.Click += new System.EventHandler(this.button_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 685);
            this.Controls.Add(this.Zero_Button);
            this.Controls.Add(this.One_Button);
            this.Controls.Add(this.Four_Button);
            this.Controls.Add(this.Seven_Button);
            this.Controls.Add(this.Equal_Button);
            this.Controls.Add(this.Addition_Button);
            this.Controls.Add(this.Minus_Button);
            this.Controls.Add(this.Multiply_Button);
            this.Controls.Add(this.Division_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Dot_Button);
            this.Controls.Add(this.Three_Button);
            this.Controls.Add(this.Six_Button);
            this.Controls.Add(this.Nine_Button);
            this.Controls.Add(this.Two_Button);
            this.Controls.Add(this.Five_Button);
            this.Controls.Add(this.Eight_Button);
            this.Controls.Add(this.Clear_Entry_Button);
            this.Controls.Add(this.textBoxResult);
            this.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button Clear_Entry_Button;
        private System.Windows.Forms.Button Seven_Button;
        private System.Windows.Forms.Button Four_Button;
        private System.Windows.Forms.Button One_Button;
        private System.Windows.Forms.Button Zero_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Division_Button;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.Button Minus_Button;
        private System.Windows.Forms.Button Addition_Button;
        private System.Windows.Forms.Button Equal_Button;
        private System.Windows.Forms.Button Eight_Button;
        private System.Windows.Forms.Button Five_Button;
        private System.Windows.Forms.Button Two_Button;
        private System.Windows.Forms.Button Nine_Button;
        private System.Windows.Forms.Button Six_Button;
        private System.Windows.Forms.Button Three_Button;
        private System.Windows.Forms.Button Dot_Button;
    }
}

