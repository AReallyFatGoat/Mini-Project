using UnityEngine;
using UnityEngine.InputSystem;

public class BallScript : MonoBehaviour
{
    [SerializeField] private int ballLimit;
    private Vector3 spawnLocation;
    [SerializeField] Rigidbody rb;
    public int sphereLives = 0;
    private int maxLives = 3;
    [SerializeField] private MainMenu mainMenu;

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
            sphereLives++;
            Debug.Log("lives = " + sphereLives);
        }

        if (sphereLives == maxLives)
        {
            mainMenu.EndGame();
            sphereLives = 0;
        }
    }

}
