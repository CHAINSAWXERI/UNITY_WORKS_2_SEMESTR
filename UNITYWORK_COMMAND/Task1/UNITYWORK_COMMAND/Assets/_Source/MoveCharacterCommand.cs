using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterCommand : ICommand
{
    private Rigidbody2D characterRigidbody;

    public MoveCharacterCommand(Rigidbody2D characterRigidbody)
    {
        this.characterRigidbody = characterRigidbody;
    }

    public void Invoke(Vector2 position)
    {
        Debug.Log("MOVE");
        characterRigidbody.MovePosition(position);
    }
}
