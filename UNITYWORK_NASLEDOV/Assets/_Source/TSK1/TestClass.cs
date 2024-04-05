using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass : MonoBehaviour
{
    void Start()
    {
        Tetragon tetragon = new Tetragon(3f, 4f, 90f);
        Debug.Log("Tetragon Perimeter: " + tetragon.CountPerimeter());
        Debug.Log("Tetragon Area: " + tetragon.CountArea());

        Tetragon convexQuad = new ConvexQuadrilateral(3f, 4f, 90f);
        Debug.Log("Convex Quadrilateral Perimeter: " + convexQuad.CountPerimeter());
        Debug.Log("Convex Quadrilateral Area: " + convexQuad.CountArea());

        Tetragon parallelogram = new Parallelogram(3f, 4f, 30f);
        Debug.Log("Parallelogram Perimeter: " + parallelogram.CountPerimeter());
        Debug.Log("Parallelogram Area: " + parallelogram.CountArea());

        Tetragon rhombus = new Rhombus(5f, 60f);
        Debug.Log("Rhombus Perimeter: " + rhombus.CountPerimeter());
        Debug.Log("Rhombus Area: " + rhombus.CountArea());

        Rectangle rectangle = new Rectangle(3f, 5f);
        Debug.Log("Rectangle Perimeter: " + rectangle.CountPerimeter());
        Debug.Log("Rectangle Area: " + rectangle.CountArea());

        Tetragon square = new Square(4f);
        Debug.Log("Square Perimeter: " + square.CountPerimeter());
        Debug.Log("Square Area: " + square.CountArea());
    }
}
