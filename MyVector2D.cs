using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector2D
{
    float X;

    float Y;

    public MyVector2D(float x, float y)
    {
        X = x;
        Y = y;
    }

    public MyVector2D Sum(MyVector2D other)
    {
        return new MyVector2D(X + other.X, Y + other.Y);
    }

    public MyVector2D Resta(MyVector2D other)
    {
        return new MyVector2D(X - other.X, Y - other.Y);
    }

    public MyVector2D Escalar(float k)
    {
        return new MyVector2D(X * k, Y * k);
    }

    public float Magnitud()
    {
        return Mathf.Sqrt(Mathf.Pow(X, 2) + Mathf.Pow(Y, 2));
    }

    public MyVector2D Normalizar()
    {

        return new MyVector2D(X/Magnitud() , Y/Magnitud());
    }

    public MyVector2D lerp(MyVector2D vector2D, float scale)
    {

        return new MyVector2D((X*(1-scale)+ (vector2D.X*scale)), (Y*(1-scale)+(vector2D.Y*scale)));
    }

    public override string ToString()
    {
        return "(" + X + ", " + Y +")";
    }9
}
