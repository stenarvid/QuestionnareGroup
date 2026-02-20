
namespace Models.Question
{
    public class Question
    {
        string ID;
        string Text;
        Dictionary<string, int> Choices;
        Dictionary<int, string> Answers;
        int CorrectAnswer;
        int[] VoteCount;
    }
}

