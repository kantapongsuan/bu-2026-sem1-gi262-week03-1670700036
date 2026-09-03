using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class OOPPlayer : Character
{
    private InputAction moveAction;

    public void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        PrintInfo();
        GetRemainEnergy();
    }

    private void GetRemainEnergy()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();

        // call method Move(Vector2.up);
        if (moveAction.triggered)
        {
            Move(direction);
        }
    }

    public void Attack(OOPEnemy _enemy)
    {
        _enemy.energy -= attackPoint;
        Debug.Log(_enemy.name + " is energy " + _enemy.energy);
    }

    protected override void CheckDead()
    {
        base.CheckDead();
        if (energy <= 0)
        {
            Debug.Log("Player is Dead");
        }
    }
}
