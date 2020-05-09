namespace Sorting
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.originalLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.originalOutput = new System.Windows.Forms.TextBox();
            this.sortedOutput = new System.Windows.Forms.TextBox();
            this.tenButton = new System.Windows.Forms.RadioButton();
            this.hundredButton = new System.Windows.Forms.RadioButton();
            this.thousandButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fiveThousandButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.selectionOutput = new System.Windows.Forms.Label();
            this.bubbleOutput = new System.Windows.Forms.Label();
            this.insertionOutput = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.sortTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.Location = new System.Drawing.Point(38, 64);
            this.originalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(206, 36);
            this.originalLabel.TabIndex = 3;
            this.originalLabel.Text = "Original Array";
            // 
            // sortedLabel
            // 
            this.sortedLabel.AutoSize = true;
            this.sortedLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedLabel.Location = new System.Drawing.Point(266, 64);
            this.sortedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(187, 36);
            this.sortedLabel.TabIndex = 4;
            this.sortedLabel.Text = "Sorted Array";
            // 
            // originalOutput
            // 
            this.originalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.originalOutput.Location = new System.Drawing.Point(81, 107);
            this.originalOutput.Multiline = true;
            this.originalOutput.Name = "originalOutput";
            this.originalOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalOutput.Size = new System.Drawing.Size(92, 294);
            this.originalOutput.TabIndex = 5;
            // 
            // sortedOutput
            // 
            this.sortedOutput.Location = new System.Drawing.Point(303, 113);
            this.sortedOutput.Multiline = true;
            this.sortedOutput.Name = "sortedOutput";
            this.sortedOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sortedOutput.Size = new System.Drawing.Size(94, 294);
            this.sortedOutput.TabIndex = 6;
            // 
            // tenButton
            // 
            this.tenButton.AutoSize = true;
            this.tenButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenButton.Location = new System.Drawing.Point(557, 10);
            this.tenButton.Name = "tenButton";
            this.tenButton.Size = new System.Drawing.Size(87, 45);
            this.tenButton.TabIndex = 7;
            this.tenButton.TabStop = true;
            this.tenButton.Text = "10";
            this.tenButton.UseVisualStyleBackColor = true;
            // 
            // hundredButton
            // 
            this.hundredButton.AutoSize = true;
            this.hundredButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredButton.Location = new System.Drawing.Point(668, 10);
            this.hundredButton.Name = "hundredButton";
            this.hundredButton.Size = new System.Drawing.Size(106, 45);
            this.hundredButton.TabIndex = 8;
            this.hundredButton.TabStop = true;
            this.hundredButton.Text = "100";
            this.hundredButton.UseVisualStyleBackColor = true;
            // 
            // thousandButton
            // 
            this.thousandButton.AutoSize = true;
            this.thousandButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thousandButton.Location = new System.Drawing.Point(795, 12);
            this.thousandButton.Name = "thousandButton";
            this.thousandButton.Size = new System.Drawing.Size(125, 45);
            this.thousandButton.TabIndex = 9;
            this.thousandButton.TabStop = true;
            this.thousandButton.Text = "1000";
            this.thousandButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ammount of numbers in the list";
            // 
            // fiveThousandButton
            // 
            this.fiveThousandButton.AutoSize = true;
            this.fiveThousandButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveThousandButton.Location = new System.Drawing.Point(960, 12);
            this.fiveThousandButton.Name = "fiveThousandButton";
            this.fiveThousandButton.Size = new System.Drawing.Size(125, 45);
            this.fiveThousandButton.TabIndex = 11;
            this.fiveThousandButton.TabStop = true;
            this.fiveThousandButton.Text = "5000";
            this.fiveThousandButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Efficiency Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.label3.Location = new System.Drawing.Point(39, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of times that a loop is executed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.label4.Location = new System.Drawing.Point(14, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Number of times that a comparison is made";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.label5.Location = new System.Drawing.Point(14, 641);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(721, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number of times that a value is shifted from one location to another";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.label6.Location = new System.Drawing.Point(14, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(645, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Actual time, in milliseconds, that it took to complete the sort ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label7.Location = new System.Drawing.Point(760, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = " Selection";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label8.Location = new System.Drawing.Point(954, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "Bubble";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label9.Location = new System.Drawing.Point(1108, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 33);
            this.label9.TabIndex = 19;
            this.label9.Text = "Insertion";
            // 
            // selectionOutput
            // 
            this.selectionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.selectionOutput.Location = new System.Drawing.Point(771, 525);
            this.selectionOutput.Name = "selectionOutput";
            this.selectionOutput.Size = new System.Drawing.Size(178, 262);
            this.selectionOutput.TabIndex = 20;
            // 
            // bubbleOutput
            // 
            this.bubbleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.bubbleOutput.Location = new System.Drawing.Point(955, 528);
            this.bubbleOutput.Name = "bubbleOutput";
            this.bubbleOutput.Size = new System.Drawing.Size(137, 217);
            this.bubbleOutput.TabIndex = 21;
            // 
            // insertionOutput
            // 
            this.insertionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.insertionOutput.Location = new System.Drawing.Point(1109, 528);
            this.insertionOutput.Name = "insertionOutput";
            this.insertionOutput.Size = new System.Drawing.Size(137, 217);
            this.insertionOutput.TabIndex = 22;
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(1116, 10);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(123, 48);
            this.sortButton.TabIndex = 23;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // sortTimer
            // 
            this.sortTimer.Enabled = true;
            this.sortTimer.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 738);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fiveThousandButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thousandButton);
            this.Controls.Add(this.hundredButton);
            this.Controls.Add(this.tenButton);
            this.Controls.Add(this.sortedOutput);
            this.Controls.Add(this.originalOutput);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.selectionOutput);
            this.Controls.Add(this.insertionOutput);
            this.Controls.Add(this.bubbleOutput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sorting Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label sortedLabel;
        private System.Windows.Forms.TextBox originalOutput;
        private System.Windows.Forms.TextBox sortedOutput;
        private System.Windows.Forms.RadioButton tenButton;
        private System.Windows.Forms.RadioButton hundredButton;
        private System.Windows.Forms.RadioButton thousandButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fiveThousandButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label selectionOutput;
        private System.Windows.Forms.Label bubbleOutput;
        private System.Windows.Forms.Label insertionOutput;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Timer sortTimer;
    }
}

