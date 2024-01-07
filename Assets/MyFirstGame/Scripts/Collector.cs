using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text uiText;

    int collectedValue;

    void Start()
    {
        UpdateUI();
    }
    void OnTriggerEnter(Collider other)
    {
        Collectable collectable =
            other.GetComponent<Collectable>();

        if (collectable != null)
        {
            collectedValue += collectable.GetValue();
            collectable.OnCollect();
            UpdateUI();
        }
    }
    void UpdateUI()
    {
        uiText.text = collectedValue.ToString();
    }
}
