using UnityEngine;

public class Box_Row_Movement : MonoBehaviour
{
    public GameObject gameManager;
    private Vector3 targetPosition;
    private Game_Variables gameVars;

    void Start()
    {
        gameVars = GameObject.Find("GameManager").GetComponent<Game_Variables>();
        targetPosition = transform.position;
        float boxSpawnCooldown = gameVars.boxSpawnCooldown;
        InvokeRepeating("moveRow", boxSpawnCooldown, boxSpawnCooldown);
    }
    void Update()
    {
        if (transform.childCount == 0)
            Destroy(gameObject);
        if (transform.position.z > targetPosition.z)
            transform.Translate(0, 0, gameVars.boxesMovementSpeed * Time.deltaTime);
    }

    void moveRow()
    {
        // 1.3 movement_value * 5 steps = 6.5 final_place
        targetPosition = transform.position + new Vector3(0, 0, -1.3f);
        transform.LookAt(targetPosition);


        if (transform.position.z <= -1.2)   // we should've checked for -2.5 but there's a wrong internal calculation with float
            print("game over");
    }
}
