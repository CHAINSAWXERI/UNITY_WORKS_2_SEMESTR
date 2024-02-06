using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ComandListener : MonoBehaviour
{
    [SerializeField] public GameObject character;
    [SerializeField] public GameObject PositionPoint1;
    [SerializeField] public GameObject PositionPoint2;
    private Rigidbody2D characterRb;
    private CommandInvoker commandInvoker1;
    private CommandInvoker commandInvoker2;
    private MoveCharacterCommand moveCharacterCommand;
    private SpawnPrefabCommand spawnPrefabCommand;

    private void Start()
    {
        spawnPrefabCommand = new SpawnPrefabCommand(character);

        if (character.TryGetComponent<Rigidbody2D>(out Rigidbody2D RB))
        {
            characterRb = RB;
        }
        moveCharacterCommand = new MoveCharacterCommand(characterRb);

        commandInvoker1 = new CommandInvoker(spawnPrefabCommand);
        commandInvoker2 = new CommandInvoker(moveCharacterCommand);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            commandInvoker2.InvokeCommand(PositionPoint2.transform.position);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            commandInvoker1.InvokeCommand(PositionPoint2.transform.position);
        }
    }
}
