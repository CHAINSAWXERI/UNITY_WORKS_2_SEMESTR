using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    ICommand command;

    public void ChangeCommand(ICommand com)
    {
        command = com;
    }
    public void InvokeCommand(Vector2 position)
    {
        command.Invoke(position);
    }
}
