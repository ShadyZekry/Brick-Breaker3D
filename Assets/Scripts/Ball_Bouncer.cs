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

        //freezing y axis
        transform.position = new Vector3(transform.position.x, 1, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = lastFrameVelocity.magnitude;

        rb.velocity = Vector3.Reflect(lastFrameVelocity.normalized, collision.contacts[0].normal) * velocity;
    }
}