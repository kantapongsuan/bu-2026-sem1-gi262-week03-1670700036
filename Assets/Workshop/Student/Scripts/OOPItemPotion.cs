using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPItemPotion : Identity
{
    public int healPoint;
    public bool insBonus;

    public void Start()
    {
       
    }
    public override void Hit()
    {
        mapGenerator.player.Heal(healPoint);
        Destroy(gameObject);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
    }
}