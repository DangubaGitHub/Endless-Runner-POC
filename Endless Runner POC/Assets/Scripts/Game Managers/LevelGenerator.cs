using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private Transform levelPart_1;
    [SerializeField] private Transform levelPart_2;
    [SerializeField] private Transform levelPart_3;
    [SerializeField] private Transform levelPart_4;
    [SerializeField] private Transform levelPart_5;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("End Position").position;
        SpawnLevelParts();
        SpawnLevelParts();
        SpawnLevelParts();
    }

    private void SpawnLevelParts()
    {
        Transform lastLevelPartTransform = SpawnLevelParts(lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("End Position").position;
    }

    private Transform SpawnLevelParts(Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }

    void Update()
    {
        
    }
}
