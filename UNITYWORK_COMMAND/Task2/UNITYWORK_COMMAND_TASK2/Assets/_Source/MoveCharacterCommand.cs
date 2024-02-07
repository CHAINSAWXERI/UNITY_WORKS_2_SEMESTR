using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCharacterCommand : ICommand
{
    private GameObject prefab;
    private Vector2 OldPos;

    public MoveCharacterCommand(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public void Invoke(Vector2 position)
    {
        OldPos = position;
        Vector2 NewPos;
        prefab.transform.position = Camera.main.ScreenToWorldPoint(NewPos = new Vector2(position.x, position.y));
    }

    public void Undo()
    {
        prefab.transform.position = OldPos;
    }
}
