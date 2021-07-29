using UnityEngine;

public class BulletController
{
    public BulletController(BulletModel bulletModel, BulletView bulletPrefab)
    {
        BulletModel = bulletModel;
        BulletPrefab = bulletPrefab;
    }

    public BulletModel BulletModel { get; }
    public BulletView BulletPrefab { get; }

    public void Fire()
    {
/*        Rigidbody shellInstance = TankView.Instantiate(shellRb, fireTransform.position, 
            fireTransform.rotation);*/
    }
}
