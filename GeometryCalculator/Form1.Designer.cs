namespace GeometryCalculator
{
    partial class Form1
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
            lblLength = new Label();
            lblWidth = new Label();
            TxtLength = new TextBox();
            TxtWidth = new TextBox();
            lblArea = new Label();
            textBox3 = new TextBox();
            btnCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            TxtRadius = new TextBox();
            TxtCircumference = new TextBox();
            lblRectangle = new Label();
            lblCircle = new Label();
            lblArea2 = new Label();
            TxtArea2 = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(12, 44);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(57, 20);
            lblLength.TabIndex = 0;
            lblLength.Text = "Length:";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(12, 82);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(52, 20);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width:";
            // 
            // TxtLength
            // 
            TxtLength.Location = new Point(87, 37);
            TxtLength.Name = "TxtLength";
            TxtLength.Size = new Size(125, 27);
            TxtLength.TabIndex = 2;
            // 
            // TxtWidth
            // 
            TxtWidth.Location = new Point(87, 75);
            TxtWidth.Name = "TxtWidth";
            TxtWidth.Size = new Size(125, 27);
            TxtWidth.TabIndex = 3;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(12, 126);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(43, 20);
            lblArea.TabIndex = 4;
            lblArea.Text = "Area:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 126);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(152, 218);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 44);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Radius:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 82);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 8;
            label2.Text = "Circumference:";
            // 
            // TxtRadius
            // 
            TxtRadius.Location = new Point(489, 41);
            TxtRadius.Name = "TxtRadius";
            TxtRadius.Size = new Size(125, 27);
            TxtRadius.TabIndex = 9;
            // 
            // TxtCircumference
            // 
            TxtCircumference.Location = new Point(489, 79);
            TxtCircumference.Name = "TxtCircumference";
            TxtCircumference.ReadOnly = true;
            TxtCircumference.Size = new Size(125, 27);
            TxtCircumference.TabIndex = 10;
            // 
            // lblRectangle
            // 
            lblRectangle.AutoSize = true;
            lblRectangle.Location = new Point(107, 10);
            lblRectangle.Name = "lblRectangle";
            lblRectangle.Size = new Size(78, 20);
            lblRectangle.TabIndex = 11;
            lblRectangle.Text = "Rectangle:";
            // 
            // lblCircle
            // 
            lblCircle.AutoSize = true;
            lblCircle.Location = new Point(489, 10);
            lblCircle.Name = "lblCircle";
            lblCircle.Size = new Size(49, 20);
            lblCircle.TabIndex = 12;
            lblCircle.Text = "Circle:";
            lblCircle.Click += lblCircle_Click;
            // 
            // lblArea2
            // 
            lblArea2.AutoSize = true;
            lblArea2.Location = new Point(378, 132);
            lblArea2.Name = "lblArea2";
            lblArea2.Size = new Size(43, 20);
            lblArea2.TabIndex = 13;
            lblArea2.Text = "Area:";
            // 
            // TxtArea2
            // 
            TxtArea2.Location = new Point(489, 126);
            TxtArea2.Name = "TxtArea2";
            TxtArea2.ReadOnly = true;
            TxtArea2.Size = new Size(125, 27);
            TxtArea2.TabIndex = 14;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(386, 220);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(TxtArea2);
            Controls.Add(lblArea2);
            Controls.Add(lblCircle);
            Controls.Add(lblRectangle);
            Controls.Add(TxtCircumference);
            Controls.Add(TxtRadius);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Controls.Add(textBox3);
            Controls.Add(lblArea);
            Controls.Add(TxtWidth);
            Controls.Add(TxtLength);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Name = "Form1";
            Text = "Geometry Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLength;
        private Label lblWidth;
        private TextBox TxtLength;
        private TextBox TxtWidth;
        private Label lblArea;
        private TextBox textBox3;
        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private TextBox TxtRadius;
        private TextBox TxtCircumference;
        private Label lblRectangle;
        private Label lblCircle;
        private Label lblArea2;
        private TextBox TxtArea2;
        private Button btnExit;
    }
}
