using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    public Text dialogueText; // Assign a UI Text element in Inspector
    private int currentQuestionIndex = 0;
    
    private string[] questions = 
    {
        "What's your name?",
        "Do you remember the time your child had an accident?",
        "It was too hard, right? What did you feel then?",
        "How did you act in that situation?",
        "Thank you for sharing. Let's talk again soon!"
    };

    private bool isTalking = false; // Track if conversation is happening

    void Start()
    {
        if (dialogueText == null)
        {
            Debug.LogError("Dialogue Text is not assigned!");
        }
    }

    void OnMouseDown()
    {
        if (!isTalking) // Start conversation on first click
        {
            isTalking = true;
            ShowNextQuestion();
        }
    }

    public void ShowNextQuestion()
    {
        if (currentQuestionIndex < questions.Length)
        {
            dialogueText.text = questions[currentQuestionIndex];
            currentQuestionIndex++;
        }
        else
        {
            EndConversation();
        }
    }

    void EndConversation()
    {
        dialogueText.text = "Conversation ended.";
        isTalking = false;
        currentQuestionIndex = 0; // Reset for next interaction
    }
}
