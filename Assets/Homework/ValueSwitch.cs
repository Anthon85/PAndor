using UnityEngine;

public class ValueSwitch : MonoBehaviour
{
    [SerializeField] string a, b;
    void Start()
    {
        string temp = a;
        a = b;
        b = temp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
