namespace MegaDesk1._0
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            addNewQuoteButton = new Button();
            viewAllQuoteButton = new Button();
            searchQuoteButton = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addNewQuoteButton
            // 
            addNewQuoteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addNewQuoteButton.Location = new Point(75, 52);
            addNewQuoteButton.Name = "addNewQuoteButton";
            addNewQuoteButton.Size = new Size(150, 50);
            addNewQuoteButton.TabIndex = 0;
            addNewQuoteButton.Text = "Add New Quote";
            addNewQuoteButton.UseVisualStyleBackColor = true;
            addNewQuoteButton.Click += addNewQuoteButton_Click;
            // 
            // viewAllQuoteButton
            // 
            viewAllQuoteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            viewAllQuoteButton.Location = new Point(75, 137);
            viewAllQuoteButton.Name = "viewAllQuoteButton";
            viewAllQuoteButton.Size = new Size(150, 50);
            viewAllQuoteButton.TabIndex = 1;
            viewAllQuoteButton.Text = "View Quotes";
            viewAllQuoteButton.UseVisualStyleBackColor = true;
            viewAllQuoteButton.Click += viewAllQuoteButton_Click;
            // 
            // searchQuoteButton
            // 
            searchQuoteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchQuoteButton.Location = new Point(75, 219);
            searchQuoteButton.Name = "searchQuoteButton";
            searchQuoteButton.Size = new Size(150, 50);
            searchQuoteButton.TabIndex = 2;
            searchQuoteButton.Text = "Search Quote";
            searchQuoteButton.UseVisualStyleBackColor = true;
            searchQuoteButton.Click += searchQuoteButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(75, 304);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 50);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.desk_picture;
            pictureBox1.Location = new Point(332, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 450);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 403);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(searchQuoteButton);
            Controls.Add(viewAllQuoteButton);
            Controls.Add(addNewQuoteButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "MegaDesk1.0";
            FormClosed += MainMenu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addNewQuoteButton;
        private Button viewAllQuoteButton;
        private Button searchQuoteButton;
        private Button exitButton;
        private PictureBox pictureBox1;
    }
}