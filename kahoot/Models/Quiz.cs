using Models.Questions;

namespace Models.Quiz;

public class Quiz()
{
    public string ID { get; set; }
    public string Title { get; set; }

    public List<Question> Questions { get; set; }
    public int CurrentQuestion { get; set; } // refers to QuestionID
}