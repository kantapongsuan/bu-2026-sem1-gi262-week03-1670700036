using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// OOPWall aka "Demon Wall"
public class OOPWall : Identity
{
    public int Damage;
    public bool isIceWall;

    public void Start()
    {
        isIceWall = Random.Range(0, 100) < 20 ? true : false;
        if (isIceWall)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }

    public override void Hit()
    {
        if (isIceWall)
        {
            mapGenerator.player.TakeDamage(Damage, isIceWall);
        }
        else
        {
            mapGenerator.player.TakeDamage(Damage);
        }
        Destroy(gameObject);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
    }
}