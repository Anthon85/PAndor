using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] KeyCode shootButton = KeyCode.Space;
    [SerializeField] GameObject bulletPrototype;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bulletPrototype);
            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = transform.rotation;
        }
    }
}
