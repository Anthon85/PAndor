using UnityEngine;

public class Mean : MonoBehaviour
{
    [SerializeField] int a, b, c, d, e;
    [SerializeField] float mean;


    void OnValidate()
    {
        mean = (a + b + c + d + e) / 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
