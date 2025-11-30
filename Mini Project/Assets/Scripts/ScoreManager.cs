using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TextMeshProUGUI scoreText;
    public int score = 0;

    private void Awake()
    {
        Instance = this;
        Debug.Log("ManagerInstanced");
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text =  ("Score:" + score.ToString());
        Debug.Log("Score is: " + score);
    }
}