using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float acceleration = 5;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] float gravity = 1;
    [SerializeField] float drag = 0.25f;


    Vector2 velocity = Vector2.zero;

    void FixedUpdate()
    {


        // Acceleration

        float forwardInput = Input.GetAxisRaw("Vertical");

        velocity += (Vector2)transform.up * forwardInput * acceleration * Time.fixedDeltaTime;
        velocity += Vector2.down * gravity * Time.fixedDeltaTime;  // Gravitáció
        velocity = Vector2.ClampMagnitude(velocity, maxSpeed);

        // Drag

        Vector2 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        //if (velocity.magnitude > maxSpeed)
        //{
        //    velocity.Normalize();
        //    velocity *= maxSpeed;
        //}

    }

    private void Update()
    {
        //Movement

        transform.position += (Vector3)velocity * Time.deltaTime;

        // Rotation

        float rotationInput = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, -rotationInput * angularSpeed * Time.deltaTime);

        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pew!");
        }
    }
}
