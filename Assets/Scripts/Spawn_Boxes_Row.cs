using UnityEngine;
using System.Collections.Generic;

public class Spawn_Boxes_Row : MonoBehaviour
{
    private Game_Variables gameVars;
    void Start()
    {
        gameVars = GameObject.Find("GameManager").GetComponent<Game_Variables>();
        InvokeRepeating("SpawnRandom", 0.1f, gameVars.boxSpawnCooldown);
    }
    void SpawnRandom()
    {
        // We can't randomize without repeating, but we can remove randomly without repeating :"D

        //  -4.4f, -3.3f, -2.2f, -1.1f, 0f, 1.1f, 2.2f, 3.3f, 4.4f

        List<float> positions = new List<float>(gameVars.availablePositions);
        int randomCounter = Random.Range(2, 6);
        for (int i = 0; i <= randomCounter; i++)
            positions.RemoveAt(Random.Range(0, positions.Count - 1));

        GameObject newRow = new GameObject("Row");
        newRow.transform.position = new Vector3(0, 1, 4);
        newRow.AddComponent<Box_Row_Movement>().gameManager = gameObject;
        positions.ForEach(delegate (float position)
        {
            Vector3 randomVector = new Vector3(position, 1, 4);
            Instantiate(gameVars.boxPrefab, randomVector, Quaternion.identity, newRow.transform);
        });
    }

}
