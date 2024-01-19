using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1Strategy : IAttackStrategy
{
    public void PerformAttack(Animator _animator)
    {
        Debug.Log("Вы выполнили атаку 1");
        _animator.SetInteger("PlayAttack", 1);

    }
}
