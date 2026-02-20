
namespace Models.Questions
{
    public class Question(string _id, string _text, List<string> _choices, int _correctAnswer)
    {
        public string ID = _id;
        public string Text = _text;
        public List<string> QuizChoices = _choices;
        public int CorrectAnswer;
    }
}

