namespace CyberTestKursovaya.DAL
{
    internal class Questions
    {
        public int Id { get; internal set; }
        public string FirstOption { get; internal set; }
        public string SecondOption { get; internal set; }
        public string ThirdOption { get; internal set; }
        public long RightOption { get; internal set; }
        public string QuestionText { get; internal set; }
    }
}