using UnityEngine;

public class Box_Break : MonoBehaviour
{
    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetTextureOffset("_MainTex", new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)));
    }

    void Update()
    {

    }
}
