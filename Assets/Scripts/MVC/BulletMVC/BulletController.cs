using UnityEngine;

public class BulletController
{
    public BulletController(BulletModel bulletModel, BulletView bulletPrefab)
    {
        BulletModel = bulletModel;
        var position = bulletView.fireTransform.position;
        bulletView = GameObject.Instantiate<BulletView>(bulletPrefab, position, Quaternion.identity);

        bulletView.bulletController = this;
    }

    public BulletModel BulletModel { get; }
    public BulletView bulletView { get; }

    public void Fire()
    {
/*        Rigidbody shellInstance = TankView.Instantiate(shellRb, fireTransform.position, 
            fireTransform.rotation);*/
    }
}
