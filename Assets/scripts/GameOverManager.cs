using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text highscore;
    public Text score;
    public Text Accuracy;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        highscore.text = $"Highscore: {PlayerPrefs.GetInt("highscore", 0).ToString()}";
        score.text = $"Score: {Score.score.ToString()}";
        Accuracy.text = $"ACCURACY: {Score.accuracy}%";
    }
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

