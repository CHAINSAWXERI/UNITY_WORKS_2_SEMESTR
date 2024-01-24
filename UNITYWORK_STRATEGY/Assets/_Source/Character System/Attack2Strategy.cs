using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2Strategy : IAttackStrategy
{
    public void PerformAttack(Animator _animator)
    {
        Debug.Log("Вы выполнили атаку 2");
        _animator.SetInteger("PlayAttack", 2);
    }
}
