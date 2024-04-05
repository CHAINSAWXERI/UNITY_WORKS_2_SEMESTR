using UnityEngine;
using System;

public class Tetragon
{
    protected float sideA;
    protected float sideB;
    protected float angle;

    public Tetragon(float a, float b, float angle)
    {
        sideA = a;
        sideB = b;
        this.angle = angle;
    }

    public virtual float CountPerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public virtual float CountArea()
    {
        return sideA * sideB * Mathf.Sin(angle * Mathf.Deg2Rad);
    }
}