using UnityEngine;
using UnityEngine.InputSystem;

public class SpringScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int downforce;

    public void OnDownPress(InputAction.CallbackContext context)
    {
        bool pressed = context.performed;

        while (pressed)
        {
            rb.linearVelocity = new Vector3(0, downforce, 0);
        }
    }
}
