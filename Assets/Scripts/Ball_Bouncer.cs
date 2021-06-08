using UnityEngine;

public class Ball_Bouncer : MonoBehaviour
{
    private Vector3 lastFrameVelocity;
    private Rigidbody rb;
    private Game_Variables gameVars;

    private void Start()
    {
        gameVars = GameObject.Find("GameManager").GetComponent<Game_Variables>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        bool isCaught = transform.GetComponent<Ball_Catch>().isCaught;
        if (isCaught) return;

        lastFrameVelocity = rb.velocity;
        rb.velocity = rb.velocity.normalized * Mathf.Max(lastFrameVelocity.magnitude, gameVars.ballVelocity);

        // Eliminate any speed in Y-Axis (That caused the velocity to be static and it appears to be slow)
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        //freezing y axis
        transform.position = new Vector3(transform.position.x, 1, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = lastFrameVelocity.magnitude;
        Vector3 direction = Vector3.Reflect(lastFrameVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, gameVars.ballVelocity);
    }
}