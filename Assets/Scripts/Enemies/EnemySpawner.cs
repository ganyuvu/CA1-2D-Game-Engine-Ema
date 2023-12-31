using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// used this video to help (https://www.youtube.com/watch?v=SELTWo1XZ0c&t=12s)
public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject enemy2Prefab;

    private float enemyInterval = 10f; //setting up number of secs for enemies to spawn
    private float enemy2Interval = 30f;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab)); //spawns zombies
       StartCoroutine(spawnEnemy(enemy2Interval, enemy2Prefab)); //spawns skeletons
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy) //function to spawn enemies
    {
        yield return new WaitForSeconds(interval); //waits for the interval
        GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity); //Creating a new GameObject and setting up the range where the enemies spawn in
        StartCoroutine(spawnEnemy(interval, enemy)); //ensures enemies spawn endlessly 
    }
}
