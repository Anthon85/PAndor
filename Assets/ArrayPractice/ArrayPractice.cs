using Unity.VisualScripting;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int arrayLength;
    [SerializeField] int max;

    [SerializeField] int[] array;
    [SerializeField] int[] array2;
    [SerializeField] int[] array3;
    [SerializeField] int[] array4;

    void OnValidate()
    {
        //1,2,3
        array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = i;
        }
        // 3, 2, 1
        array2 = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            array2[i] = i;
        }
        // 3, 6, 9
        array3 = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            array3[i] = (i + 1) * 3;
        }
        // 3, 6, 9 ..., max

        int length = max / 3;
        array4 = new int[length];

        for (int i = 0; i < length; i++)
        {
            array4[i] = (i + 1) * 3;
        }
    }
}
