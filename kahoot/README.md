Klasser :

QUIZ
____
ID [int]
Title = "Game Title" [string]
Questions[] [list<Question>]
CurrentQuestion [QuestionID(string)]

QUESTION
________
QuestionID [string]
Text [string]
Choices[] [Dictionary<string, int>]
Answers[] [Dictionary<int, ParticipantID(string)>] 
CorrectAnswer [int]
VoteCount[] [Array(int)]

PARTICIPANT
___________
ParticipantID [string]
Name [Dictionary<string, string>]
Answer[Dictionary<Question, int>]



Routes: 
/quiz/{id}
/quiz/{id}/?

Singleton klass:
_______________
Next()
GetQuiz()
SubmitAnswer()
OnStateChange()
