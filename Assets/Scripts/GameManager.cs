using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Score UI")]
    private int scoreTimer = 0;
    private int targetScore = 5;
    public int gameScore = 0;
    private int highScore = 0;
    [SerializeField] private TextMeshProUGUI scoreTimerText;
    [SerializeField] private TextMeshProUGUI winScoreTimerText;
    [SerializeField] private TextMeshProUGUI highScoreTimerText;

    [Header("Game UI")]
    [SerializeField] private CanvasGroup gameStartCG;
    [SerializeField] private CanvasGroup gameCG;
    [SerializeField] private CanvasGroup gameOverCG;

    [Header("Ball Elements")]
    [SerializeField] private GameObject ball1;
    [SerializeField] private GameObject ball2;
    [SerializeField] private GameObject ball3;
    [SerializeField] private GameObject ball4;
    [SerializeField] private GameObject ball5;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 999);
        highScoreTimerText.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ScoreUp()
    {
        scoreTimer++;
        scoreTimerText.text = scoreTimer.ToString();
    }

    public void ScoreCount()
    {
        gameScore++;
    }

    public void GameComplete()
    {
        if (gameScore == targetScore)
        {
            GameOver();
        }
    }
    public void GameStart()
    {
        HideCG(gameStartCG);
        ShowCG(gameCG);
        HideCG(gameOverCG);

        ShowBalls();
        InvokeRepeating("ScoreUp", 2f, 1f);
    }

    public void GameOver()
    {
        if (scoreTimer < highScore)
        {
            highScore = scoreTimer;
            PlayerPrefs.SetInt("highScore", highScore);
        }

        winScoreTimerText.text = scoreTimer.ToString();
        highScoreTimerText.text = highScore.ToString();

        HideCG(gameCG);
        HideCG(gameStartCG);
        ShowCG(gameOverCG);

        CancelInvoke();

        HideBalls();
    }

    private void ShowCG(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }

    private void HideCG(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    private void ShowBalls()
    {
        ball1.SetActive(true);
        ball2.SetActive(true);
        ball3.SetActive(true);
        ball4.SetActive(true);
        ball5.SetActive(true);
    }

    private void HideBalls()
    {
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
    }

    public void PlayAgainButtonCallBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
