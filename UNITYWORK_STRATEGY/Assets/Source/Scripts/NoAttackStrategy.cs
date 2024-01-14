using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAttackStrategy : IAttackStrategy
{
    public void PerformAttack()
    {
        Debug.Log("Вы не выполняете атаку");
    }
}
