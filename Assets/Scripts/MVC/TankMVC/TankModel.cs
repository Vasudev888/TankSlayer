using UnityEngine;

public class TankModel 
{
    public float turnSpeed = 90f;

    public TankModel(int speed, float health, Color color )
    {
        Speed = speed;
        Health = health;
        Color = color;
    }

    public int Speed { get; private set; }
    public float Health { get; private set; }
    public Color Color { get; }
}
