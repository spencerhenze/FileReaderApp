namespace Random_File_Reader
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.qtyNumbersLabel = new System.Windows.Forms.Label();
            this.qtyDisplayLabel = new System.Windows.Forms.Label();
            this.sumDisplayLabel = new System.Windows.Forms.Label();
            this.randNumListBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(38, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(203, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Random File Reader";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(108, 291);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(29, 378);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(109, 13);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total of the Numbers:";
            // 
            // qtyNumbersLabel
            // 
            this.qtyNumbersLabel.AutoSize = true;
            this.qtyNumbersLabel.Location = new System.Drawing.Point(29, 335);
            this.qtyNumbersLabel.Name = "qtyNumbersLabel";
            this.qtyNumbersLabel.Size = new System.Drawing.Size(147, 13);
            this.qtyNumbersLabel.TabIndex = 3;
            this.qtyNumbersLabel.Text = "Number of Random Numbers:";
            // 
            // qtyDisplayLabel
            // 
            this.qtyDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qtyDisplayLabel.Location = new System.Drawing.Point(194, 334);
            this.qtyDisplayLabel.Name = "qtyDisplayLabel";
            this.qtyDisplayLabel.Size = new System.Drawing.Size(68, 22);
            this.qtyDisplayLabel.TabIndex = 4;
            // 
            // sumDisplayLabel
            // 
            this.sumDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumDisplayLabel.Location = new System.Drawing.Point(194, 369);
            this.sumDisplayLabel.Name = "sumDisplayLabel";
            this.sumDisplayLabel.Size = new System.Drawing.Size(68, 22);
            this.sumDisplayLabel.TabIndex = 5;
            // 
            // randNumListBox
            // 
            this.randNumListBox.FormattingEnabled = true;
            this.randNumListBox.Location = new System.Drawing.Point(42, 81);
            this.randNumListBox.Name = "randNumListBox";
            this.randNumListBox.Size = new System.Drawing.Size(220, 186);
            this.randNumListBox.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(108, 417);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 452);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.randNumListBox);
            this.Controls.Add(this.sumDisplayLabel);
            this.Controls.Add(this.qtyDisplayLabel);
            this.Controls.Add(this.qtyNumbersLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Random File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label qtyNumbersLabel;
        private System.Windows.Forms.Label qtyDisplayLabel;
        private System.Windows.Forms.Label sumDisplayLabel;
        private System.Windows.Forms.ListBox randNumListBox;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button exitButton;
    }
}

