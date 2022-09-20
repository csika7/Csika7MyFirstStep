using UnityEngine;

public class onValidatePractice : MonoBehaviour
{

    [SerializeField, Min(0)] int intField; /// alt + lehuzom akkor beilleszt a copyt
    [SerializeField] float floatFild;
    [SerializeField] string stringField;
    [SerializeField] bool boolField;
    [Space]
    [SerializeField] int number;
    [SerializeField] bool isNuberEven;
    void OnValidate()
    {
        // Debug.Log(stringField);
        isNuberEven = number % 2 == 0;
    }
}