using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

[CreateAssetMenu(menuName = "Powerups/ExtendPlayer")]

public class ExtendPlayer : PowerUpEffect
{
    
    public override void Apply(GameObject obj)
    {
        Player.Instance.transform.localScale = new Vector3(Player.Instance.transform.localScale.x*1.3f, Player.Instance.transform.localScale.y, Player.Instance.transform.localScale.z);
    }

}
