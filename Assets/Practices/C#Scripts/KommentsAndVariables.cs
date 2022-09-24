
using UnityEngine;

public class KommentsAndVariables : MonoBehaviour
{
    private void Start()

    //----KOMMENTEK FAJTÁI----

    //sorvégi komment
    /*két sor közötti komment*/
    /*Megbontott
     Több soros komment*/

    {
        //----Variables=Változók----

        /*Változók programozási elemek, 
          amiket szabadon hozhatunk létre 
          kódunk írása közben*/

        int egeszSzam; // Deklarate
        egeszSzam = 5; // Definiation
        egeszSzam = 34; // Change value
        egeszSzam = 3324; // Change value
        Debug.Log(egeszSzam);

        int a = 3 + 5; // 8
        int b = a - 11; // -3
        int c = a * b; // -24
        int d = a / 3; // 2

        float f1 = 45.76f; // lebegõpontos számok, tizedestörtek
        float f2 = 22, f3 = 32.4f, f4 = 45; //egy sorban is megadható az érték, ilyenkor elég vesszõ közé

        float sum = f1 + f2;
        float difference = f1 - f2;
        float product = 1 * f2;
        float rate = f1 / f2;

        //----alap mûveletek vegyesen----

        int i = 10;
        float f = 2.5f;

        var summa = i + f; //float tipus érték 12.5f
        var diff = i - f; // float tipus érték 7.5f
        var prod = i * f; // float tipus érték 25f
        var quotient = i / f; // float tipus érték 4f

        //----Negálás----

        int g = 6;
        float h = -77.7f;

        var gNeg = -i; // int tipus érték:-6
        var hNeg = -77.7f; // float tipus érték 77.7

        //----Modulo----

        int rateInt = 11 / 3; // 3 mivel az int levágja a tizedest csak ekrek értéket ad
        int moduloInt = 1 % 3; // 2 mivel a %-jeles osztás a maradvány értéket jeleníti meg

        float q2 = 63.5f / 10f; // eredmény 6.35
        float m2 = 63.5f % 10f; // erdmény 3.5 modulot ugyanúgy alkalmazza floaton is de nem csapja le a tizedest

        //----Kasztolás----

        float fff = 5; // Implicit casting azaz tizedestört egésszé alakít floatból int lesz
        int iii = (int) 5.5f; // explicit casting a fenti fordítotja

        //----Rövid Forma----

        a = a + 5;
        a += 5; //ez a fentebbi sor rövidítve

        a = a - 5;
        a -= 5;

        a = a * 5;
        a *= 5;

        a = a / 5;
        a /= 5;


        /* prefixes rövidítés*/

        ++a; //egyel növeli az értéket
        --a; // egyel csökkenti az értéket

        /*postfixes rövidítés*/

        a++;
        a--;
        /* A postfixes forma egy kicsit bonyolultabb, elsõként létrehoz egy átmeneti változót, amiben eltárolja az
        operandusa értékét, majd megnöveli egyel az operandust, végül visszaadja az átmeneti változót.*/

        Debug.Log(a);

        // ... és így tovább
    }
}
