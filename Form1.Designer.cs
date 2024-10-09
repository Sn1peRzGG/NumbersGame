namespace NumbersGame
{
    partial class NumbersGameForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(210, 10);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 22);
            this.inputTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.instructionLabel.Location = new System.Drawing.Point(10, 10);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(178, 25);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Guess the number:";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(430, 10);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(100, 30);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resultLabel.Location = new System.Drawing.Point(10, 50);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(67, 20);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result: ";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(536, 10);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(100, 30);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // NumbersGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.inputTextBox);
            this.Name = "NumbersGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numbers Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button restartButton;
    }
}
