using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2Strategy : IAttackStrategy
{
    public void PerformAttack()
    {
        Debug.Log("Вы выполнили атаку 2");
    }
}
