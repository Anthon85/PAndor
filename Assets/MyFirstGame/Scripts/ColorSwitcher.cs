using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Serialization;

class ColorSwitcher : MonoBehaviour
{
    [SerializeField] new Light light;
    [SerializeField] Gradient colors;
    //[SerializeField] float frequency;

    [SerializeField] AnimationCurve curve;

    void Update()
    {
        /*
        float scaledTime = Time.time * frequency;
        float t = scaledTime % 1;
        if (((int)scaledTime) % 2 == 1)
        {
            t = 1 - t;
        }
        */
        float t = curve.Evaluate(Time.time);
        light.color = colors.Evaluate(t);
    }

}
