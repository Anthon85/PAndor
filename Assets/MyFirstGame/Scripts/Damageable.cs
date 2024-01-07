using TMPro;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] float startHealth = 100;


    [SerializeField] Color maxHealthColor = Color.green;
    [SerializeField] Color minHealthColor = Color.red;
    [SerializeField] AnimationCurve colorInterpolation;

   // [SerializeField] Gradient healthGradient;
    [SerializeField] TMP_Text textComponent;
    [SerializeField] Behaviour disableOnDeath;
    [SerializeField] GameObject enableOnDeath;


    float currentHealth;

    void Start()
    {
        currentHealth = startHealth;
        UpdateUI();

        textComponent.color = new Color(255, 255, 0);
    }

    public void AddDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            //Most haltunk meg
            //PlayerMover pm = GetComponent<PlayerMover>();
            if (disableOnDeath != null)
                disableOnDeath.enabled = false;

            if (enableOnDeath != null)
                enableOnDeath.SetActive(true);
        }


        UpdateUI();
    }

    private void UpdateUI()
    {

        textComponent.text = Mathf.RoundToInt(currentHealth).ToString();

        float rate = currentHealth / startHealth;
        float t = colorInterpolation.Evaluate(rate);

        textComponent.color = Color.Lerp(minHealthColor, maxHealthColor, t);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            currentHealth = startHealth;
    }
}
