using UnityEngine;
using UnityEngine.InputSystem;

public class SpringScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int downforce;
    [SerializeField] private int upforce;
    [SerializeField] private int springlimit;


    public void OnDownPress(InputAction.CallbackContext context) //the script used to move the spring up and down
    {
        rb.isKinematic = false; // kinematic is enabled by default to combat the balls weight affecting the position of the spring while standing still. I disable kinematic to make the spring able to move
        bool pressed = context.performed;

        if (pressed) //if the button is held down, the spring gets set to a downwards velocity, letting the spring "charge up"
        {
            rb.linearVelocity = new Vector3(0, downforce, 0);
        }
        else //if the button is not held down, the spring launches back up again with an upwards velocity
        {
            rb.linearVelocity = new Vector3(0, upforce, 0);
        }
    }
    private void Update()
    {
        if (transform.position.y > springlimit) //here ive set a limit on the y-axis, to make sure that when the spring reaches it's top height it stops moving, and gets the kinematic property enabled until use
        {
            rb.linearVelocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(transform.position.x, springlimit, transform.position.z);
            rb.isKinematic= true;
        }
    }
}


