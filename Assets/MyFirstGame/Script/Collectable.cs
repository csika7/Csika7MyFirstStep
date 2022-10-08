
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class Collectable : MonoBehaviour
{
    [Min(1)] public int value = 1;
    [SerializeField] Bounds volume;

    public void TeleportToNext()
    {
        float x = Random.Range(volume.min.x, volume.max.x);
        float y = Random.Range(volume.min.y, volume.max.y);
        float z = Random.Range(volume.min.z, volume.max.z);



        Vector3 newPos = new Vector3(x, y, z);
        transform.position = newPos;
      
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(volume.center, volume.size);
    }
}
