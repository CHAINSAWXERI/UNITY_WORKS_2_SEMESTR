using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class Character : MonoBehaviour
{
    private IAttackStrategy currentStrategy;
    public AttackPerformer performer;
    public Attack1Strategy _attack1Strategy;
    public Attack2Strategy _attack2Strategy;
    public Attack3Strategy _attack3Strategy;
    public NoAttackStrategy _noAttackStrategy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PerformQAttack();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            PerformWAttack();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            PerformEAttack();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            PerformDAttack();
        }
    }

    public void PerformQAttack()
    {
        performer.PerformAttack(_attack1Strategy); ///
    }

    public void PerformWAttack()
    {
        performer.PerformAttack(_attack2Strategy);
    }

    public void PerformEAttack()
    {
        performer.PerformAttack(_attack3Strategy);
    }

    public void PerformDAttack()
    {
        performer.PerformAttack(_noAttackStrategy); ///
    }

    public void SetStrategy(IAttackStrategy strategy)
    {
        currentStrategy = strategy;
    }

    public void PerformAttack()
    {
        currentStrategy.PerformAttack(); ///
    }
}

