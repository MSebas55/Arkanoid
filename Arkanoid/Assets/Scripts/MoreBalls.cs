using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/MoreBalls")]

public class MoreBalls : PowerUpEffect
{
    
    public override void Apply(GameObject obj)
    {
        if (obj != null)
        {
            obj.transform.position = new Vector3(0, 0, 0);
        }

    }

}
