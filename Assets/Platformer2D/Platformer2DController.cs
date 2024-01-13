using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Platformer2DController : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float horizontalSpeed = 2;
    [SerializeField] float jumpSpeed = 10;
    [SerializeField] int airJordan = 1;



    bool isGrounded = false;

    int airJumpBudget;

    private void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        Vector2 v = rigidbody.velocity;
        v.x = horizontalInput * horizontalSpeed;
        rigidbody.velocity = v;
    }

    void Update()
    {
        bool doJump = Input.GetKeyDown(KeyCode.Space);

        bool canJump = isGrounded || airJumpBudget > 0;

        if (doJump && canJump)
        {
            Vector2 v = rigidbody.velocity;
            v.y = jumpSpeed;
            rigidbody.velocity = v;

            if (!isGrounded)
                airJumpBudget--;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        airJumpBudget = airJordan;

    }

    public void RefillAirJump()
    {
        airJumpBudget = airJordan;
    }
}
