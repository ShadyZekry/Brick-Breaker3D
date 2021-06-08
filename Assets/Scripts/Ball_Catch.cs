using UnityEngine;

public class Ball_Catch : MonoBehaviour
{
    public bool isCaught = true;
    Rigidbody rb;
    private Game_Variables gameVars;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameVars = GameObject.Find("GameManager").GetComponent<Game_Variables>();
    }
    void Update()
    {
        float velocity = gameVars.ballVelocity;

        if (isCaught && Input.GetKey(gameVars.launchKey))
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
