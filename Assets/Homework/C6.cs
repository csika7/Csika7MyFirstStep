using UnityEngine;

public class C6 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;

    [SerializeField] int min;
    [SerializeField] int max;

    void OnValidate()

    {
 
        if (a > b)

        {
            min = b;
            max = a;
        }
        else
        {
            min = a;
            max = b;
        }

    }
}
