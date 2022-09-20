
using UnityEngine;

public class HomeWorkA1 : MonoBehaviour
{
    [SerializeField] float number1, number2;

    [SerializeField] float summa;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float quotient;

    void OnValidate()
    {
        summa = number1 + number2;
        difference = number1 - number2;
        product = number1 * number2;
        quotient = number1 / number2;
    }
}
