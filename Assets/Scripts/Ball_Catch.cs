using UnityEngine;

public class Ball_Catch : MonoBehaviour
{
    public bool isCaught = true;
    Rigidbody rb;
    private Game_Variables gameVars;
    void Start()
    {
        gameVars = transform.root.GetChild(0).GetComponent<Game_Variables>();
        rb = GetComponent<Rigidbody>();
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
            GameObject bar = transform.root.Find("Bar").gameObject;
            transform.localPosition = new Vector3(bar.transform.localPosition.x, 1, -2.9f);
        }


    }
}
