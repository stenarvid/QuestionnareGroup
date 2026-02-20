
namespace Models.Questions
{
    public class Question(string _id, string _text, int _correctAnswer)
    {
        string ID;
        string Text;
        Dictionary<string, int> Choices;
        Dictionary<int, string> Answers;
        int CorrectAnswer;
        int[] VoteCount;
    }
}

