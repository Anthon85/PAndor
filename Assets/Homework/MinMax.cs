using UnityEngine;

class MinMax : MonoBehaviour
{
    [SerializeField] int a, b;
    [SerializeField] int min, max;

    void OnValidate()
    {
     min = Mathf.Min(a, b);
     max = Mathf.Max(a, b);
    }
}
