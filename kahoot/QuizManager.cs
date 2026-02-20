using System.ComponentModel;
using Models.Participant;
using Models.Questions;
using Models.Quiz;

public class QuizManager
{
    private Quiz quiz = new Quiz("test", "First Quiz");
    private List<Quiz>? quizzes = new();
    private List<Question>? questions = new();
    private int currQuestion = 0;

    public event Action? OnStateChanged;

    public void initialize(string id)
    {
        quiz.ID = id;
        quiz.Title = " ";
        quiz.Questions = questions;
        quiz.CurrentQuestion = 0;
        quiz.Questions.Add(new Question(id, "First Question", 1));
        quiz.Questions.Add(new Question(id, "Second Question", 2));
        quiz.Questions.Add(new Question(id, "Third Question", 3));
        quiz.Questions.Add(new Question(id, "Fourth Question", 4));
        quizzes.Add(quiz);
    }

    public Quiz GetQuizByID(string id)
    {
        foreach (var quiz in quizzes)
        {
            if (quiz.ID == id)
            {
                quiz.Title = id;
                return quiz;
            }
        }
        return null;
    }

    public Question GetCurrentQuestion()
    {
        return questions[currQuestion];
    }

    public void SubmitAnswer(Participant participant)
    {

    }

    public void NextQuestion()
    {

    }
}