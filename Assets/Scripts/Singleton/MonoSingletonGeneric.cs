using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingletonGeneric<T> : MonoBehaviour where T : MonoSingletonGeneric<T>
{
    public static T instance;
    public static T Instance { get { return instance; } }

    public virtual void Awake()
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

/*public class GameWorldNew : MonoSingletonGeneric<GameWorldNew>
{
    public override void Awake()
    {
        base.Awake();
        //custom logic
    }
    public void StartNewGame()
    {

    }
}
*/