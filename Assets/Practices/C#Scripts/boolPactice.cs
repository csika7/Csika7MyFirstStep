
using UnityEngine;

public class boolPactice : MonoBehaviour
{
    private void Start()
    {
        bool mySecondBool = true;

        mySecondBool = false;

        Debug.Log(mySecondBool);

        int a = 22, b = 66;

        bool b1 = a < b; //true
        bool b2 = a > b; // false

        bool b3 = a >= b; // false
        bool b4 = 77 <= b; // false

        bool b5 = b == -66; //false az == egyenlõség vizsgálat
        bool b6 = b != -66; // true a != egyenlõtlenség vizsgálat

        Debug.Log(b3);

        int ammo = 44;
        bool haveAmmo = ammo > 0;
        bool isCoolDownOver = true;

        bool canIShoot = haveAmmo && isCoolDownOver;
        //true
        Debug.Log(canIShoot);

        int airJumpCount = 1;
        bool isOnGround = false;
        bool canAirJump = airJumpCount < 1;

        bool canJump = isOnGround || canAirJump;
        //false
        Debug.Log(canJump);

        //----Logical Negate (negativizál)----

        bool canNotJump = !canJump;
        int minusA = -a;

        //----VAR----

        var iii = 4;  //int tipus
        var fff = 4.45f; //float
        var sss = "ferge"; //string
        var bbb = true; //bool

        Debug.Log(bbb);
    }
}
