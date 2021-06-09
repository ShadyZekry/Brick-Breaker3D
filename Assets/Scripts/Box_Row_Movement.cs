using UnityEngine;

public class Box_Row_Movement : MonoBehaviour
{
    private Vector3 targetPosition;
    private Game_Variables gameVars;

    void Start()
    {
        gameVars = transform.root.GetChild(0).GetComponent<Game_Variables>();
        targetPosition = transform.localPosition;
        float boxSpawnCooldown = gameVars.boxSpawnCooldown;
        InvokeRepeating("moveRow", boxSpawnCooldown, boxSpawnCooldown);
    }
    void Update()
    {
        if (transform.childCount == 0)
            Destroy(gameObject);
        if (transform.localPosition.z > targetPosition.z)
            transform.Translate(0, 0, gameVars.boxesMovementSpeed * Time.deltaTime);
    }

    void moveRow()
    {
        // 1.3 movement_value * 5 steps = 6.5 final_place
        targetPosition = transform.position + new Vector3(0, 0, -1.3f);
        transform.LookAt(targetPosition);


        if (transform.localPosition.z <= -1.2)   // we should've checked for -2.5 but there's a wrong internal calculation with float
            GameObject.Find("Canvas").GetComponent<Game_Over>().gameOver();
    }
}
