using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAttackStrategy : IAttackStrategy
{
    public void PerformAttack(Animator _animator)
    {
        Debug.Log("Вы не выполняете атаку");
        _animator.SetInteger("PlayAttack", 0);
    }
}
