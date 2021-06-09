using UnityEngine;
using System.Collections.Generic;

public class Spawn_Boxes_Row : MonoBehaviour
{
    private Game_Variables gameVars;
    void Start()
    {
        gameVars = transform.root.GetChild(0).GetComponent<Game_Variables>();
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
        newRow.transform.parent = transform.parent;
        newRow.transform.localPosition = new Vector3(0, 1, 4);
        newRow.AddComponent<Box_Row_Movement>();
        positions.ForEach(delegate (float position)
        {
            Vector3 randomVector = new Vector3(position, 0, 0);
            GameObject newBox = Instantiate(gameVars.boxPrefab);
            newBox.transform.SetParent(newRow.transform);
            newBox.transform.localPosition = randomVector;
        });
    }

}
