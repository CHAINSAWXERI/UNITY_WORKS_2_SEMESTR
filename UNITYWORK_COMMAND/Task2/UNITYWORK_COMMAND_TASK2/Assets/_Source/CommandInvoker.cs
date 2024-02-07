using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public class CommandInvoker
{
    private const int MaxCommands = 10;
    private Stack<ICommand> commandStack = new Stack<ICommand>();

    public void AddCommand(ICommand command)
    {
        commandStack.Push(command);
    }

    public void InvokeCommand(Vector2 position)
    {
        if (commandStack.Count > MaxCommands)
        {
            commandStack.Pop();
        }

        commandStack.Peek().Invoke(position);
    }

    public void Undo()
    {
        if (commandStack.Count > 1)
        {
            commandStack.Pop();
        }
    }
}

