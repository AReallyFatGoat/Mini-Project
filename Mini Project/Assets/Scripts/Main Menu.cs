using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject ball;
    [SerializeField] private ScoreManager scoreManager;

    public void PlayGame()
    {
        menu.SetActive(false);
        gameOver.SetActive(false);
        ball.SetActive(true);
        Debug.Log("Game Stared");
    }

    public void EndGame()
    {
        gameOver.SetActive(true);
        scoreManager.ResetScore();
    }

}
