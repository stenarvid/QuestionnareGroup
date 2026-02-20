using Models.Questions;

namespace Models.Quiz;

public class Quiz(string _id, string _title)
{
    public string ID { get; set; } = _id;
    public string Title { get; set; } = _title;

    public List<Question> Questions { get; set; }
    public int CurrentQuestion { get; set; } // refers to QuestionID
}