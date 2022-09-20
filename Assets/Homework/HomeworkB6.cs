
using UnityEngine;

public class HomeworkB6 : MonoBehaviour
{
   [SerializeField] int gold; 
   [SerializeField] int healthPoint;

   [SerializeField] bool canBuyMaceOfJerks;  
   [SerializeField] bool canBuyTrickyKnife;
   [SerializeField] bool canBuyVampireTooth;

    void OnValidate()
    {
        int goldToHealthPointRate = 5;

        int price = 10;
        canBuyMaceOfJerks = price <= gold || price * goldToHealthPointRate < healthPoint;

        price = 4;
        canBuyTrickyKnife = price <= gold || price * goldToHealthPointRate < healthPoint;

        price = 13;
        canBuyVampireTooth = price <= gold || price * goldToHealthPointRate < healthPoint;
        
    }
}
//sajnos én float-al csináltam, és egybevontam csak 2 serializedfield-el a bemenetit és a kimenetit, ami nem mûködött nem tudom miért