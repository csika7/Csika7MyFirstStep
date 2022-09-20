
using UnityEngine;

public class stringPractice : MonoBehaviour
{
    void Start()
    {
        string mySecondString = "This is a String";

        Debug.Log(mySecondString);

        string s1 = "Csika";
        string s2 = $"My name is {s1}, this GameObject is {name}"; // név és game object nevét húzza be
        
        Debug.Log(s2);

        int myAge = 45;
        float myHeight = 1.82f;

        string introduction = $"My name is {s1}, I am {myAge} and {myHeight} height.";
        
        Debug.Log(introduction);

        //----String összefûzés----

        string aaa = "Hello\t"; // tab a /t
        string bbb = "Good By";
        string ccc = aaa + bbb;

        Debug.Log(ccc);

        string ddd = "I am\n" + myAge; // \n a szóköz

        Debug.Log(ddd);

        //----String Átalakítás----

        int i = 3;
        int j = 5;
        string s = "S";

        string s3 = i + j + s;

        Debug.Log(s3);

        string s6 = i.ToString(); // "3"
        string s7 = 44.55f.ToString(); // "44.55"

        string s8 = s6 + s7; // "344.55"

        Debug.Log(s8);
    }

}
