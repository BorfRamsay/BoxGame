using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform LevelPart_1;
    private void Awake()
    {
        Instantiate(LevelPart_1, new Vector3(8, -1), Quaternion.identity);

    }
}
