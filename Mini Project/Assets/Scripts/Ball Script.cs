using UnityEngine;
using UnityEngine.InputSystem;

public class BallScript : MonoBehaviour
{
    [SerializeField] private int ballLimit;
    private Vector3 spawnLocation;
    [SerializeField] Rigidbody rb;

    public void SpawnBall(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Work?");
            rb.isKinematic = false;
        }
    }

    private void Start()
    {
        spawnLocation = transform.position;
    }

    private void Update()
    {

        if (transform.position.y < ballLimit)
        {
            transform.position = spawnLocation;
            rb.isKinematic = true;
        }
    }

}
