namespace Brown2D
{
    partial class Brown2D
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
            brownPictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            minBoundTextBox = new TextBox();
            maxBoundTextBox = new TextBox();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)brownPictureBox).BeginInit();
            SuspendLayout();
            // 
            // brownPictureBox
            // 
            brownPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            brownPictureBox.Location = new Point(454, 68);
            brownPictureBox.Name = "brownPictureBox";
            brownPictureBox.Size = new Size(300, 300);
            brownPictureBox.TabIndex = 0;
            brownPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 1;
            label1.Text = "Minimum Bound";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 139);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Maximum Bound";
            // 
            // minBoundTextBox
            // 
            minBoundTextBox.Location = new Point(28, 91);
            minBoundTextBox.Name = "minBoundTextBox";
            minBoundTextBox.Size = new Size(125, 27);
            minBoundTextBox.TabIndex = 3;
            // 
            // maxBoundTextBox
            // 
            maxBoundTextBox.Location = new Point(28, 162);
            maxBoundTextBox.Name = "maxBoundTextBox";
            maxBoundTextBox.Size = new Size(125, 27);
            maxBoundTextBox.TabIndex = 4;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(255, 128, 128);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(28, 261);
            startButton.Name = "startButton";
            startButton.Size = new Size(188, 107);
            startButton.TabIndex = 5;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(startButton);
            Controls.Add(maxBoundTextBox);
            Controls.Add(minBoundTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(brownPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)brownPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox brownPictureBox;
        private Label label1;
        private Label label2;
        private TextBox minBoundTextBox;
        private TextBox maxBoundTextBox;
        private Button startButton;
    }
}
