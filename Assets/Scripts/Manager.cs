using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [Header("GUI")]
    [SerializeField] GameObject gameOver = null;
    [SerializeField] Text scoreText = null;
    [SerializeField] Text finalScoreText = null;
    [SerializeField] Text newHighscoreText = null;
    [HideInInspector] public int score;
    [HideInInspector] public bool inGame;
    public static Manager instance;
    int highscore;

    void Awake()
    {
        Time.timeScale = 1f;
        instance = this;
        inGame = true;
    }

    void Start()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("Highscore", 0);
    }

    void Update()
    {
        SetScoreText();
    }

    void SetScoreText()
    {
        scoreText.text = score.ToString();
        finalScoreText.text = "YOUR SCORE IS: " + score.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameEnd()
    {
        Time.timeScale = 0f;
        inGame = false;
        scoreText.gameObject.SetActive(false);
        gameOver.SetActive(true);

        if(score > highscore)
        {
            PlayerPrefs.SetInt("Highscore", score);
            newHighscoreText.gameObject.SetActive(true);
        }
    }
}
