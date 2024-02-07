using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ComandListener : MonoBehaviour
{
    [SerializeField] public GameObject character;
    [SerializeField] public GameObject Thing;
    [SerializeField] public Vector2 SpawnPoint;

    private Vector2 mousePos;
    
    private CommandInvoker commandInvoker;

    private MoveCharacterCommand moveCharacterCommand;
    private SpawnPrefabCommand spawnPrefabCommand;

    private void Start()
    {
        spawnPrefabCommand = new SpawnPrefabCommand(Thing);
        moveCharacterCommand = new MoveCharacterCommand(character);
        commandInvoker = new CommandInvoker();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mousePos = Input.mousePosition;
            commandInvoker.ChangeCommand(moveCharacterCommand);
            commandInvoker.InvokeCommand(mousePos);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            commandInvoker.ChangeCommand(spawnPrefabCommand);
            commandInvoker.InvokeCommand(SpawnPoint);
        }
    }
}
