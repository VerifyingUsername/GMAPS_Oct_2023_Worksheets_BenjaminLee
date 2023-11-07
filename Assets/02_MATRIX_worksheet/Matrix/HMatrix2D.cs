using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMatrix2D : MonoBehaviour
{
    public float[,] entries { get; set; } = new float[3, 3];

    public HMatrix2D()
    {
        // your code here
    }

    public HMatrix2D(float[,] multiArray)
    {
        // your code here
        //entries = new float[3, 3];

        for (int i = 0; i < 3; i ++)
        {
            for (int j = 0; j < 3; j++)
            {
                entries[i, j] = multiArray[i, j];
            }
        }

    }

    public HMatrix2D(float m00, float m01, float m02,
                     float m10, float m11, float m12,
                     float m20, float m21, float m22)
    {
        // First row
        // your code here
        entries[0, 0] = m00;
        entries[0, 1] = m01;
        entries[0, 2] = m02;

        // Second row
        // your code here
        entries[1, 0] = m10;
        entries[1, 1] = m11;
        entries[1, 2] = m12;

        // Third row
        // your code here
        entries[2, 0] = m20;
        entries[2, 1] = m21;
        entries[2, 2] = m22;
    }

    public static HMatrix2D operator +(HMatrix2D left, HMatrix2D right)
    {
        return new HMatrix2D(left.entries[0, 0] + right.entries[0, 0], left.entries[0, 1] + right.entries[0, 1], left.entries[0, 2] + right.entries[0, 2],
                             left.entries[1, 0] + right.entries[1, 0], left.entries[1, 1] + right.entries[1, 1], left.entries[1, 2] + right.entries[1, 2],
                             left.entries[2, 0] + right.entries[2, 0], left.entries[2, 1] + right.entries[2, 1], left.entries[2, 2] + right.entries[2, 2]);
        // your code here
    }

    public static HMatrix2D operator -(HMatrix2D left, HMatrix2D right)
    {
        // your code here
        return new HMatrix2D(left.entries[0, 0] - right.entries[0, 0], left.entries[0, 1] - right.entries[0, 1], left.entries[0, 2] - right.entries[0, 2],
                             left.entries[1, 0] - right.entries[1, 0], left.entries[1, 1] - right.entries[1, 1], left.entries[1, 2] - right.entries[1, 2],
                             left.entries[2, 0] - right.entries[2, 0], left.entries[2, 1] - right.entries[2, 1], left.entries[2, 2] - right.entries[2, 2]);     
    }

    public static HMatrix2D operator *(HMatrix2D left, float scalar)
    {
        // your code here
        return new HMatrix2D(left.entries[0, 0] * scalar, left.entries[0, 1] * scalar, left.entries[0, 2] * scalar,
                             left.entries[1, 0] * scalar, left.entries[1, 1] * scalar, left.entries[1, 2] * scalar,
                             left.entries[2, 0] * scalar, left.entries[2, 1] * scalar, left.entries[2, 2] * scalar);       
    }

    //// Note that the second argument is a HVector2D object

    public static HVector2D operator *(HMatrix2D left, HVector2D right)
    {
        // your code here
        return new HVector2D(left.entries[0, 0] * right.x + left.entries[0, 1] * right.y + left.entries[0, 2] * right.h, 
                             left.entries[1, 0] * right.x + left.entries[1, 1] * right.y + left.entries[1, 2] * right.h);
    }

    // Note that the second argument is a HMatrix2D object

    public static HMatrix2D operator *(HMatrix2D left, HMatrix2D right)
    {
        return new HMatrix2D
        (
            /* 
                00 01 02    00 01 02
                10 11 12    10 11 12
                20 21 22    20 21 22
            */

            /*For my own understanding and referall
                //first row, first column
                // (00 * 00 + 01 * 10 + 02 * 20)
                //first row, second column
                // (00 * 01 + 01 * 11 + 02 * 21)
                //first row, third column
                // (00 * 02 + 01 * 12 + 02 * 22)

                // second row, first column
                // (10 * 00 + 11 * 10 + 10 * 20)
                // (10 * 01 + 11 * 11 + 10 * 21)
                // (10 * 02 + 11 * 12 + 10 * 22)

                // second row, first column
                // (20 * 00 + 21 * 10 + 10 * 20)
                // (20 * 01 + 21 * 11 + 10 * 21)
                // (20 * 02 + 21 * 12 + 10 * 22)
            */


            // and so on for another 7 entries

            //First row
            left.entries[0, 0] * right.entries[0, 0] + left.entries[0, 1] * right.entries[1, 0] + left.entries[0, 2] * right.entries[2, 0],
            left.entries[0, 0] * right.entries[0, 1] + left.entries[0, 1] * right.entries[1, 1] + left.entries[0, 2] * right.entries[2, 1],
            left.entries[0, 0] * right.entries[0, 2] + left.entries[0, 1] * right.entries[1, 2] + left.entries[0, 2] * right.entries[2, 2],

            //Second row
            left.entries[1, 0] * right.entries[0, 0] + left.entries[1, 1] * right.entries[1, 0] + left.entries[1, 2] * right.entries[2, 0],
            left.entries[1, 0] * right.entries[0, 1] + left.entries[1, 1] * right.entries[1, 1] + left.entries[1, 2] * right.entries[2, 1],
            left.entries[1, 0] * right.entries[0, 2] + left.entries[1, 1] * right.entries[1, 2] + left.entries[1, 2] * right.entries[2, 2],

            //Third row
            left.entries[2, 0] * right.entries[0, 0] + left.entries[2, 1] * right.entries[1, 0] + left.entries[2, 2] * right.entries[2, 0],
            left.entries[2, 0] * right.entries[0, 1] + left.entries[2, 1] * right.entries[1, 1] + left.entries[2, 2] * right.entries[2, 1],
            left.entries[2, 0] * right.entries[0, 2] + left.entries[2, 1] * right.entries[1, 2] + left.entries[2, 2] * right.entries[2, 2]

            // Wrong error

            //left.entries[0, 0] * right.entries[0, 0] + left.entries[0, 1] * right.entries[1, 0] + left.entries[0, 2] * right.entries[2, 0],
            //left.entries[0, 0] * right.entries[0, 1] + left.entries[0, 1] * right.entries[1, 1] + left.entries[0, 2] * right.entries[2, 1],
            //left.entries[0, 0] * right.entries[0, 2] + left.entries[0, 1] * right.entries[1, 2] + left.entries[0, 2] * right.entries[2, 2],

            //left.entries[1, 0] * right.entries[1, 0] + left.entries[1, 1] * right.entries[1, 0] + left.entries[1, 2] * right.entries[2, 0],
            //left.entries[1, 0] * right.entries[1, 1] + left.entries[1, 1] * right.entries[1, 1] + left.entries[1, 2] * right.entries[2, 1],
            //left.entries[1, 0] * right.entries[1, 2] + left.entries[1, 1] * right.entries[1, 2] + left.entries[1, 2] * right.entries[2, 2],

            //left.entries[2, 0] * right.entries[2, 0] + left.entries[2, 1] * right.entries[1, 0] + left.entries[2, 2] * right.entries[2, 0],
            //left.entries[2, 0] * right.entries[2, 1] + left.entries[2, 1] * right.entries[1, 1] + left.entries[2, 2] * right.entries[2, 1],
            //left.entries[2, 0] * right.entries[2, 2] + left.entries[2, 1] * right.entries[1, 2] + left.entries[2, 2] * right.entries[2, 2]
        );
    }

    public static bool operator ==(HMatrix2D left, HMatrix2D right)
    {
        // your code here

        // r = rows, c = columns
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c ++)
            {
                if (left.entries[r, c] != right.entries[r, c])
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static bool operator !=(HMatrix2D left, HMatrix2D right)
    {
        // your code here
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                if (left.entries[r, c] == right.entries[r, c])
                {
                    return true;
                }
            }
        }

        return false;
    }

    //public override bool Equals(object obj)
    //{
    //    // your code here
    //}

    //public override int GetHashCode()
    //{
    //    // your code here
    //}

    //public HMatrix2D transpose()
    //{
    //    return // your code here
    //}

    //public float getDeterminant()
    //{
    //    return // your code here
    //}

    public void setIdentity()
    {
        // Original Code
        //for (int y = 0; y < 3; y++)
        //{
        //    for (int x = 0; x < 3; x++)
        //    {
        //        if (x == y)
        //        {
        //            entries[y, x] = 1;
        //        }
        //        else
        //        {
        //            entries[y, x] = 0;
        //        }
        //    }
        //}


        // Original code but in Ternary operator
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                entries[y, x] = (x == y) ? 1 : 0;
            }
        }
    }

    public void setTranslationMat(float transX, float transY)
    {
        // your code here
        setIdentity();
        entries[0, 2] = transX;
        entries[0, 2] = transY;
    }

    public void setRotationMat(float rotDeg)
    {
        // your code here
        setIdentity();
        float rad = rotDeg * Mathf.Deg2Rad;
        entries[0, 0] = Mathf.Cos(rad);
        entries[0, 1] = -Mathf.Sin(rad);
        entries[1, 0] = Mathf.Sin(rad);
        entries[1, 1] = Mathf.Cos(rad);
    }

    //public void setScalingMat(float scaleX, float scaleY)
    //{
    //    // your code here
    //}

    public void Print()
    {
        string result = "";
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                result += entries[r, c] + "  ";
            }
            result += "\n";
        }
        Debug.Log(result);
    }
}


