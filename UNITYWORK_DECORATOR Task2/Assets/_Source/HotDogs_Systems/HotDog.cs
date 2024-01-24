using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class HotDog
{
    public string Name { get; protected set; }
    public HotDog(string n)
    {
        Name = n;
    }

    public abstract int GetCost();

    public abstract int GetWeight();
}
