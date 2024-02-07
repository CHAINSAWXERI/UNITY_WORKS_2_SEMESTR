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
        commandInvoker.AddCommand(moveCharacterCommand);
        commandInvoker.AddCommand(moveCharacterCommand);
        commandInvoker.AddCommand(moveCharacterCommand);
        commandInvoker.AddCommand(moveCharacterCommand);
        commandInvoker.AddCommand(spawnPrefabCommand);
        commandInvoker.AddCommand(spawnPrefabCommand);
        commandInvoker.AddCommand(spawnPrefabCommand);
        commandInvoker.AddCommand(spawnPrefabCommand);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mousePos = Input.mousePosition;
            commandInvoker.InvokeCommand(mousePos);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            commandInvoker.InvokeCommand(SpawnPoint);
        }
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            commandInvoker.Undo();
        }
    }
}
