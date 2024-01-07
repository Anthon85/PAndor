using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Space rotationSpace = Space.Self;

    private void Update()
    {
        float rotateInAngle = angularSpeed * Time.deltaTime;
        transform.Rotate(0, rotateInAngle, 0, Space.World);

        /*
        Quaternion rotation = transform.rotation;
        Vector3 rotationInEuler = transform.rotation.eulerAngles;
        rotationInEuler += Vector3.up * angularSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotationInEuler);
        */
    }
}
