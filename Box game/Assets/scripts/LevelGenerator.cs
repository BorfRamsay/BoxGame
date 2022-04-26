using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform LevelPart_Start;
    [SerializeField] private Transform LevelPart_1;
    private void Awake()
    {

        Transform lastLevelPartTransform;
        lastLevelPartTransform = SpawnLevelPart(LevelPart_Start.Find("EndPosition").position);
        lastLevelPartTransform = SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
        lastLevelPartTransform = SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);



        SpawnLevelPart(lastLevelPartTransform.Find("EndPosition").position);
       
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
       Transform levelPartTransform = Instantiate(LevelPart_1, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
