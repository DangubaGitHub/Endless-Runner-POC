//using System;
using System.Collections;
using System.Collections.Generic;
//using Unity.Mathematics;
using UnityEngine;
//using Random = UnityEngine.Random;

//using Random = System.Random;

public class LevelGenerator : MonoBehaviour
{
    private const float DistanceBetweenPlayerAndLevelSpawn = 75f;

    [SerializeField] private GameObject player;
    
    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private List<Transform> easyLevelParts;
    [SerializeField] private List<Transform> mediumLevelParts;
    [SerializeField] private List<Transform> hardLevelParts;
    [SerializeField] private List<Transform> insaneLevelParts;

    private Vector3 lastEndPosition;
    private Transform chosenLevelPart;
    private Transform lastLevelPartTransform;
    private Transform levelPartTransform;

    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("End Position").position;
    }

    void Update()
    {
        if (Vector3.Distance(player.transform.position, lastEndPosition) < DistanceBetweenPlayerAndLevelSpawn)
        {
            SpawnLevelParts();
        }
    }

    private void SpawnLevelParts()
    {
        //chosenLevelPart = easyLevelParts[Random.Range(0, easyLevelParts.Count)];
        
        //chosenLevelPart = mediumLevelParts[Random.Range(0, mediumLevelParts.Count)];
        
        chosenLevelPart = hardLevelParts[Random.Range(0, hardLevelParts.Count)];

        
        lastLevelPartTransform = SpawnLevelParts(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("End Position").position;
    }

    private Transform SpawnLevelParts(Transform levelPart,Vector3 spawnPosition)
    {
        levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
