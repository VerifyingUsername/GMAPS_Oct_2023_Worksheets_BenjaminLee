using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    // To calculate the magnitude of the 2 vectors to get distance
    public static float FindDistance(HVector2D p1, HVector2D p2)
    {
        return (p1 - p2).Magnitude();
    }
}

