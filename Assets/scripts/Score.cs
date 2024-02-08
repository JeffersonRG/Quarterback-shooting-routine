using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    public void Awake()
    {
        Instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE: " + score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "SCORE: " + score.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

}
