using UnityEngine;
using UnityEngine.UI; // Import UI namespace

public class DialogueController : MonoBehaviour
{
    public Text QuestionText; // UI Text for the questions
    public Button NextButton; // UI Button for moving to the next question

    private int currentQuestionIndex = 0;
    private string[] questions = {
        "What's your name?",
        "Tell me about an old life experience.",
        "Your child had an accident. It was hard, right?",
        "How did you feel then?",
        "How did you act with this?"
    };

    void Start()
    {
        // Set the first question
        QuestionText.text = questions[currentQuestionIndex];

        // Assign button click event
        NextButton.onClick.AddListener(ShowNextQuestion);
    }

    void ShowNextQuestion()
    {
        if (currentQuestionIndex < questions.Length - 1)
        {
            currentQuestionIndex++;
            QuestionText.text = questions[currentQuestionIndex];
        }
    }
}
