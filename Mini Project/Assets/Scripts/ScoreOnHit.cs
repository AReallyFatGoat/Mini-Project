using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreOnHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "Bumper":
                ScoreManager.Instance.AddScore(50);
                break;

            case "Target":
                ScoreManager.Instance.AddScore(150);
                break;

            case "Ramp":
                ScoreManager.Instance.AddScore(ScoreManager.Instance.score*2);
                break;
        }
    }
}