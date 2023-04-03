using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float obstacleSpawnTime;
    [SerializeField] List<GameObject> Obstacles;
    [SerializeField] List<Transform> spawnPoints;

    void Start()
    {
        StartCoroutine(ObstacleRespawner());
    }

    IEnumerator ObstacleRespawner()
    {
        while (true)
        {
            SpawnRocks();
            yield return new WaitForSeconds(obstacleSpawnTime);
        }
        
    }
    private void SpawnRocks()
    {
        int[] cache = new int[4];
        cache[0] = Random.Range(0, spawnPoints.Count);
        Instantiate(Obstacles[Random.Range(0, Obstacles.Count)], spawnPoints[cache[0]].position, Quaternion.identity);
        
        cache[1] = Random.Range(0, spawnPoints.Count);
        while (cache[1] == cache[0])
        {
            cache[1] = Random.Range(0, spawnPoints.Count);
        }
        Instantiate(Obstacles[Random.Range(0, Obstacles.Count)], spawnPoints[cache[1]].position, Quaternion.identity);
        
        cache[2] = Random.Range(0, spawnPoints.Count);
        while (cache[2] == cache[1] || cache[2] == cache[0])
        {
            cache[2] = Random.Range(0, spawnPoints.Count);
        }

        Instantiate(Obstacles[Random.Range(0, Obstacles.Count)], spawnPoints[cache[2]].position, Quaternion.identity);
        while (cache[3] == cache[2] || cache[3] == cache[1] || cache[3] == cache[0])
        {
            cache[3] = Random.Range(0, spawnPoints.Count);
        }
        Instantiate(Obstacles[Random.Range(0, Obstacles.Count)], spawnPoints[cache[3]].position, Quaternion.identity);
    }
}
