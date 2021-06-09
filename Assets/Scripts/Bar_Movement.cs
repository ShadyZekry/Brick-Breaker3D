using UnityEngine;

public class Bar_Movement : MonoBehaviour
{
    float xMovement;
    private Game_Variables gameVars;
    private bool shouldMove;

    void Start()
    {
        gameVars = transform.root.GetChild(0).GetComponent<Game_Variables>();
    }
    void Update()
    {
        xMovement = Input.GetAxis("Mouse X");
        shouldMove = (transform.localPosition.x <= 4 && xMovement < 0) || (transform.localPosition.x >= -4 && xMovement > 0);
        if (!shouldMove) return;
        transform.localPosition += new Vector3(xMovement * Time.deltaTime * 50 * gameVars.barMovementSpeed, 0, 0);

        if (transform.localPosition.x >= 4) transform.localPosition = new Vector3(4, 1, transform.localPosition.z);
        if (transform.localPosition.x <= -4) transform.localPosition = new Vector3(-4, 1, transform.localPosition.z);
    }
}
