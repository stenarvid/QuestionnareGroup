using Models.Participant;
using Models.Questions;
using Models.Quiz;

public class QuizManager
{
    private List<Quiz>? quizzes;
    private List<Question>? questions;
    private int currQuestion = 0;

    public Quiz GetQuizByID(string id)
    {
        foreach (var quiz in quizzes)
        {
            if (quiz.ID == id)
            {
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