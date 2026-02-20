
namespace Models.Questions
{
    public class Question(string _id, string _text, List<string> _choices, int _correctAnswer)
    {
        string ID = _id;
        string Text = _id;
        List<string> QuizChoices = _choices;
        int CorrectAnswer;
    }
}

