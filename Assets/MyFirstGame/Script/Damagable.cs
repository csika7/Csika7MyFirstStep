
using UnityEngine;
using TMPro;

public class Damagable : MonoBehaviour
{
    [SerializeField] int health = 10;
    [SerializeField] TMP_Text textField;

    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] MonoBehaviour turnOffAtDeath;

    private void Start()
    {
        UpdateText();
    }

    public void DoDamage(int value)
    {
        if (value < 0)
            return;

        health -= value;
        health = Mathf.Max(health, 0); // adtam neki egy min határt ne mehessen minuszba az élet

        if (health == 0)
        {
            gameOverCanvas.SetActive(true);

            turnOffAtDeath.enabled = false;
        }
        UpdateText();
    }

    void UpdateText()
    {
        if (textField != null)
            textField.text = $"HP: {health}";
    }
}
