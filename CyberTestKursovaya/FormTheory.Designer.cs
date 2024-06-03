namespace CyberTestKursovaya
{
    partial class FormTheory
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
            theoryOutput = new TextBox();
            theorySectionsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            readButton = new Button();
            SuspendLayout();
            // 
            // theoryOutput
            // 
            theoryOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            theoryOutput.Location = new Point(242, 59);
            theoryOutput.Multiline = true;
            theoryOutput.Name = "theoryOutput";
            theoryOutput.Size = new Size(639, 451);
            theoryOutput.TabIndex = 0;
            // 
            // theorySectionsListBox
            // 
            theorySectionsListBox.FormattingEnabled = true;
            theorySectionsListBox.ItemHeight = 15;
            theorySectionsListBox.Location = new Point(12, 59);
            theorySectionsListBox.Name = "theorySectionsListBox";
            theorySectionsListBox.Size = new Size(189, 319);
            theorySectionsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 2;
            label1.Text = "Раздел";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(521, 21);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "Теория";
            // 
            // readButton
            // 
            readButton.Location = new Point(12, 384);
            readButton.Name = "readButton";
            readButton.Size = new Size(188, 42);
            readButton.TabIndex = 4;
            readButton.Text = "Читать";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // FormTheory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 593);
            Controls.Add(readButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(theorySectionsListBox);
            Controls.Add(theoryOutput);
            Name = "FormTheory";
            Text = "FormTheory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox theoryOutput;
        private ListBox theorySectionsListBox;
        private Label label1;
        private Label label2;
        private Button readButton;
    }
}