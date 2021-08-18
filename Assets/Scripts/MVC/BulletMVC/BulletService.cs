using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : BulletMonoSingleton<BulletService>
{
    public BulletView bulletPrefab;

    public Color[] colors = { Color.red, Color.blue, Color.yellow, Color.green };

}
