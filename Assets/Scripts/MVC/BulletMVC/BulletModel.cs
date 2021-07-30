using UnityEngine;

public class BulletModel
{
    public BulletModel(int speed, Color color, float launchForce)
    {
        Speed = speed;
        Color = color;
        LaunchForce = launchForce;
    }

    public int Speed { get; }
    public Color Color { get; }
    public float LaunchForce { get; }
}
