
using UnityEngine;

public class PathMover : MonoBehaviour
{

    [SerializeField] Vector3 pointA, pointB;
    [SerializeField, Range(0,1)] float startPosition;
    [SerializeField] float speed;

    bool toA = false;


    private void OnValidate()

    {
        // transform.position = (pointA + pointB) / 2; //a+b/2 a vektor �rt�ke

        transform.position = Vector3.Lerp(pointA, pointB, startPosition); // line�ris mert liene�ris egyenes a kett� k�z�tt az �t, kisz�molja hogy a megadtott poziicioba helyezze a cuccot
    }

    void Update()

    {
        Vector3 target = toA ? pointA : pointB;

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position == target)
            toA = !toA;
    }

    private void OnDrawGizmos()

    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(pointA, 0.1f);
        Gizmos.DrawWireSphere(pointB, 0.1f);
        Gizmos.DrawLine(pointA, pointB);
    }
}
