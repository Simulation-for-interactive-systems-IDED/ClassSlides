using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MyVector2D
{
    public float X;
    public float Y;

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

    public void Draw()
    {
        Debug.DrawLine(Vector3.zero, new Vector3(X, Y));
    }

    public void Draw(MyVector2D customOrigin)
    {
        Debug.DrawLine(new Vector3(customOrigin.X, customOrigin.Y), new Vector3(customOrigin.X + X, customOrigin.Y + Y));
    }

    public MyVector2D Lerp(MyVector2D start, MyVector2D end, float t)
    {
        MyVector2D c = end.Resta(start);
        c = c.Escalar(t);
        MyVector2D result = start.Sum(c);
        return result;
    }

    //public MyVector2D Lerp(MyVector2D vector2D, float scale)
    //{

    //    return new MyVector2D((X*(1-scale) + (vector2D.X *scale)), (Y*(1-scale)+(vector2D.Y*scale)));
    //}

    public override string ToString()
    {
        return "(" + X + ", " + Y +")";
    }
}
