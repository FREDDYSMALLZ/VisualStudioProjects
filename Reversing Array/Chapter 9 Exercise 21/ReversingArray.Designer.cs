namespace Chapter_9_Exercise_21
{
    partial class ReversingArray
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
            this.AddArray = new System.Windows.Forms.Button();
            this.SortArray = new System.Windows.Forms.Button();
            this.ReverseArray = new System.Windows.Forms.Button();
            this.ChartDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddArray
            // 
            this.AddArray.Location = new System.Drawing.Point(448, 33);
            this.AddArray.Name = "AddArray";
            this.AddArray.Size = new System.Drawing.Size(269, 86);
            this.AddArray.TabIndex = 1;
            this.AddArray.Text = "Add Array";
            this.AddArray.UseVisualStyleBackColor = true;
            this.AddArray.Click += new System.EventHandler(this.Button_Click);
            // 
            // SortArray
            // 
            this.SortArray.Location = new System.Drawing.Point(448, 136);
            this.SortArray.Name = "SortArray";
            this.SortArray.Size = new System.Drawing.Size(269, 86);
            this.SortArray.TabIndex = 1;
            this.SortArray.Text = "Sort Array";
            this.SortArray.UseVisualStyleBackColor = true;
            this.SortArray.Click += new System.EventHandler(this.Button_Click);
            // 
            // ReverseArray
            // 
            this.ReverseArray.Location = new System.Drawing.Point(408, 421);
            this.ReverseArray.Name = "ReverseArray";
            this.ReverseArray.Size = new System.Drawing.Size(309, 98);
            this.ReverseArray.TabIndex = 1;
            this.ReverseArray.Text = "Reverse Array";
            this.ReverseArray.UseVisualStyleBackColor = true;
            this.ReverseArray.Click += new System.EventHandler(this.Button_Click);
            // 
            // ChartDisplay
            // 
            this.ChartDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartDisplay.FormattingEnabled = true;
            this.ChartDisplay.ItemHeight = 37;
            this.ChartDisplay.Location = new System.Drawing.Point(-2, 0);
            this.ChartDisplay.Name = "ChartDisplay";
            this.ChartDisplay.Size = new System.Drawing.Size(393, 485);
            this.ChartDisplay.TabIndex = 0;
            this.ChartDisplay.SelectedIndexChanged += new System.EventHandler(this.ChartDisplay_SelectedIndexChanged);
            // 
            // ReversingArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 524);
            this.Controls.Add(this.ReverseArray);
            this.Controls.Add(this.SortArray);
            this.Controls.Add(this.AddArray);
            this.Controls.Add(this.ChartDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ReversingArray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversing Array ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddArray;
        private System.Windows.Forms.Button SortArray;
        private System.Windows.Forms.Button ReverseArray;
        private System.Windows.Forms.ListBox ChartDisplay;
    }
}

