using UnityEngine;

public class BulletView : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Rigidbody shellRb;
    public Transform fireTransform;

    public BulletController bulletController;

    private void Start()
    {
        shellRb = GetComponent<Rigidbody>();
        bulletPrefab.GetComponent<Renderer>().material.color = bulletController.BulletModel.Color;
    }

}
