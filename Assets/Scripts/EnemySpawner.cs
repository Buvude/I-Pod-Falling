using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int obstacleSpawnTime;
    public List<GameObject> Obstacles;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObstacleSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ObstacleSpawner()
    {
        while (true)
        {
            Instantiate(Obstacles[Random.Range(0, Obstacles.Count)]);
            yield return new WaitForSeconds(obstacleSpawnTime);
        }
        
    }
}
