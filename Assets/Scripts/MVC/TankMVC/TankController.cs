using UnityEngine;

public class TankController 
{
    public TankController(TankModel tankModel, TankView tankPrefab)
    {
        TankModel = tankModel;
        var position = new Vector3(Random.Range(-8, 10), 0, Random.Range(-10, 4));
        tankView = GameObject.Instantiate<TankView>(tankPrefab, position, Quaternion.identity);
        
        tankView.tankController = this;
    }

    public TankModel TankModel { get; }
    public TankView tankView { get; }



    public void Move(float verticalInput)
    {
        /* Vector3 movement = horizontalInput * transform.forward * speed * Time.deltaTime;
           rigidBody.MovePosition(rigidBody.position + movement);*/
        tankView.transform.Translate(Vector3.forward * Time.deltaTime * TankModel.Speed * verticalInput);
    }

    public void Turn(float horizontalInput)
    {
        /*  float turn = verticalInput * turnSpeed * Time.deltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rigidBody.MoveRotation(rigidBody.rotation * turnRotation);*/
        tankView.transform.Rotate(0f, TankModel.turnSpeed * horizontalInput * Time.deltaTime, 0f);
    }


}
