
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    /*a void Start() egy metódus,
     létezik több is de még csak ezt vettük,
    ez a program belépési pontja, a Start 
    automatikusan lefuttatja a akapcsos zárójelen belülit,
    ami a metódus törzse
     */
    private void Start()
    {
        Debug.Log("HelloWorld"); //ez a parancs írja ki a zárójelen belüli részt
        Debug.Log("Sziasztok");
        Debug.Log($"My name is {name}");
    }
    /*Ebben az esetben egy komponens 
      nem csak a Hello Word szövegetfogja kiírni, 
      hanem be is mutatkozik.*/
}

