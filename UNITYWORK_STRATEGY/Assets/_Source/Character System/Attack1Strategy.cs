using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1Strategy : IAttackStrategy
{
    public void PerformAttack()
    {
        Debug.Log("Вы выполнили атаку 1");
    }
}
