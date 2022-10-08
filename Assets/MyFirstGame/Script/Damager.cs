
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage = 1; //atribútum elemhez, változóhoz osztájhoz extra infót ad, több atributum van

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
