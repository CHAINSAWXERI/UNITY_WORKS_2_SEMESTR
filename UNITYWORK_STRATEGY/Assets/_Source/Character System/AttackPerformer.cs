using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPerformer
{
    private Character _character;

    public AttackPerformer(Character character)
    {
        _character = character;
    }

    public void PerformAttack(IAttackStrategy attackStrategy)
    {
        _character.SetStrategy(attackStrategy);
        _character.PerformAttack();
    }
}