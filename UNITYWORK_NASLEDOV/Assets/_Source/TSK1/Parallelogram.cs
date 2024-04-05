using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallelogram : Tetragon
{
    public Parallelogram(float a, float b, float angle) : base(a, b, angle)
    {
    }

    public override float CountArea()
    {
        return sideA * sideB * Mathf.Sin(angle * Mathf.Deg2Rad);
    }
}