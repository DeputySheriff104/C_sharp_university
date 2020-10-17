namespace Task2
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
            this.chooseTextFileButton = new System.Windows.Forms.Button();
            this.richTextBoxTextFileInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textFileLabel = new System.Windows.Forms.Label();
            this.numberFileLabel = new System.Windows.Forms.Label();
            this.richTextBoxNumbersFileInput = new System.Windows.Forms.RichTextBox();
            this.chooseNumbersFileButton = new System.Windows.Forms.Button();
            this.toRightButton = new System.Windows.Forms.Button();
            this.toBothButton = new System.Windows.Forms.Button();
            this.toLeftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseTextFileButton
            // 
            this.chooseTextFileButton.Location = new System.Drawing.Point(12, 400);
            this.chooseTextFileButton.Name = "chooseTextFileButton";
            this.chooseTextFileButton.Size = new System.Drawing.Size(178, 38);
            this.chooseTextFileButton.TabIndex = 1;
            this.chooseTextFileButton.Text = "Choose text file";
            this.chooseTextFileButton.UseVisualStyleBackColor = true;
            this.chooseTextFileButton.Click += new System.EventHandler(this.chooseTextFileButton_Click);
            // 
            // richTextBoxTextFileInput
            // 
            this.richTextBoxTextFileInput.Location = new System.Drawing.Point(12, 52);
            this.richTextBoxTextFileInput.Name = "richTextBoxTextFileInput";
            this.richTextBoxTextFileInput.Size = new System.Drawing.Size(383, 159);
            this.richTextBoxTextFileInput.TabIndex = 2;
            this.richTextBoxTextFileInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 217);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(776, 177);
            this.richTextBoxOutput.TabIndex = 3;
            this.richTextBoxOutput.Text = "";
            // 
            // textFileLabel
            // 
            this.textFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textFileLabel.Location = new System.Drawing.Point(12, 9);
            this.textFileLabel.Name = "textFileLabel";
            this.textFileLabel.Size = new System.Drawing.Size(138, 40);
            this.textFileLabel.TabIndex = 4;
            this.textFileLabel.Text = "Text file";
            // 
            // numberFileLabel
            // 
            this.numberFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.numberFileLabel.Location = new System.Drawing.Point(405, 9);
            this.numberFileLabel.Name = "numberFileLabel";
            this.numberFileLabel.Size = new System.Drawing.Size(215, 40);
            this.numberFileLabel.TabIndex = 5;
            this.numberFileLabel.Text = "Numbers file";
            // 
            // richTextBoxNumbersFileInput
            // 
            this.richTextBoxNumbersFileInput.Location = new System.Drawing.Point(405, 52);
            this.richTextBoxNumbersFileInput.Name = "richTextBoxNumbersFileInput";
            this.richTextBoxNumbersFileInput.Size = new System.Drawing.Size(383, 159);
            this.richTextBoxNumbersFileInput.TabIndex = 6;
            this.richTextBoxNumbersFileInput.Text = "";
            // 
            // chooseNumbersFileButton
            // 
            this.chooseNumbersFileButton.Location = new System.Drawing.Point(196, 400);
            this.chooseNumbersFileButton.Name = "chooseNumbersFileButton";
            this.chooseNumbersFileButton.Size = new System.Drawing.Size(178, 38);
            this.chooseNumbersFileButton.TabIndex = 7;
            this.chooseNumbersFileButton.Text = "Choose numbers file";
            this.chooseNumbersFileButton.UseVisualStyleBackColor = true;
            this.chooseNumbersFileButton.Click += new System.EventHandler(this.chooseNumbersFileButton_Click);
            // 
            // toRightButton
            // 
            this.toRightButton.Location = new System.Drawing.Point(695, 400);
            this.toRightButton.Name = "toRightButton";
            this.toRightButton.Size = new System.Drawing.Size(93, 38);
            this.toRightButton.TabIndex = 8;
            this.toRightButton.Text = "To right";
            this.toRightButton.UseVisualStyleBackColor = true;
            this.toRightButton.Click += new System.EventHandler(this.toRightButton_Click);
            // 
            // toBothButton
            // 
            this.toBothButton.Location = new System.Drawing.Point(596, 400);
            this.toBothButton.Name = "toBothButton";
            this.toBothButton.Size = new System.Drawing.Size(93, 38);
            this.toBothButton.TabIndex = 9;
            this.toBothButton.Text = "To both";
            this.toBothButton.UseVisualStyleBackColor = true;
            this.toBothButton.Click += new System.EventHandler(this.toBothButton_Click);
            // 
            // toLeftButton
            // 
            this.toLeftButton.Location = new System.Drawing.Point(497, 400);
            this.toLeftButton.Name = "toLeftButton";
            this.toLeftButton.Size = new System.Drawing.Size(93, 38);
            this.toLeftButton.TabIndex = 10;
            this.toLeftButton.Text = "To left";
            this.toLeftButton.UseVisualStyleBackColor = true;
            this.toLeftButton.Click += new System.EventHandler(this.toLeftButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toLeftButton);
            this.Controls.Add(this.toBothButton);
            this.Controls.Add(this.toRightButton);
            this.Controls.Add(this.chooseNumbersFileButton);
            this.Controls.Add(this.richTextBoxNumbersFileInput);
            this.Controls.Add(this.numberFileLabel);
            this.Controls.Add(this.textFileLabel);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxTextFileInput);
            this.Controls.Add(this.chooseTextFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Task2";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button toBothButton;
        private System.Windows.Forms.Button toLeftButton;
        private System.Windows.Forms.Button toRightButton;

        private System.Windows.Forms.Button chooseNumbersFileButton;
        private System.Windows.Forms.Button chooseTextFileButton;

        private System.Windows.Forms.Label numberFileLabel;
        private System.Windows.Forms.Label textFileLabel;

        private System.Windows.Forms.RichTextBox richTextBoxNumbersFileInput;
        private System.Windows.Forms.RichTextBox richTextBoxTextFileInput;

        private System.Windows.Forms.RichTextBox richTextBoxOutput;

        #endregion
    }
}