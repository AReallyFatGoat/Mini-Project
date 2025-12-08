using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreOnHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)

        // this script is sort of copy and paste throughout, just using switch cases for adding different scores based on the tag of the object that the ball collides with
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

    // same idea as above, just using triggers for the coins

    private void OnTriggerEnter(Collider trigger)
    {
        switch (trigger.tag)
        {
            case "100":
                ScoreManager.Instance.AddScore(100);
                trigger.gameObject.SetActive(false);
                break;

            case "200":
                ScoreManager.Instance.AddScore(200);
                trigger.gameObject.SetActive(false);
                break;

            case "500":
                ScoreManager.Instance.AddScore(500);
                trigger.gameObject.SetActive(false);
                break;

            case "1000":
                ScoreManager.Instance.AddScore(1000);
                trigger.gameObject.SetActive(false);
                break;
        }
    }
}