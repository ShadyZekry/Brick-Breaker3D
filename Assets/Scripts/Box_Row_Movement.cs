using UnityEngine;

public class Box_Row_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("moveRow", 10f, 10f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void moveRow()
    {
        // 1.3 movement_value * 5 steps = 6.5 final_place
        transform.position += new Vector3(0, 0, -1.3f);
    }
}
