using UnityEngine;

public class TankController 
{
    public TankController(TankModel tankModel, TankView tankPrefab)
    {
        TankModel = tankModel;
        TankPrefab = GameObject.Instantiate<TankView>(tankPrefab);
    }

    public TankModel TankModel { get; }
    public TankView TankPrefab { get; }

    [SerializeField]float speed = 100f;
    [SerializeField] float turnSpeed = 90f;
    float horizontalInput = 0;
    float verticalInput = 0;


    public Joystick joystick;

    private Rigidbody rigidBody;


    private void Start()
    {
       /* rigidBody = GetComponent<Rigidbody>();*/
    }

    private void FixedUpdate()
    {
        horizontalInput = joystick.Horizontal;
        verticalInput = joystick.Vertical;
        Move();
        Turn();
    }

    private void Move()
    {
        /*        Vector3 movement = horizontalInput * transform.forward * speed * Time.deltaTime;
                rigidBody.MovePosition(rigidBody.position + movement);*/
        /*transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);*/
    }

    private void Turn()
    {
        /*        float turn = verticalInput * turnSpeed * Time.deltaTime;
                Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
                rigidBody.MoveRotation(rigidBody.rotation * turnRotation);*/
        /*transform.Rotate(0f,turnSpeed * horizontalInput * Time.deltaTime, 0f) ;*/
    }
}
