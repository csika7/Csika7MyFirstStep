
using UnityEngine;

public class C3 : MonoBehaviour
{
    [SerializeField] int number;

    [SerializeField] string text;

    void OnValidate()
    {
        text = "";

        for (int i = 0; i < number; i++)
        {
            text = text + i;

            if (i != number)
                text += ", ";
        }          
   
    }
}
