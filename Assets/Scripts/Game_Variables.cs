using System.Collections.Generic;
using UnityEngine;

public class Game_Variables : MonoBehaviour
{
    [SerializeField]
    public GameObject boxPrefab;
    [SerializeField]
    public List<float> availablePositions;
    public float boxSpawnCooldown = 10;
    [SerializeField]
    public float boxesMovementSpeed = 5;
    [SerializeField]
    public float barMovementSpeed = 1;
    [SerializeField]
    public KeyCode launchKey;
    [SerializeField]
    public float ballVelocity;
    [SerializeField]
    public Vector3 barStartingPosition;
    [SerializeField]
    public float cameraRotationFactor;
    [SerializeField]
    public float cameraRotationRange = 7;
}
