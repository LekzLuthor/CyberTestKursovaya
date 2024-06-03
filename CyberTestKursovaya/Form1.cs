namespace CyberTestKursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void theoryButton_Click(object sender, EventArgs e)
        {
            new FormTheory().Show();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            new FormTest().Show();
        }
    }
}