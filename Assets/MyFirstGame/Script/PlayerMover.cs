
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    //[SerializeField] Vector3 velocity;

    [SerializeField] float speed;
    [SerializeField] float speedMultiplier;
    [SerializeField] float angularSpeed;


    void Update()
    {

        /* float x = transform.position.x;
        x += 0.01f;

        transform.position = new Vector3(x, 0, 0); ez az elmozdulás*/

        bool up = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);

        float x = 0;
        if (left && right)
            x = 0;
        if (right)
            x = 1;
        if (left)
            x = -1;

        float y = 0;
        if (up)
            y += 1;
        if (down)
            y -= 1;

        Vector3 velocity = new Vector3(x, 0, y);
        velocity.Normalize();

        velocity *= speed;


        bool run = Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift);

        if (run)
            velocity *= speedMultiplier;

        velocity *= Time.deltaTime; // az elõzõõ update óta eltelt idõvel szorozva (framrate független

        transform.position += velocity;

        // forgatás

        Quaternion rot = transform.rotation;
        // rot.eulerAngles;
        // Vector3 euler  rot.eulerAngles;

        if (velocity != Vector3.zero) //ezzel nem fordul defaultba
        {
            // transform.rotation = Quaternion.LookRotation(velocity);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(velocity), angularSpeed * Time.deltaTime);

        }


    }
}
