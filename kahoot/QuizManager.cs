using System.ComponentModel;
using Models.Participant;
using Models.Questions;
using Models.Quiz;

public class QuizManager
{
    private Quiz quiz = new Quiz();
    private List<Quiz>? quizzes = new();
    private List<Question>? questions = new();
    private int currQuestion = 0;

    public void initialize(string id)
    {
        quiz.ID = id;
        quiz.Title = " ";
        quiz.Questions = questions;
        quiz.CurrentQuestion = 0;
        quizzes.Add(quiz);
    }

    public Quiz GetQuizByID(string id)
    {
        foreach (var quiz in quizzes)
        {
            if (quiz.ID == id)
            {
                quiz.Title = "HundShow";
                return quiz;
            }
        }
        return null;
    }

    public void SubmitAnswer(Participant participant)
    {

    }

    public void NextQuestion(Quiz quiz)
    {

    }
}