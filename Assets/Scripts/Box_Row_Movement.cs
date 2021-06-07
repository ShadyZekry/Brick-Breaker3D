using UnityEngine;

public class Box_Row_Movement : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("moveRow", 10f, 10f);
    }

    void moveRow()
    {
        // 1.3 movement_value * 5 steps = 6.5 final_place
        transform.position += new Vector3(0, 0, -1.3f);

        if (transform.position.z <= -1.2)   // we should've checked for -2.5 but there's a wrong internal calculation with float
            print("game over");
    }
}
