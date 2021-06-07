using UnityEngine;
using System.Collections.Generic;

public class Spawn_Boxes_Row : MonoBehaviour
{
    [SerializeField]
    GameObject boxPrefab;
    [SerializeField]
    float spawnFrom;
    [SerializeField]
    float spawnTo;
    [SerializeField]
    List<float> availablePositions;
    void Start()
    {
        // InvokeRepeating("SpawnRandom", 3f, 3f);
        SpawnRandom();
    }
    void SpawnRandom()
    {
        // We can't randomize without repeating, but we can remove randomly without repeating :"D

        // List<float> availablePositions = new List<float>() { -4.4f, -3.3f, -2.2f, -1.1f, 0f, 1.1f, 2.2f, 3.3f, 4.4f };

        int randomCounter = Random.Range(2, 6);
        for (int i = 0; i <= randomCounter; i++)
            availablePositions.RemoveAt(Random.Range(0, availablePositions.Count - 1));

        GameObject newRow = new GameObject("Row");
        availablePositions.ForEach(delegate (float position)
        {
            Vector3 randomVector = new Vector3(position, 1, 4);
            Instantiate(boxPrefab, randomVector, Quaternion.identity, newRow.transform);
        });
    }

}
