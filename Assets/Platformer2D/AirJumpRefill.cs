using System;
using UnityEngine;

class AirJumpRefill : MonoBehaviour
{
    [SerializeField] bool destroyOnCollect = true;
    [SerializeField] float disableTime = 2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Platformer2DController pc = collision.GetComponent<Platformer2DController>();
        if (pc != null)
        {
            pc.RefillAirJump();

            if (destroyOnCollect)
                Destroy(gameObject);

            else
            {
                SetEnable(false);
                Invoke("SetEnable", disableTime);
                // Várunk
                SetEnable(true);
            }

        }
    }

    private void SetEnable(bool enable)
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
            renderer.enabled = enable;

        Collider2D collider = GetComponent<Collider2D>();

        if (collider != null)
            collider.enabled = enable;

    }
}