
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
   // [SerializeField] float speed;
    [SerializeField] AnimationCurve speedOverDistance;

    void Update()
    {
        Vector3 velocity = target.position - transform.position;

        float targetDistance = velocity.magnitude;
        // vagy: float targetDistance2 = Vector3.Dot(target.position, transform.position);

        // velocity.Normalize();

        float speed = speedOverDistance.Evaluate(targetDistance);

        Vector3 direction = velocity.normalized;

        float stepLenght = Time.deltaTime * speed;

        if (targetDistance < stepLenght)
            stepLenght = targetDistance;

        // transform.position += velocity * speed;

        // transform.position += direction * stepLenght;

        transform.position = Vector3.MoveTowards(
                transform.position,
                target.position,
                Time.deltaTime * speed);

        if(direction != Vector3.zero)

        transform.rotation = Quaternion.LookRotation(direction);
    }
}
