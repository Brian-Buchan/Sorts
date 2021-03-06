﻿namespace Sorts
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
            this.ArrayView = new System.Windows.Forms.ListBox();
            this.InsertionSort = new System.Windows.Forms.Button();
            this.SelectionSort = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.GenArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ArraySize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.swapsTXT = new System.Windows.Forms.TextBox();
            this.comparisonsTXT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ArraySize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArrayView
            // 
            this.ArrayView.FormattingEnabled = true;
            this.ArrayView.Location = new System.Drawing.Point(31, 93);
            this.ArrayView.Name = "ArrayView";
            this.ArrayView.Size = new System.Drawing.Size(490, 212);
            this.ArrayView.TabIndex = 0;
            // 
            // InsertionSort
            // 
            this.InsertionSort.Location = new System.Drawing.Point(53, 311);
            this.InsertionSort.Name = "InsertionSort";
            this.InsertionSort.Size = new System.Drawing.Size(130, 23);
            this.InsertionSort.TabIndex = 1;
            this.InsertionSort.Text = "Insertion Sort";
            this.InsertionSort.UseVisualStyleBackColor = true;
            this.InsertionSort.Click += new System.EventHandler(this.InsertionSort_Click);
            // 
            // SelectionSort
            // 
            this.SelectionSort.Location = new System.Drawing.Point(218, 311);
            this.SelectionSort.Name = "SelectionSort";
            this.SelectionSort.Size = new System.Drawing.Size(130, 23);
            this.SelectionSort.TabIndex = 2;
            this.SelectionSort.Text = "Selection Sort";
            this.SelectionSort.UseVisualStyleBackColor = true;
            this.SelectionSort.Click += new System.EventHandler(this.SelectionSort_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(381, 311);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(130, 23);
            this.BubbleSort.TabIndex = 3;
            this.BubbleSort.Text = "Bubble Sort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // GenArray
            // 
            this.GenArray.Location = new System.Drawing.Point(31, 12);
            this.GenArray.Name = "GenArray";
            this.GenArray.Size = new System.Drawing.Size(130, 23);
            this.GenArray.TabIndex = 4;
            this.GenArray.Text = "Generate New Array";
            this.GenArray.UseVisualStyleBackColor = true;
            this.GenArray.Click += new System.EventHandler(this.GenArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Array Size:";
            // 
            // ArraySize
            // 
            this.ArraySize.Location = new System.Drawing.Point(94, 49);
            this.ArraySize.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.ArraySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArraySize.Name = "ArraySize";
            this.ArraySize.Size = new System.Drawing.Size(120, 20);
            this.ArraySize.TabIndex = 6;
            this.ArraySize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "# of Swaps:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "# of Comparisons:";
            // 
            // swapsTXT
            // 
            this.swapsTXT.Location = new System.Drawing.Point(120, 366);
            this.swapsTXT.Name = "swapsTXT";
            this.swapsTXT.ReadOnly = true;
            this.swapsTXT.Size = new System.Drawing.Size(100, 20);
            this.swapsTXT.TabIndex = 9;
            // 
            // comparisonsTXT
            // 
            this.comparisonsTXT.Location = new System.Drawing.Point(382, 366);
            this.comparisonsTXT.Name = "comparisonsTXT";
            this.comparisonsTXT.ReadOnly = true;
            this.comparisonsTXT.Size = new System.Drawing.Size(100, 20);
            this.comparisonsTXT.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(356, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Order";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Descending";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ascending";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comparisonsTXT);
            this.Controls.Add(this.swapsTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArraySize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenArray);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.SelectionSort);
            this.Controls.Add(this.InsertionSort);
            this.Controls.Add(this.ArrayView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ArraySize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ArrayView;
        private System.Windows.Forms.Button InsertionSort;
        private System.Windows.Forms.Button SelectionSort;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button GenArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ArraySize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox swapsTXT;
        private System.Windows.Forms.TextBox comparisonsTXT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

