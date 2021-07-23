using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoSingletonGeneric<TankService> 
{
    public TankView tankView;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpawnNewTank();
        }
    }
    private TankController SpawnNewTank()
    {
        TankModel model = new TankModel(5, 100f);
        TankController tank = new TankController(model, tankView);
        return tank;
    }
}
