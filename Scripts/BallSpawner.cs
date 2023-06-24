using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public int ballCount;

    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-2,0), 1, Random.Range(-10,5));
        for (int i = 0; i < ballCount; i++)
        {
            Instantiate(ballPrefab, randomSpawnPosition, Quaternion.identity);
        }
        
    }
}
