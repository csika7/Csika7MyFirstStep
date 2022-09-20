
using UnityEngine;

public class HomeWorkA8 : MonoBehaviour
{
    [SerializeField] string a, b;

    void Start()
    {
        string temp = a;
        a = b;
        b = temp;
    }

}
