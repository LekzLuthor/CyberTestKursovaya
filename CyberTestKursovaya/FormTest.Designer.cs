namespace CyberTestKursovaya
{
    partial class FormTest
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
            questionText = new TextBox();
            answerButton = new Button();
            nextQuestionButton = new Button();
            questionLabel = new Label();
            answerLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // questionText
            // 
            questionText.Location = new Point(34, 49);
            questionText.Multiline = true;
            questionText.Name = "questionText";
            questionText.Size = new Size(724, 95);
            questionText.TabIndex = 0;
            // 
            // answerButton
            // 
            answerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            answerButton.Location = new Point(489, 379);
            answerButton.Name = "answerButton";
            answerButton.Size = new Size(126, 47);
            answerButton.TabIndex = 1;
            answerButton.Text = "ответить";
            answerButton.UseVisualStyleBackColor = true;
            // 
            // nextQuestionButton
            // 
            nextQuestionButton.Location = new Point(632, 379);
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.Size = new Size(126, 47);
            nextQuestionButton.TabIndex = 2;
            nextQuestionButton.Text = "следующий вопрос";
            nextQuestionButton.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            questionLabel.Location = new Point(357, 9);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(85, 25);
            questionLabel.TabIndex = 3;
            questionLabel.Text = "Вопрос";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            answerLabel.Location = new Point(34, 389);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(77, 25);
            answerLabel.TabIndex = 4;
            answerLabel.Text = "Ответ:";
            answerLabel.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 173);
            label1.Name = "label1";
            label1.Size = new Size(25, 24);
            label1.TabIndex = 5;
            label1.Text = "1.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 216);
            label2.Name = "label2";
            label2.Size = new Size(25, 24);
            label2.TabIndex = 6;
            label2.Text = "2.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 258);
            label3.Name = "label3";
            label3.Size = new Size(25, 24);
            label3.TabIndex = 7;
            label3.Text = "3.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.ForeColor = SystemColors.WindowText;
            numericUpDown1.Location = new Point(136, 387);
            numericUpDown1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 33);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(answerLabel);
            Controls.Add(questionLabel);
            Controls.Add(nextQuestionButton);
            Controls.Add(answerButton);
            Controls.Add(questionText);
            Name = "FormTest";
            Text = "FormTest";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionText;
        private Button answerButton;
        private Button nextQuestionButton;
        private Label questionLabel;
        private Label answerLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}