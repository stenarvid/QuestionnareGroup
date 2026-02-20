using System.ComponentModel;
using Models.Participant;
using Models.Questions;
using Models.Quiz;

public class QuizManager
{
    private Quiz quiz = new Quiz();
    private List<Quiz>? quizzes;
    private List<Question>? questions;
    private int currQuestion = 0;

    public void initialize()
    {
        quiz.ID = "Hej";
        quiz.Title = "hundShow";
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
                quiz.Title = "Hej";
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