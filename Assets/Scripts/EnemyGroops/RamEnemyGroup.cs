using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamEnemyGroup : BaseAllEnemyGroop
{
    public RamEnemyShip firstShip;
    public RamEnemyShip secondShip;

    void Update()
    {
        if (firstShip == null && secondShip == null){
            isDestroyed = true;
        }
    }
}
