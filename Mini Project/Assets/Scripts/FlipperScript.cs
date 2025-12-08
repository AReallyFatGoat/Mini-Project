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

    public void OnFlipperPres(InputAction.CallbackContext context)
    {

        bool pressed = context.performed;

        var motor = hinge.motor;

        if (pressed) // if the button is held down, the flipper gets flipped up using the value of the int flipspeed, using the negative value for the left flipper
        {
            if (isRightFlipper)
                motor.targetVelocity = -flipSpeed;
            else
                motor.targetVelocity = flipSpeed;

        }
        else
        {
            if (isRightFlipper) // same concept as above, using an int to release the flipper when the key is no longer held, using the negative int for the left flipper
                motor.targetVelocity = -releaseSpeed;
            else
                motor.targetVelocity = releaseSpeed;

        }


        motor.force = motorForce;

        hinge.motor = motor;

        hinge.useMotor = true;

    }

   
}
