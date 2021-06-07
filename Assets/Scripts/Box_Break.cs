using UnityEngine;

public class Box_Break : MonoBehaviour
{
    [SerializeField]
    GameObject damagedBoxPrefab;
    void Start()
    {
        // Renderer rend = GetComponent<Renderer>();
        // rend.material.SetTextureOffset("_MainTex", new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name != "ball" && gameObject.name != "BrokernBox") return;

        Destroy(gameObject);
        GameObject gobj = GetComponent<GameObject>();
        gobj = Instantiate(damagedBoxPrefab, transform.position, Quaternion.identity, transform.parent);
        Renderer rend = GetComponent<Renderer>();
        // rend.material.SetTextureOffset("_MainTex", new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)));
    }
}
