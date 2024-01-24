using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class HotDogDecorator : HotDog
{
    protected HotDog hotdog;
    public HotDogDecorator(string n, HotDog hd) : base(n)
    {
        hotdog = hd;
    }
}
