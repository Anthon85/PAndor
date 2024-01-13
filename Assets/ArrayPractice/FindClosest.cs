using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class FindClosest : MonoBehaviour
{
    [SerializeField] float[] array;
    [SerializeField] float smallest;

    private void OnValidate()
    {
        if (array.Length == 0)
            return;

        smallest = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            float current = array[i];

            if (current < smallest)
                smallest = current;
        }
    }
}
