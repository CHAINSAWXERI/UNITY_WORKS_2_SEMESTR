using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostraper : MonoBehaviour
{
    [SerializeField] HotDogSO HotDog1;
    [SerializeField] HotDogSO HotDog2;
    void Start()
    {
        HotDog hotdog1 = new ClassicHotDog();
        hotdog1 = new OnionHotDog(hotdog1);
        HotDog1.Name = hotdog1.Name;
        HotDog1.Cost = hotdog1.GetCost();
        HotDog1.Weight = hotdog1.GetWeight();

        HotDog hotdog2 = new ClassicHotDog();
        hotdog2 = new PickleHotDog(hotdog2);
        HotDog2.Name = hotdog2.Name;
        HotDog2.Cost = hotdog2.GetCost();
        HotDog2.Weight = hotdog2.GetWeight();
    }
}
