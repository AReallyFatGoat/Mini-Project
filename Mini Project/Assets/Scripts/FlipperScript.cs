using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperScript : MonoBehaviour
{
    [SerializeField] private HingeJoint hinge;
    [SerializeField] private int flipSpeed;
    [SerializeField] private int releaseSpeed;
    [SerializeField] private int motorForce;
    [SerializeField] private bool isRightFlipper;

    private void Start()
    {
        if (!hinge)
            hinge = GetComponent<HingeJoint>();
    }

    // This function is called automatically by Unity’s Input System
    // when the associated Input Action (e.g. LeftArrow or RightArrow) is triggered.
    public void OnFlipperPres(InputAction.CallbackContext context)
    {
        // 'context.performed' is true when the button is pressed down
        // 'context.canceled' will be called when the button is released
        bool pressed = context.performed;

        var motor = hinge.motor;

        if (pressed)
        {
            if (isRightFlipper)
                motor.targetVelocity = -flipSpeed;
            else
                motor.targetVelocity = flipSpeed;

        }
        else
        {
            if (isRightFlipper)
                motor.targetVelocity = -releaseSpeed;
            else
                motor.targetVelocity = releaseSpeed;

        }


        motor.force = motorForce;

        hinge.motor = motor;

        hinge.useMotor = true;

    }
}
