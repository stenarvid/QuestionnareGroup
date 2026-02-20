using System.ComponentModel;
using System.Dynamic;
using Models.Participant;
using Models.Questions;
using Models.Quiz;

public class QuizManager
{
    private Quiz quiz = new Quiz("init", "init");
    private Dictionary<string, Quiz> quizzes = new();
    private List<Question>? questions = new();
    private int currQuestion = 0;

    public event Action? OnStateChanged;

    public void initialize(string id)
    {
        quiz.ID = id;
        quiz.Title = " ";
        quiz.Questions = questions;
        quiz.CurrentQuestion = 0;
        quiz.Questions.Add
        (
            new Question
            (
                id,
                "First Question",
                new List<string>() { "Bertil", "John", "Göran", "Sara" },
                1
            )
        );
        quiz.Questions.Add
(
    new Question
    (
        id,
        "Second Question",
        new List<string>() { "Bertil", "John", "Göran", "Sara" },
        2
    )
);
        quiz.Questions.Add
(
    new Question
    (
        id,
        "Third Question",
        new List<string>() { "Bertil", "John", "Göran", "Sara" },
        3
    )
);
        quiz.Questions.Add
(
    new Question
    (
        id,
        "Fourth Question",
        new List<string>() { "Bertil", "John", "Göran", "Sara" },
        4
    )
);

        quizzes[quiz.ID] = quiz;
    }

    public Quiz? GetQuizByID(string id) => quizzes[id];

    public void SubmitAnswer(Participant participant, string QuizId, int answer)
    {
        if (participant.AnswerIndex == quizzes[QuizId].CurrentQuestion)
        {
            NextQuestion(QuizId);
            OnStateChanged?.Invoke();
        }
    }

    public void NextQuestion(string QuizId)
    {
        if (quizzes[QuizId].Questions.Count <= (quizzes[QuizId].CurrentQuestion - 1))
        {
            quizzes[QuizId].CurrentQuestion++;
            OnStateChanged?.Invoke();
        }
    }
}