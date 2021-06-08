using UnityEngine;

public class Box_Break : MonoBehaviour
{
    bool isBrokenBox = false;
    [SerializeField]
    Material brokenMaterial;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name != "ball") return;
        if (isBrokenBox)
        {
            Destroy(gameObject);
            return;
        }

        Renderer rend = GetComponent<Renderer>();
        rend.material = brokenMaterial;
        rend.material.SetTextureOffset("_MainTex", new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)));
        isBrokenBox = true;
    }
}
