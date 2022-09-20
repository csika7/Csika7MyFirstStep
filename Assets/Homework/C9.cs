using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C9 : MonoBehaviour
{
    [SerializeField] int baseNumber, exponent; 
    [SerializeField] int result;                

    void OnValidate()
    {
        result = 1;

        for (int i = 0; i < exponent; i++)
            result *= baseNumber;
    }
}
