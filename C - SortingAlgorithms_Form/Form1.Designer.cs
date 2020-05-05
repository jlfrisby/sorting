namespace C___SortingAlgorithms_Form
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
            this.button_SelectionSort = new System.Windows.Forms.Button();
            this.button_MergeSort = new System.Windows.Forms.Button();
            this.button_InsertionSort = new System.Windows.Forms.Button();
            this.button_BinarySearch = new System.Windows.Forms.Button();
            this.label_SelectionSort = new System.Windows.Forms.Label();
            this.label_MergeSort = new System.Windows.Forms.Label();
            this.label_InsertionSort = new System.Windows.Forms.Label();
            this.label_BinarySearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_SelectionSort
            // 
            this.button_SelectionSort.Location = new System.Drawing.Point(31, 46);
            this.button_SelectionSort.Name = "button_SelectionSort";
            this.button_SelectionSort.Size = new System.Drawing.Size(243, 104);
            this.button_SelectionSort.TabIndex = 0;
            this.button_SelectionSort.Text = "Selection Sort";
            this.button_SelectionSort.UseVisualStyleBackColor = true;
            this.button_SelectionSort.Click += new System.EventHandler(this.button_SelectionSort_Click);
            // 
            // button_MergeSort
            // 
            this.button_MergeSort.Location = new System.Drawing.Point(31, 300);
            this.button_MergeSort.Name = "button_MergeSort";
            this.button_MergeSort.Size = new System.Drawing.Size(243, 108);
            this.button_MergeSort.TabIndex = 1;
            this.button_MergeSort.Text = "Merge Sort";
            this.button_MergeSort.UseVisualStyleBackColor = true;
            this.button_MergeSort.Click += new System.EventHandler(this.button_MergeSort_Click);
            // 
            // button_InsertionSort
            // 
            this.button_InsertionSort.Location = new System.Drawing.Point(31, 748);
            this.button_InsertionSort.Name = "button_InsertionSort";
            this.button_InsertionSort.Size = new System.Drawing.Size(243, 108);
            this.button_InsertionSort.TabIndex = 2;
            this.button_InsertionSort.Text = "Insertion Sort";
            this.button_InsertionSort.UseVisualStyleBackColor = true;
            this.button_InsertionSort.Click += new System.EventHandler(this.button_InsertionSort_Click);
            // 
            // button_BinarySearch
            // 
            this.button_BinarySearch.Location = new System.Drawing.Point(974, 98);
            this.button_BinarySearch.Name = "button_BinarySearch";
            this.button_BinarySearch.Size = new System.Drawing.Size(243, 101);
            this.button_BinarySearch.TabIndex = 3;
            this.button_BinarySearch.Text = "Binary Search";
            this.button_BinarySearch.UseVisualStyleBackColor = true;
            this.button_BinarySearch.Click += new System.EventHandler(this.button_BinarySearch_Click);
            // 
            // label_SelectionSort
            // 
            this.label_SelectionSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_SelectionSort.Location = new System.Drawing.Point(335, 12);
            this.label_SelectionSort.Name = "label_SelectionSort";
            this.label_SelectionSort.Size = new System.Drawing.Size(411, 187);
            this.label_SelectionSort.TabIndex = 4;
            // 
            // label_MergeSort
            // 
            this.label_MergeSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_MergeSort.Location = new System.Drawing.Point(335, 267);
            this.label_MergeSort.Name = "label_MergeSort";
            this.label_MergeSort.Size = new System.Drawing.Size(411, 398);
            this.label_MergeSort.TabIndex = 5;
            // 
            // label_InsertionSort
            // 
            this.label_InsertionSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InsertionSort.Location = new System.Drawing.Point(335, 748);
            this.label_InsertionSort.Name = "label_InsertionSort";
            this.label_InsertionSort.Size = new System.Drawing.Size(411, 313);
            this.label_InsertionSort.TabIndex = 6;
            // 
            // label_BinarySearch
            // 
            this.label_BinarySearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_BinarySearch.Location = new System.Drawing.Point(893, 267);
            this.label_BinarySearch.Name = "label_BinarySearch";
            this.label_BinarySearch.Size = new System.Drawing.Size(411, 200);
            this.label_BinarySearch.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1860, 1245);
            this.Controls.Add(this.label_BinarySearch);
            this.Controls.Add(this.label_InsertionSort);
            this.Controls.Add(this.label_MergeSort);
            this.Controls.Add(this.label_SelectionSort);
            this.Controls.Add(this.button_BinarySearch);
            this.Controls.Add(this.button_InsertionSort);
            this.Controls.Add(this.button_MergeSort);
            this.Controls.Add(this.button_SelectionSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SelectionSort;
        private System.Windows.Forms.Button button_MergeSort;
        private System.Windows.Forms.Button button_InsertionSort;
        private System.Windows.Forms.Button button_BinarySearch;
        private System.Windows.Forms.Label label_SelectionSort;
        private System.Windows.Forms.Label label_MergeSort;
        private System.Windows.Forms.Label label_InsertionSort;
        private System.Windows.Forms.Label label_BinarySearch;
    }
}

