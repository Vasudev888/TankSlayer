using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySingletonGeneric<T> : MonoBehaviour where T : EnemySingletonGeneric<T>
{
    public static T instance;
    public static T Instance { get; }

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
