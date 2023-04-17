using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -3.52f;
    public static float rightside = 3.41f;
    public float internalLeft;
    public float internalReft;

    void Update()
    {
        internalLeft = leftSide;
        internalReft = rightside;

    }
}
