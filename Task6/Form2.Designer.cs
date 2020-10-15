namespace Task6
{
    partial class Form2
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
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ownedAmountLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.shelvesAmountLabel = new System.Windows.Forms.Label();
            this.amountOfBooksLabel = new System.Windows.Forms.Label();
            this.maxAmountOfBooksLabel = new System.Windows.Forms.Label();
            this.addToListButton = new System.Windows.Forms.Button();
            this.indexLabel = new System.Windows.Forms.Label();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.shelvesAmountTextBox = new System.Windows.Forms.TextBox();
            this.amountOfBooksTextBox = new System.Windows.Forms.TextBox();
            this.maxAmountOfBooksTextBox = new System.Windows.Forms.TextBox();
            this.bookClosetLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ownedAmountTextBox = new System.Windows.Forms.TextBox();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(312, 12);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(476, 533);
            this.outputRichTextBox.TabIndex = 0;
            this.outputRichTextBox.Text = "";
            // 
            // ownedAmountLabel
            // 
            this.ownedAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ownedAmountLabel.Location = new System.Drawing.Point(60, 63);
            this.ownedAmountLabel.Name = "ownedAmountLabel";
            this.ownedAmountLabel.Size = new System.Drawing.Size(157, 25);
            this.ownedAmountLabel.TabIndex = 1;
            this.ownedAmountLabel.Text = "Owned amount";
            // 
            // volumeLabel
            // 
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.volumeLabel.Location = new System.Drawing.Point(123, 95);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(93, 25);
            this.volumeLabel.TabIndex = 2;
            this.volumeLabel.Text = "Volume\r\n";
            // 
            // shelvesAmountLabel
            // 
            this.shelvesAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.shelvesAmountLabel.Location = new System.Drawing.Point(49, 129);
            this.shelvesAmountLabel.Name = "shelvesAmountLabel";
            this.shelvesAmountLabel.Size = new System.Drawing.Size(167, 25);
            this.shelvesAmountLabel.TabIndex = 3;
            this.shelvesAmountLabel.Text = "Shelves amount\r\n";
            // 
            // amountOfBooksLabel
            // 
            this.amountOfBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.amountOfBooksLabel.Location = new System.Drawing.Point(40, 164);
            this.amountOfBooksLabel.Name = "amountOfBooksLabel";
            this.amountOfBooksLabel.Size = new System.Drawing.Size(177, 30);
            this.amountOfBooksLabel.TabIndex = 4;
            this.amountOfBooksLabel.Text = "Amount of books\r\n";
            // 
            // maxAmountOfBooksLabel
            // 
            this.maxAmountOfBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.maxAmountOfBooksLabel.Location = new System.Drawing.Point(1, 198);
            this.maxAmountOfBooksLabel.Name = "maxAmountOfBooksLabel";
            this.maxAmountOfBooksLabel.Size = new System.Drawing.Size(216, 30);
            this.maxAmountOfBooksLabel.TabIndex = 5;
            this.maxAmountOfBooksLabel.Text = "Max amount of books\r\n";
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(140, 243);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(142, 46);
            this.addToListButton.TabIndex = 6;
            this.addToListButton.Text = "Add to list";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // indexLabel
            // 
            this.indexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.indexLabel.Location = new System.Drawing.Point(34, 400);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(83, 34);
            this.indexLabel.TabIndex = 7;
            this.indexLabel.Text = "Index\r\n\r\n";
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(40, 434);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(60, 26);
            this.indexTextBox.TabIndex = 8;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(123, 356);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(132, 37);
            this.buyButton.TabIndex = 13;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(123, 399);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(132, 37);
            this.sellButton.TabIndex = 15;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(222, 94);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(60, 26);
            this.volumeTextBox.TabIndex = 18;
            // 
            // shelvesAmountTextBox
            // 
            this.shelvesAmountTextBox.Location = new System.Drawing.Point(222, 128);
            this.shelvesAmountTextBox.Name = "shelvesAmountTextBox";
            this.shelvesAmountTextBox.Size = new System.Drawing.Size(60, 26);
            this.shelvesAmountTextBox.TabIndex = 19;
            // 
            // amountOfBooksTextBox
            // 
            this.amountOfBooksTextBox.Location = new System.Drawing.Point(222, 164);
            this.amountOfBooksTextBox.Name = "amountOfBooksTextBox";
            this.amountOfBooksTextBox.Size = new System.Drawing.Size(60, 26);
            this.amountOfBooksTextBox.TabIndex = 20;
            // 
            // maxAmountOfBooksTextBox
            // 
            this.maxAmountOfBooksTextBox.Location = new System.Drawing.Point(222, 199);
            this.maxAmountOfBooksTextBox.Name = "maxAmountOfBooksTextBox";
            this.maxAmountOfBooksTextBox.Size = new System.Drawing.Size(60, 26);
            this.maxAmountOfBooksTextBox.TabIndex = 21;
            // 
            // bookClosetLabel
            // 
            this.bookClosetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.bookClosetLabel.Location = new System.Drawing.Point(76, 12);
            this.bookClosetLabel.Name = "bookClosetLabel";
            this.bookClosetLabel.Size = new System.Drawing.Size(192, 39);
            this.bookClosetLabel.TabIndex = 25;
            this.bookClosetLabel.Text = "Book closet";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 4);
            this.panel1.TabIndex = 26;
            // 
            // ownedAmountTextBox
            // 
            this.ownedAmountTextBox.Location = new System.Drawing.Point(222, 62);
            this.ownedAmountTextBox.Name = "ownedAmountTextBox";
            this.ownedAmountTextBox.Size = new System.Drawing.Size(60, 26);
            this.ownedAmountTextBox.TabIndex = 27;
            // 
            // removeBookButton
            // 
            this.removeBookButton.Location = new System.Drawing.Point(123, 485);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(132, 37);
            this.removeBookButton.TabIndex = 29;
            this.removeBookButton.Text = "Remove book";
            this.removeBookButton.UseVisualStyleBackColor = true;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(123, 442);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(132, 37);
            this.addBookButton.TabIndex = 28;
            this.addBookButton.Text = "Add book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.ownedAmountTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookClosetLabel);
            this.Controls.Add(this.maxAmountOfBooksTextBox);
            this.Controls.Add(this.amountOfBooksTextBox);
            this.Controls.Add(this.shelvesAmountTextBox);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.indexTextBox);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.maxAmountOfBooksLabel);
            this.Controls.Add(this.amountOfBooksLabel);
            this.Controls.Add(this.shelvesAmountLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.ownedAmountLabel);
            this.Controls.Add(this.outputRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Task6.2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button removeBookButton;

        private System.Windows.Forms.TextBox indexTextBox;

        private System.Windows.Forms.Label ownedAmountLabel;
        private System.Windows.Forms.TextBox ownedAmountTextBox;

        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Label amountOfBooksLabel;
        private System.Windows.Forms.TextBox amountOfBooksTextBox;
        private System.Windows.Forms.Label bookClosetLabel;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label maxAmountOfBooksLabel;
        private System.Windows.Forms.TextBox maxAmountOfBooksTextBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label shelvesAmountLabel;
        private System.Windows.Forms.TextBox shelvesAmountTextBox;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TextBox volumeTextBox;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}