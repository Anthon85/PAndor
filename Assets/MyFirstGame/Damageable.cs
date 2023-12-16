using TMPro;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField]  float startHealth = 100;
    [SerializeField] TMP_Text textComponent;

    float currentHealth;

    void Start()
    {
        currentHealth = startHealth;
        UpdateUI();
    }

    public void AddDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
            currentHealth = 0;

        UpdateUI();
    }

    private void UpdateUI()
    {
        textComponent.text = Mathf.RoundToInt(currentHealth).ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            currentHealth = startHealth;
    }
}
