
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage = 1; //atrib�tum elemhez, v�ltoz�hoz oszt�jhoz extra inf�t ad, t�bb atributum van

    void OnTriggerEnter(Collider other)

    { 
        Damagable damagable = other.GetComponent<Damagable>();

        if(damagable != null)
        {
            // Debug.Log(damagable.name);

            damagable.DoDamage(damage);
        }
    }
}
