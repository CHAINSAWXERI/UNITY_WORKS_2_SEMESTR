using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ClassicHotDog : HotDog
{
    public ClassicHotDog() : base("������������ ��� ���")
    {

    }
    public override int GetCost()
    {
        return 100;
    }
    public override int GetWeight()
    {
        return 10;
    }
}
