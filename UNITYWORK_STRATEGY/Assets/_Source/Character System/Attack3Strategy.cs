using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack3Strategy : IAttackStrategy
{
    public void PerformAttack(Animator _animator)
    {
        Debug.Log("Вы выполнили атаку 3");
        _animator.SetInteger("PlayAttack", 3);
    }
}