using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public float horizontalInput;
    float verticalInput;


    public Joystick joystick;

    private Rigidbody rigidBody;
    public TankController tankController;

    private void Start()
    {
        /* rigidBody = GetComponent<Rigidbody>();*/
    }


    private void FixedUpdate()
    {
        horizontalInput = joystick.Horizontal;
        verticalInput = joystick.Vertical;
        tankController.Move(verticalInput);
        tankController.Turn();
    }
}
