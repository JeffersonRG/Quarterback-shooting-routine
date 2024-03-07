using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public Text timerText; // Reference to the Text UI element
    public float countdownTime = 60f; // Countdown time in seconds

    private float currentTime;

    private void Start()
    {
        currentTime = countdownTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            currentTime = 0f;
            // Optionally, you can perform any actions when the countdown reaches zero
        }

        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
