using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMonoSingleton<T> : MonoBehaviour where T : BulletMonoSingleton<T>
{
    public static T instance;
    public static T Instance { get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(this);
        }
    }


}
