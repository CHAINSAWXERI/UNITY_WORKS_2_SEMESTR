using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MoveCharacterCommand : ICommand
{
    private GameObject prefab;
    //Vector2 OldPos

    public MoveCharacterCommand(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public void Invoke(Vector2 position)
    {
        //Vector2 NewPos;
        //Camera.main.ScreenToWorldPoint(NewPos = new Vector2(position.x, position.y));
        prefab.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(position.x, position.y, Camera.main.nearClipPlane));
    }
}
