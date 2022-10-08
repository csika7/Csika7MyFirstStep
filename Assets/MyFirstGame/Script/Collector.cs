
using UnityEngine;
using TMPro;

class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text TextField;
    int collectedValue = 0;

    void Start()
    {
        UpdateText();
    }


    void OnTriggerEnter(Collider other)

    {
        Collectable c = other.GetComponent<Collectable>();


        if (c != null)
        {
            collectedValue += c.value;
            c.TeleportToNext();
            UpdateText();

        }

    }

    private void UpdateText()

    { 

            if (TextField != null)
                TextField.text = $"Score: {collectedValue}";
        }
    }


