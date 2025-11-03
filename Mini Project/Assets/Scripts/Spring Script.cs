using UnityEngine;
using UnityEngine.InputSystem;

public class SpringScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int downforce;
    [SerializeField] private int upforce;
    [SerializeField] private int springlimit;

    public void OnDownPress(InputAction.CallbackContext context)
    {
        bool pressed = context.performed;

        if (pressed)
        {
            rb.linearVelocity = new Vector3(0, downforce, 0);
        }
        else
        {
            rb.linearVelocity = new Vector3(0, upforce, 0);
        }
    }

    private void Update()
    {
        if (transform.position.y > springlimit)
        {
            rb.linearVelocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(transform.position.x, springlimit, transform.position.z);
        }
    }
}


