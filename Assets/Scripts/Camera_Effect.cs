using UnityEngine;

public class Camera_Effect : MonoBehaviour
{
    private float xMovement;
    private Game_Variables gameVars;
    private bool shouldRotate;
    void Start()
    {
        gameVars = GameObject.Find("GameManager").GetComponent<Game_Variables>();
    }

    void Update()
    {
        xMovement = Input.GetAxis("Mouse X");
        float zAngle = transform.eulerAngles.z <= 180 ? transform.eulerAngles.z : transform.eulerAngles.z - 360;

        shouldRotate = (zAngle <= gameVars.cameraRotationRange && xMovement > 0) || (zAngle >= -gameVars.cameraRotationRange && xMovement < 0);
        if (!shouldRotate) return;

        float rotationValue = gameVars.cameraRotationFactor * xMovement;
        transform.Rotate(0, 0, rotationValue);
    }
}
