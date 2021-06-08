using UnityEngine;

public class Ball_Catch : MonoBehaviour
{
    public bool isCaught = true;
    Rigidbody rb;
    [SerializeField]
    KeyCode launchKey;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float velocity = transform.GetComponent<Ball_Bouncer>().velocity;

        if (isCaught && Input.GetKey(launchKey))
        {
            isCaught = false;

            rb.velocity = new Vector3(velocity, 0, velocity);
            return;
        }

        if (isCaught)
        {
            GameObject bar = GameObject.Find("Bar");
            transform.position = new Vector3(bar.transform.position.x, 1, -2.9f);
        }


    }
}
