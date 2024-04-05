using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass2 : MonoBehaviour
{
    void Awake()
    {
        ITetragon convexQuad = new ConvexQuadrilateral2(3f, 4f, 90f);
        Debug.Log("Convex Quadrilateral Perimeter: " + convexQuad.CountPerimeter());
        Debug.Log("Convex Quadrilateral Area: " + convexQuad.CountArea());

        ITetragon parallelogram = new Parallelogram2(3f, 4f, 30f);
        Debug.Log("Parallelogram Perimeter: " + parallelogram.CountPerimeter());
        Debug.Log("Parallelogram Area: " + parallelogram.CountArea());

        ITetragon rhombus = new Rhombus2(5f, 60f);
        Debug.Log("Rhombus Perimeter: " + rhombus.CountPerimeter());
        Debug.Log("Rhombus Area: " + rhombus.CountArea());

        ITetragon rectangle = new Rectangle2(3f, 5f);
        Debug.Log("Rectangle Perimeter: " + rectangle.CountPerimeter());
        Debug.Log("Rectangle Area: " + rectangle.CountArea());

        Square2 square = new Square2(4f);
        Debug.Log("Square Perimeter: " + square.CountPerimeter());
        Debug.Log("Square Area: " + square.CountArea());
    }
}

