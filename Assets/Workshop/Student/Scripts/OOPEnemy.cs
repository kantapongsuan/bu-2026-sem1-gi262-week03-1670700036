using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPEnemy : Character
{
    public void Start()
    {
        GetRemainEnergy();
    }

    private void GetRemainEnergy()
    {
        throw new NotImplementedException();
    }

    public void Attack(OOPPlayer _player)
    {
        _player.energy -= attackPoint;
        Debug.Log("player is energy " + _player.energy);
    }
}
