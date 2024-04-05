using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallelogram2 : ITetragon
{
    protected float sideA;
    protected float sideB;
    protected float angle;

    public Parallelogram2(float a, float b, float angle)
    {
        sideA = a;
        sideB = b;
        this.angle = angle;
    }

    public float CountPerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public float CountArea()
    {
        return sideA * sideB * Mathf.Sin(angle * Mathf.Deg2Rad);
    }
}
