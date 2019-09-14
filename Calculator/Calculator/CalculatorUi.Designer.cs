namespace Calculator
{
    partial class CalculatorUi
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
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.resutLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Location = new System.Drawing.Point(63, 48);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.firstNumberLabel.TabIndex = 0;
            this.firstNumberLabel.Text = "First Number";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Location = new System.Drawing.Point(63, 82);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.secondNumberLabel.TabIndex = 1;
            this.secondNumberLabel.Text = "Second Number";
            // 
            // resutLabel
            // 
            this.resutLabel.AutoSize = true;
            this.resutLabel.Location = new System.Drawing.Point(63, 115);
            this.resutLabel.Name = "resutLabel";
            this.resutLabel.Size = new System.Drawing.Size(37, 13);
            this.resutLabel.TabIndex = 2;
            this.resutLabel.Text = "Result";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(66, 146);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(147, 146);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 4;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(228, 146);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 5;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(309, 146);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 6;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(147, 48);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(187, 20);
            this.firstNumberTextBox.TabIndex = 7;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(147, 82);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(187, 20);
            this.secondTextBox.TabIndex = 8;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(147, 115);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(187, 20);
            this.resultTextBox.TabIndex = 9;
            // 
            // CalculatorUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 200);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resutLabel);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.firstNumberLabel);
            this.Name = "CalculatorUi";
            this.Text = "Calculator Ui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.Label resutLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

