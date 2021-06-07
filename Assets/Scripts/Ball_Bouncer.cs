using UnityEngine;

public class Ball_Bouncer : MonoBehaviour
{
    [SerializeField]
    private float velocity;
    private Vector3 lastFrameVelocity;
    private Rigidbody rb;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(velocity, 0, velocity);
    }

    private void Update()
    {
        lastFrameVelocity = rb.velocity;
        rb.velocity = rb.velocity.normalized * Mathf.Max(lastFrameVelocity.magnitude, velocity);
        
        // Eliminate any speed in Y-Axis (That caused the velocity to be static and it appears to be slow)
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        //freezing y axis
        transform.position = new Vector3(transform.position.x, 1, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = lastFrameVelocity.magnitude;
        Vector3 direction = Vector3.Reflect(lastFrameVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, velocity);
    }
}