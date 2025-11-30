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

    private void OnTriggerEnter(Collider trigger)
    {
        switch (trigger.tag)
        {
            case "100":
                ScoreManager.Instance.AddScore(100);
                Destroy(trigger.gameObject);
                break;

            case "200":
                ScoreManager.Instance.AddScore(200);
                Destroy(trigger.gameObject);
                break;

            case "500":
                ScoreManager.Instance.AddScore(500);
                Destroy(trigger.gameObject);
                break;

            case "1000":
                ScoreManager.Instance.AddScore(1000);
                Destroy(trigger.gameObject);
                break;
        }
    }
}