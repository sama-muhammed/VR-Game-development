using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AvatarController : MonoBehaviour
{
    // Dialogue System
    public Text questionText;
    public Button nextButton;
    public AudioSource audioSource;
    public AudioClip[] questionAudioClips;

    private int currentQuestionIndex = 0;
    private string[] questions = {
        "What's your name?",
        "Tell me about an old life experience.",
        "Your child had an accident. It was hard, right?",
        "How did you feel then?",
        "How did you act with this?"
    };

    // Movement System
    public float moveSpeed = 3f;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Dialogue Setup
        if (questionText != null)
        {
            questionText.text = questions[currentQuestionIndex];
        }
        if (nextButton != null)
        {
            nextButton.onClick.AddListener(ShowNextQuestion);
        }
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;

        if (moveDirection.magnitude > 0.1f)
        {
            agent.Move(moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    void ShowNextQuestion()
    {
        if (currentQuestionIndex < questions.Length - 1)
        {
            currentQuestionIndex++;
            questionText.text = questions[currentQuestionIndex];

            if (questionAudioClips.Length > currentQuestionIndex && questionAudioClips[currentQuestionIndex] != null)
            {
                audioSource.clip = questionAudioClips[currentQuestionIndex];
                audioSource.Play();
            }
        }
    }
}
