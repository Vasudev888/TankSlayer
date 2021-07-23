public class TankModel 
{
    public float turnSpeed = 90f;
    public TankModel(int speed, float health)
    {
        Speed = speed;
        Health = health;

    }

    public int Speed { get; private set; }
    public float Health { get; private set; }
}
