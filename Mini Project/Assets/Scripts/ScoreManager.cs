using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TextMeshProUGUI scoreText;
    public int score = 0;

    private void Awake() //makes sure to instance the manager
    {
        Instance = this;
        Debug.Log("ManagerInstanced");
    }

    public void AddScore(int amount) //this is the method used in the ScoreOnHit script, adding whatever score is used as an argument which and setting the TMP text component to show the score
    {
        score += amount;
        scoreText.text =  ("Score:" + score.ToString());
        Debug.Log("Score is: " + score);
    }

    public void ResetScore() // method used for resetting the score, called by the MainMenu script when resetting the game
    {
        score = 0;
        scoreText.text = ("Score:" + score.ToString());
        Debug.Log("Score is: " + score);
    }
}