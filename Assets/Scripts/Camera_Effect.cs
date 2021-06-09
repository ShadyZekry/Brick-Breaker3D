using UnityEngine;

public class Camera_Effect : MonoBehaviour
{
    private float xMovement;
    private Game_Variables gameVars;
    private bool shouldRotate;
    void Start()
    {
        gameVars = transform.root.GetChild(0).GetComponent<Game_Variables>();
    }

    void Update()
    {
        xMovement = Input.GetAxis("Mouse X");
        float zAngle = transform.eulerAngles.z <= 180 ? transform.eulerAngles.z : transform.eulerAngles.z - 360;

        if (zAngle >= gameVars.cameraRotationRange) transform.eulerAngles = new Vector3(0, 0, gameVars.cameraRotationRange);
        if (zAngle <= -gameVars.cameraRotationRange) transform.eulerAngles = new Vector3(0, 0, -gameVars.cameraRotationRange);

        shouldRotate = (zAngle <= gameVars.cameraRotationRange && xMovement > 0) || (zAngle >= -gameVars.cameraRotationRange && xMovement < 0);
        if (!shouldRotate) return;

        float rotationValue = gameVars.cameraRotationFactor * xMovement * Time.deltaTime;
        transform.Rotate(0, 0, rotationValue);
    }
}
