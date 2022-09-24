
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;

    void Update()
    {
       transform.Rotate(0, angularSpeed * Time.deltaTime, 0);
    }
}
