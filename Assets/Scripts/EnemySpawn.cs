using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    public float spwanTime = 3f;
    public float curTime;

    // Update is called once per frame
    void Update()
    {
        if(curTime >= spwanTime)
        {
            SpawnEnemy();
        }
        curTime += Time.deltaTime;
    }
    public void SpawnEnemy()
    {
        curTime = 0;
        var enemy = EnemySpawnPool.GetObject();
        enemy.transform.position = transform.position;
    }
}
