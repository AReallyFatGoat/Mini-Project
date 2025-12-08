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

    public void SpawnBall(InputAction.CallbackContext context) //using the Unity input system, i use the kinematic property of the balls rigidbody, to hold it in place until the assigned key is pressed
    {
        if (context.performed)
        {
            rb.isKinematic = false;
        }
    }

    private void Start() // saving the balls start position in a Vector3 for later use when resetting the ball
    {
        spawnLocation = transform.position;
    }

    private void Update()
    {

        if (transform.position.y < ballLimit) // an if statement that makes it so that whenever the ball falls below a certain level, it resets back to the original position
                                              // enabled the kinematic property again, and increases the sphereLives int to keep track of player lives
        {
            transform.position = spawnLocation;
            rb.isKinematic = true;
            sphereLives++;
            Debug.Log("lives = " + sphereLives);
        }

        if (sphereLives == maxLives) // calls the function to reset the game from the MainMenu script, once sphereLives equals maxLives
        {
            mainMenu.EndGame();
            sphereLives = 0;
        }
    }

    private void OnCollisionExit(Collision other) //a method used for applying extra force when hitting a bumper, to simulate a bounce effect. OnCollisionExit is used so that im getting the current velocity on the balls way outwards instead of inwards
    {
        if (other.gameObject.tag == "Bumper")
        {
            rb.AddForce(rb.angularVelocity * 2);
            Debug.Log("Force Applied");
        }
    }


}
