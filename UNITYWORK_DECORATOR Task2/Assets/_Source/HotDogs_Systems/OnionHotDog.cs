using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class OnionHotDog : HotDogDecorator
{
    public OnionHotDog(HotDog p) : base(p.Name + ", с Ћуком", p)
    {

    }

    public override int GetCost()
    {
        return hotdog.GetCost() + 30;
    }

    public override int GetWeight()
    {
        return hotdog.GetWeight() + 70;
    }
}
