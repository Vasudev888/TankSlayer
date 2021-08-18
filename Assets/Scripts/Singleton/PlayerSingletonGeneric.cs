using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingletonGeneric<T> : MonoBehaviour where T : PlayerSingletonGeneric<T>
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
