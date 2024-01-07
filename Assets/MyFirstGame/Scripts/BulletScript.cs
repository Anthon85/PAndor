using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxDistance = 10;
    [SerializeField] float maxLifetime = 2;

    Vector3 startPosition;
    float startTime;

    void Start()
    {
        startPosition = transform.position;
        startTime = Time.time;
    }



    private void Update()
    {
        //Movement Forward
        transform.position += transform.forward * speed * Time.deltaTime;

        //Delete
        float currentDistance = Vector3.Distance(startPosition, transform.position);
        float currentAge = Time.time - startTime;
        if(currentDistance >= maxDistance || currentAge > maxLifetime)
        {
            Destroy(gameObject); //Törlés
        }
    }
}
