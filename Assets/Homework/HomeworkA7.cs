
using UnityEngine;

public class HomeworkA7 : MonoBehaviour
{
    [SerializeField] float radius;

    [SerializeField] float perimeter;
    [SerializeField] float area;

    void OnValidate()
    {
        float pi = 3.14f;

        perimeter = 2 * radius * pi;
        area = radius * radius * pi;
    }
}
