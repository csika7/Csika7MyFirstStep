
using UnityEngine;

public class SerializedPractice : MonoBehaviour
{
    [SerializeField] string myName;
    [SerializeField] int age;
    [SerializeField] float height;
    [SerializeField] bool smoking;

    void Start()
    {
        string introduction = $"My name is {myName}. " +
                              $"I am {age} years old and {height} m height." +
                              $"Do I Smoke? {smoking}";

        Debug.Log(introduction);
    }
}
