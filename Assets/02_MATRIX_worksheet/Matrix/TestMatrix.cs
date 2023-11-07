using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMatrix : MonoBehaviour
{
    private HMatrix2D mat = new HMatrix2D();
    // Start is called before the first frame update
    void Start()
    {
        mat.setIdentity();
        mat.Print();

        Question2();
    }

    void Question2()
    {
        HMatrix2D mat1 = new HMatrix2D(1, 2, 3, 4, 5, 6, 7, 8, 9);
        HMatrix2D mat2 = new HMatrix2D(9, 8, 7, 6, 5, 4, 3, 2, 1);
        HMatrix2D resultMat = new HMatrix2D();
        HVector2D vec1 = new HVector2D(2, 8);
        HVector2D resultVec = new HVector2D();

        resultMat = mat1 * mat2;

        // printing the grid results
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log(resultMat.entries[i, j]);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
