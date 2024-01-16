using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    private IAttackStrategy currentStrategy;
    private AttackPerformer performer;

    private void Start()
    {
        performer = new AttackPerformer();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("1");
            PerformQAttack();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            PerformWAttack();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            PerformEAttack();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            PerformDAttack();
        }
    }

    public void PerformQAttack()
    {
        Debug.Log("2");
        performer.PerformAttack(1);
    }

    public void PerformWAttack()
    {
        performer.PerformAttack(2);
    }

    public void PerformEAttack()
    {
        performer.PerformAttack(3);
    }

    public void PerformDAttack()
    {
        performer.PerformAttack(4);
    }

    public void SetStrategy(IAttackStrategy strategy)
    {
        Debug.Log("5");
        currentStrategy = strategy;
        Debug.Log("6");
    }

    public void PerformAttack()
    {
        Debug.Log("8");
        currentStrategy.PerformAttack();
        Debug.Log("9");
    }
}

