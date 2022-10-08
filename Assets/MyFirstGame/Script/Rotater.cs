
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;
    [SerializeField] float frequency = 1;
    [SerializeField] Space space;

    void Update()
    {
        float speed = Mathf.Sin(Time.time * frequency * 2 * Mathf.PI) * angularSpeed;
       transform.Rotate(0, angularSpeed * Time.deltaTime, 0, space);

    }
}
