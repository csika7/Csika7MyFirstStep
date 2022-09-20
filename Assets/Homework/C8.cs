using UnityEngine;

public class C8 : MonoBehaviour
{
 [SerializeField] int number;

    void Start()
    {
     for (int i = 1; i <= number; i++)

        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;

            if (fizz && buzz)
                Debug.Log("FizzBuzz");
            else if (fizz)
                Debug.Log("Fizz");
            else if (buzz)
                Debug.Log("Buzz");
            else
                Debug.Log(i);

        }
    }
}
