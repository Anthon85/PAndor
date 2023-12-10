using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    [Space]
    [SerializeField] float circumference, area;

    // Start is called before the first frame update
    void OnValidate()
    {
        float pi = Mathf.PI;
        circumference = 2 * radius * pi;
        area = radius * radius * pi;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
