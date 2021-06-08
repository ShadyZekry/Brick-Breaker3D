using UnityEngine;

public class Bar_Movement : MonoBehaviour
{
    float xMovement;
    private Game_Variables gameVars;

    void Start()
    {
        gameVars = GameObject.Find("GameManager").GetComponent<Game_Variables>();
    }
    void Update()
    {
        xMovement = Input.GetAxis("Mouse X");
        if ((transform.position.x > 4 && xMovement > 0) || (transform.position.x < -4 && xMovement < 0)) return;
        transform.position += new Vector3(xMovement * Time.deltaTime * 50 * gameVars.barMovementSpeed, 0, 0);

        if (transform.position.x >= 4) transform.position = new Vector3(4, 1, transform.position.z);
        if (transform.position.x <= -4) transform.position = new Vector3(-4, 1, transform.position.z);
    }
}
