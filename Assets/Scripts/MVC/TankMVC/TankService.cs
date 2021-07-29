using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoSingletonGeneric<TankService> 
{
    public TankView tankPrefab;
    public Color[] colors = {Color.red, Color.blue, Color.yellow, Color.green};

    public TankController[] tanks = new TankController[10];

    int i = 0;

    public void GenerateTanks()
    {
        tanks[i] = SpawnNewTank();
        i++;
    }

    public void Fire()
    {
        
    }

    private void Update()
    {
        
    }
    public TankController SpawnNewTank()
    {

        TankModel model = new TankModel(50, 100f, colors[Random.Range(0,colors.Length)]);
        TankController tank = new TankController(model, tankPrefab);
        return tank;
    }
}
