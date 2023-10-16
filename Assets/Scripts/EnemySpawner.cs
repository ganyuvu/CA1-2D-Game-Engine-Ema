using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject enemy2Prefab;

    private float enemyInterval = 7f;
    private float enemy2Interval = 15f;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab)); 
       StartCoroutine(spawnEnemy(enemy2Interval, enemy2Prefab)); 
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
