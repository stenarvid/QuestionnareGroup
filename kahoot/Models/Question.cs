
namespace Models.Questions
{
    public class Question(string _id, string _text, int _correctAnswer)
    {
        public string ID;
        public string Text;
        public Dictionary<string, int> Choices;
        public Dictionary<int, string> Answers;
        public int CorrectAnswer;
        public int[] VoteCount;
    }
}

