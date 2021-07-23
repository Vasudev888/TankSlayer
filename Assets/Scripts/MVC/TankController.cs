using UnityEngine;

public class TankController 
{
    public TankController(TankModel tankModel, TankView tankPrefab)
    {
        TankModel = tankModel;
        tankView = GameObject.Instantiate<TankView>(tankPrefab);
        tankView.tankController = this;
    }

    public TankModel TankModel { get; }
    public TankView tankView { get; }



    public void Move(float verticalInput)
    {
        /*        Vector3 movement = horizontalInput * transform.forward * speed * Time.deltaTime;
                rigidBody.MovePosition(rigidBody.position + movement);*/
        tankView.transform.Translate(Vector3.forward * Time.deltaTime * TankModel.Speed * verticalInput);
    }

    public void Turn()
    {
        /*        float turn = verticalInput * turnSpeed * Time.deltaTime;
                Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
                rigidBody.MoveRotation(rigidBody.rotation * turnRotation);*/
        tankView.transform.Rotate(0f, TankModel.turnSpeed * tankView.horizontalInput * Time.deltaTime, 0f);
    }
}
