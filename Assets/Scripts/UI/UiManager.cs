using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] scoreText;

    [SerializeField] private TextMeshProUGUI gameOverText;

    [SerializeField] private GameController gameController;

    [SerializeField] private GameObject restartButton;

    [SerializeField] private GameObject startButton;

    private void Update()
    {
        scoreText[0].text = gameController.PlayerScore.ToString();

        scoreText[1].text = gameController.EnemyScore.ToString();

        if (gameController.PlayerScore == 10)
        {
            gameOverText.text = "You Win!";
        }
        else if(gameController.EnemyScore == 10)
        {
            gameOverText.text = "You Lost!";
        }

        if(gameController.gameState == GameController.GameState.GameOver)
        {
            restartButton.SetActive(true);
        }

        if(gameController.gameState == GameController.GameState.Play)
        {
            startButton.SetActive(false);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void StartButton()
    {
        gameController.gameState = GameController.GameState.Play;
    }



}
