using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkB5 : MonoBehaviour
{
    [SerializeField] float a, b, c;

    [SerializeField] bool PitagorasNumbers;

    void OnValidate()
    {
     PitagorasNumbers  = c * c == a * a + b * b;
    }
}
