using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton : MonoBehaviour
{
    public static MonoSingleton instance;
    public static MonoSingleton Instance { get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            Debug.LogError("A duplicate instance of Singleton is created");
        }
        else
        {
            Destroy(this);
        }
    }
}
