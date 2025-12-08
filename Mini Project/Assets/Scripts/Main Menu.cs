using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject ball;
    [SerializeField] private ScoreManager scoreManager;

    //Method to start game when pressing play button, Activates the menu and ball, and makes sure the gameover screen is inactive
    public void PlayGame()
    {
        menu.SetActive(false);
        gameOver.SetActive(false);
        ball.SetActive(true);
        Debug.Log("Game Stared");
    }

    //Method to end game when lives have depleted, Activates the game over screen and resets the score.

    public void EndGame()
    {
        gameOver.SetActive(true);
        scoreManager.ResetScore();
    }

}
