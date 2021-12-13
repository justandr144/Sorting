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
            this.originalOutput = new System.Windows.Forms.Label();
            this.sortedOutput = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalOutput
            // 
            this.originalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalOutput.Location = new System.Drawing.Point(28, 55);
            this.originalOutput.Name = "originalOutput";
            this.originalOutput.Size = new System.Drawing.Size(130, 250);
            this.originalOutput.TabIndex = 1;
            this.originalOutput.Text = "label1";
            this.originalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortedOutput
            // 
            this.sortedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedOutput.Location = new System.Drawing.Point(215, 55);
            this.sortedOutput.Name = "sortedOutput";
            this.sortedOutput.Size = new System.Drawing.Size(121, 250);
            this.sortedOutput.TabIndex = 2;
            this.sortedOutput.Text = "label1";
            this.sortedOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.Location = new System.Drawing.Point(27, 30);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(131, 25);
            this.originalLabel.TabIndex = 3;
            this.originalLabel.Text = "Original Array";
            // 
            // sortedLabel
            // 
            this.sortedLabel.AutoSize = true;
            this.sortedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedLabel.Location = new System.Drawing.Point(214, 30);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(122, 25);
            this.sortedLabel.TabIndex = 4;
            this.sortedLabel.Text = "Sorted Array";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 342);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.sortedOutput);
            this.Controls.Add(this.originalOutput);
            this.Name = "Form1";
            this.Text = "Sorting Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label originalOutput;
        private System.Windows.Forms.Label sortedOutput;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label sortedLabel;
    }
}

