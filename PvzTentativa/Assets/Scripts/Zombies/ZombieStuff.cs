using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ZombieStuff
{
    private int health;
    private float moveSpeed;
    private int damageOutput;
    private int difficultyCount;

    protected int GetHealth()
    {
        return health;
    }

    protected void SetHealth(int amount)
    {
        health = amount;
    }

    protected float GetMoveSpeed()
    {
        return moveSpeed;
    }

    protected void SetMoveSpeed(int amount)
    {
        moveSpeed = amount;
    }

    protected int GetDamageOutput()
    {
        return damageOutput;
    }

    protected int GetDifficultyCount()
    {
        return difficultyCount;
    }
}
