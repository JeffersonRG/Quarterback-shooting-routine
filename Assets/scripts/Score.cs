using SpaceAccuracy;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public Text scoreText;
    public Text highscoreText;
    public Text accuracyText;

    public static int score = 0;
    public static int highscore = 0;
    public static int hitCount = 0;
    public static float accuracy = 0;

  
    public void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        hitCount = 0;
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE: " + score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    private void Update()
    {
        if (ShootProjectile.shotCount == 0) 
        {
            accuracyText.text = "ACCURACY: 100%";
        }
        else
        {
            accuracy = (float)(hitCount * 100 / ShootProjectile.shotCount);
            accuracyText.text = "ACCURACY: " + accuracy + "%";
        }
        
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "SCORE: " + score.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

    public void AddPoint2()
    {
        score += 2;
        scoreText.text = "SCORE: " + score.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}
