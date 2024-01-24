using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PickleHotDog : HotDogDecorator
{
    public PickleHotDog(HotDog p) : base(p.Name + ", � ��������", p)
    {

    }

    public override int GetCost()
    {
        return hotdog.GetCost() + 50;
    }

    public override int GetWeight()
    {
        return hotdog.GetWeight() + 110;
    }
}
