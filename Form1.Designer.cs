namespace coins
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
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            coinPictureBox = new PictureBox();
            countBtn = new Button();
            resultLabel = new Label();
            totalValueLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(807, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(84, 20);
            fileToolStripMenuItem.Text = "Open Image";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // coinPictureBox
            // 
            coinPictureBox.Location = new Point(12, 27);
            coinPictureBox.Name = "coinPictureBox";
            coinPictureBox.Size = new Size(336, 453);
            coinPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            coinPictureBox.TabIndex = 1;
            coinPictureBox.TabStop = false;
            // 
            // countBtn
            // 
            countBtn.Location = new Point(12, 486);
            countBtn.Name = "countBtn";
            countBtn.Size = new Size(336, 25);
            countBtn.TabIndex = 2;
            countBtn.Text = "Count Coins";
            countBtn.UseVisualStyleBackColor = true;
            countBtn.Click += countBtn_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(374, 229);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(91, 15);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "TOTAL COINS = ";
            // 
            // totalValueLabel
            // 
            totalValueLabel.AutoSize = true;
            totalValueLabel.Location = new Point(374, 256);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(87, 15);
            totalValueLabel.TabIndex = 5;
            totalValueLabel.Text = "TOTAL VALUE =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 562);
            Controls.Add(totalValueLabel);
            Controls.Add(resultLabel);
            Controls.Add(countBtn);
            Controls.Add(coinPictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private PictureBox coinPictureBox;
        private Button countBtn;
        private Label resultLabel;
        private Label totalValueLabel;
    }
}
