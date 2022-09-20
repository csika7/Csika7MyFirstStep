
using UnityEngine;

public class HomeWorkA3 : MonoBehaviour
{
    [SerializeField] int n1, n2, n3, n4, n5;
    
    [SerializeField] float mean;

    void OnValidate()
    {
        mean = (n1 + n2 + n3 + n4 + n5) / 5f;
    }
}
