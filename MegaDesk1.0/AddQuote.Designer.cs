namespace MegaDesk1._0
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            label1 = new Label();
            customerName = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            depthNumSelect = new NumericUpDown();
            widthNumSelect = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            drawersNumSelect = new NumericUpDown();
            surfaceMaterialSelect = new DomainUpDown();
            quoteRushSelect = new DomainUpDown();
            addNewQuoteButton = new Button();
            cancelButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)depthNumSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthNumSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drawersNumSelect).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 41);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            // 
            // customerName
            // 
            customerName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.Location = new Point(233, 38);
            customerName.Name = "customerName";
            customerName.Size = new Size(418, 32);
            customerName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(depthNumSelect);
            panel1.Controls.Add(widthNumSelect);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(38, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 209);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(248, 149);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 6;
            label6.Text = "in.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(248, 70);
            label5.Name = "label5";
            label5.Size = new Size(34, 25);
            label5.TabIndex = 5;
            label5.Text = "in.";
            // 
            // depthNumSelect
            // 
            depthNumSelect.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            depthNumSelect.Location = new Point(115, 147);
            depthNumSelect.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            depthNumSelect.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            depthNumSelect.Name = "depthNumSelect";
            depthNumSelect.Size = new Size(118, 32);
            depthNumSelect.TabIndex = 5;
            depthNumSelect.TextAlign = HorizontalAlignment.Center;
            depthNumSelect.Value = new decimal(new int[] { 24, 0, 0, 0 });
            depthNumSelect.KeyDown += depthNumSelect_KeyDown;
            // 
            // widthNumSelect
            // 
            widthNumSelect.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            widthNumSelect.Location = new Point(115, 68);
            widthNumSelect.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            widthNumSelect.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
            widthNumSelect.Name = "widthNumSelect";
            widthNumSelect.Size = new Size(118, 32);
            widthNumSelect.TabIndex = 4;
            widthNumSelect.TextAlign = HorizontalAlignment.Center;
            widthNumSelect.Value = new decimal(new int[] { 24, 0, 0, 0 });
            widthNumSelect.KeyDown += widthNumSelect_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 149);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 5;
            label4.Text = "Depth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 70);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 4;
            label3.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 78);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Desk Size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(391, 127);
            label7.Name = "label7";
            label7.Size = new Size(193, 25);
            label7.TabIndex = 5;
            label7.Text = "Number of Drawers:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(422, 183);
            label8.Name = "label8";
            label8.Size = new Size(162, 25);
            label8.TabIndex = 6;
            label8.Text = "Surface Material:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(494, 237);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 7;
            label9.Text = "Delivery:";
            // 
            // drawersNumSelect
            // 
            drawersNumSelect.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            drawersNumSelect.Location = new Point(590, 125);
            drawersNumSelect.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            drawersNumSelect.Name = "drawersNumSelect";
            drawersNumSelect.Size = new Size(118, 32);
            drawersNumSelect.TabIndex = 8;
            drawersNumSelect.TextAlign = HorizontalAlignment.Center;
            drawersNumSelect.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // surfaceMaterialSelect
            // 
            surfaceMaterialSelect.BorderStyle = BorderStyle.FixedSingle;
            surfaceMaterialSelect.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            surfaceMaterialSelect.Items.Add("Oak");
            surfaceMaterialSelect.Items.Add("Laminate");
            surfaceMaterialSelect.Items.Add("Pine");
            surfaceMaterialSelect.Items.Add("Rosewood");
            surfaceMaterialSelect.Items.Add("Veneer");
            surfaceMaterialSelect.Location = new Point(590, 181);
            surfaceMaterialSelect.Name = "surfaceMaterialSelect";
            surfaceMaterialSelect.ReadOnly = true;
            surfaceMaterialSelect.Size = new Size(141, 32);
            surfaceMaterialSelect.TabIndex = 9;
            surfaceMaterialSelect.Text = "Oak";
            surfaceMaterialSelect.TextAlign = HorizontalAlignment.Center;
            // 
            // quoteRushSelect
            // 
            quoteRushSelect.BorderStyle = BorderStyle.FixedSingle;
            quoteRushSelect.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            quoteRushSelect.Items.Add("No Rush");
            quoteRushSelect.Items.Add("3 Day Rush");
            quoteRushSelect.Items.Add("5 Day Rush");
            quoteRushSelect.Items.Add("7 Day Rush");
            quoteRushSelect.Location = new Point(590, 237);
            quoteRushSelect.Name = "quoteRushSelect";
            quoteRushSelect.ReadOnly = true;
            quoteRushSelect.Size = new Size(141, 32);
            quoteRushSelect.TabIndex = 10;
            quoteRushSelect.Text = "No Rush";
            quoteRushSelect.TextAlign = HorizontalAlignment.Center;
            // 
            // addNewQuoteButton
            // 
            addNewQuoteButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addNewQuoteButton.Location = new Point(197, 327);
            addNewQuoteButton.Name = "addNewQuoteButton";
            addNewQuoteButton.Size = new Size(150, 50);
            addNewQuoteButton.TabIndex = 11;
            addNewQuoteButton.Text = "Add Quote";
            addNewQuoteButton.UseVisualStyleBackColor = true;
            addNewQuoteButton.Click += addNewQuoteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(391, 327);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 50);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 403);
            Controls.Add(cancelButton);
            Controls.Add(addNewQuoteButton);
            Controls.Add(quoteRushSelect);
            Controls.Add(surfaceMaterialSelect);
            Controls.Add(drawersNumSelect);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(customerName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddQuote";
            Text = "Add Quote";
            FormClosed += AddQuote_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)depthNumSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthNumSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)drawersNumSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox customerName;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private NumericUpDown widthNumSelect;
        private Label label6;
        private Label label5;
        private NumericUpDown depthNumSelect;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown drawersNumSelect;
        private DomainUpDown surfaceMaterialSelect;
        private DomainUpDown quoteRushSelect;
        private Button addNewQuoteButton;
        private Button cancelButton;
    }
}