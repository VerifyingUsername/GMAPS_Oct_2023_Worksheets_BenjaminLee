using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//[Serializable]
public class HVector2D
{
    public float x, y;
    public float h;

    //HVector2D vec1 = new HVector2D(5f, 3f);
    //Vector2 vec2 = new Vector2(vec1.x, vec1.y);

    public HVector2D(float _x, float _y)
    {
        x = _x;
        y = _y;
        h = 1.0f;
    }

    public HVector2D(Vector2 _vec)
    {
        x = _vec.x;
        y = _vec.y;
        h = 1.0f;
    }

    public HVector2D()
    {
        x = 0;
        y = 0;
        h = 1.0f;
    }

    // public static HVector2D operator +( /*???*/)
    // {

    // }

    // public static HVector2D operator -(/*???*/)
    // {

    // }

    // public static HVector2D operator *(/*???*/)
    // {

    // }

    // public static HVector2D operator /(/*???*/)
    // {

    // }

    public float Magnitude()
    {      
        return Mathf.Sqrt(x * x + y * y);      
    }

    // public void Normalize()
    // {

    // }

    // public float DotProduct(/*???*/)
    // {

    // }

    // public HVector2D Projection(/*???*/)
    // {

    // }

    // public float FindAngle(/*???*/)
    // {

    // }

    public Vector2 ToUnityVector2()
    {
        return new Vector2(x, y);

        //return Vector2.zero; // change this
    }

    public Vector3 ToUnityVector3()
    {
        return new Vector3(x, y, 0);
        //return Vector2.zero; // change this
    }

    // public void Print()
    // {

    // }
}
