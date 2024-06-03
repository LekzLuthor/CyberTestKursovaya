namespace CyberTestKursovaya
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
            theoryButton = new Button();
            testButton = new Button();
            SuspendLayout();
            // 
            // theoryButton
            // 
            theoryButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            theoryButton.Location = new Point(226, 125);
            theoryButton.Name = "theoryButton";
            theoryButton.Size = new Size(358, 81);
            theoryButton.TabIndex = 0;
            theoryButton.Text = "Теория";
            theoryButton.UseVisualStyleBackColor = true;
            theoryButton.Click += theoryButton_Click;
            // 
            // testButton
            // 
            testButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            testButton.Location = new Point(226, 241);
            testButton.Name = "testButton";
            testButton.Size = new Size(358, 81);
            testButton.TabIndex = 1;
            testButton.Text = "Тест";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testButton);
            Controls.Add(theoryButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        public Button theoryButton;
        public Button testButton;
    }
}