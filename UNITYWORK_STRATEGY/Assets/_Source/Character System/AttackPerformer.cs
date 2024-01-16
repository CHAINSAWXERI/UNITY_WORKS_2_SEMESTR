using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPerformer
{
    private Character character;

    public void PerformAttack(int attackType)
    {
        Debug.Log("3");
        if (attackType == 1)
        {
            Debug.Log("4");
            character.SetStrategy(new Attack1Strategy());
        }
        else if (attackType == 2)
        {
            character.SetStrategy(new Attack2Strategy());
        }
        else if (attackType == 3)
        {
            character.SetStrategy(new Attack3Strategy());
        }
        else
        {
            character.SetStrategy(new NoAttackStrategy());
        }
        Debug.Log("7");
        character.PerformAttack();
        Debug.Log("10");
    }
}