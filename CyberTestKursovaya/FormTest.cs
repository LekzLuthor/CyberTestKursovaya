using CyberTestKursovaya.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberTestKursovaya
{
    public partial class FormTest : Form
    {
        public Dictionary<int, Question> questions = new Dictionary<int, Question>();

        public FormTest()
        {
            InitializeComponent();

            Question question1 = new Question
            {
                QuestionNumber = 1,
                Text = "Какой вирус распространялся через электронные письма с темой \"ILOVEYOU\"?",
                Option1 = "a) Mydoom",
                Option2 = "b) Conficker",
                Option3 = "c) ILOVEYOU",
                CorrectOption = 3
            };

            Question question2 = new Question
            {
                QuestionNumber = 2,
                Text = "Какой тип вируса использует уязвимость в промышленной системе управления для нанесения физического ущерба?",
                Option1 = "a) Mydoom",
                Option2 = "b) Stuxnet",
                Option3 = "c) ILOVEYOU",
                CorrectOption = 2
            };

            Question question3 = new Question
            {
                QuestionNumber = 3,
                Text = "Какие методы защиты от ILOVEYOU вируса наиболее эффективны?",
                Option1 = "a) Установка обновлений безопасности",
                Option2 = "b) Не открывать подозрительные вложения в электронных письмах",
                Option3 = "c) Использование сложных паролей",
                CorrectOption = 2
            };

            Question question4 = new Question
            {
                QuestionNumber = 4,
                Text = "Как распространялся вирус Mydoom?",
                Option1 = "a) Через зараженные USB-накопители",
                Option2 = "b) Через электронную почту и пиринговые сети",
                Option3 = "c) Через социальные сети",
                CorrectOption = 2
            };

            Question question5 = new Question
            {
                QuestionNumber = 5,
                Text = "Что делал вирус Conficker после заражения компьютера?",
                Option1 = "a) Отключал обновления безопасности и антивирусное ПО",
                Option2 = "b) Шифровал файлы и требовал выкуп",
                Option3 = "c) Уничтожал файлы на жестком диске",
                CorrectOption = 1
            };


            questions.Add(question1.QuestionNumber, question1);
            questions.Add(question2.QuestionNumber, question2);
            questions.Add(question3.QuestionNumber, question3);
            questions.Add(question4.QuestionNumber, question4);
            questions.Add(question5.QuestionNumber, question5);


            Random rnd = new Random();
            int generatedNumber = rnd.Next(1, 5);
            Question question = questions[generatedNumber + 1];
            label4.Text = question.QuestionNumber.ToString();
            questionText.Text = $"{question.Text}";
            label1.Text = question.Option1;
            label2.Text = question.Option2;
            label3.Text = question.Option3;

        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int currentQuestionNumber = int.Parse(label4.Text);
            Question question = questions[currentQuestionNumber];
            int userAnswer = (int)numericUpDown1.Value;

            if (userAnswer == question.CorrectOption)
            {
                label5.Text = "Верно!";
            }
            else
            {
                label5.Text = $"Неверно.. Правильный ответ {question.CorrectOption}";
            }
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int generatedNumber = rnd.Next(1, 5);
            Question question = questions[generatedNumber + 1];
            label4.Text = question.QuestionNumber.ToString();
            questionText.Text = $"{question.Text}";
            label1.Text = question.Option1;
            label2.Text = question.Option2;
            label3.Text = question.Option3;
            label5.Text = "";
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

    }

    public class Question
    {
        public int QuestionNumber { get; set; }
        public string Text { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public int CorrectOption { get; set; }
    }
}
