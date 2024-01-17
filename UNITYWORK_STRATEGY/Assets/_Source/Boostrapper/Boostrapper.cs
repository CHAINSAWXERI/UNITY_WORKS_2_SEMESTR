using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostrapper : MonoBehaviour
{
    [SerializeField] public Character character;

    void Start()
    {
        character.performer = new AttackPerformer(character);
        character._attack1Strategy = new Attack1Strategy();
        character._attack2Strategy = new Attack2Strategy();
        character._attack3Strategy = new Attack3Strategy();
    }

}
