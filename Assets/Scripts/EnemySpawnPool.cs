using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPool : MonoBehaviour
{
    public static EnemySpawnPool instance;
    [SerializeField]
    private GameObject enemyPrefab;
    private Queue<Enemy> poolingObjectQueue = new Queue<Enemy>();
    void Awake()
    {
        if (EnemySpawnPool.instance == null)
        {
            EnemySpawnPool.instance = this;
        }
        Initialize(10);
    }

    private Enemy CreateNewEnemy()
    {
        var newObj = Instantiate(enemyPrefab, transform).GetComponent<Enemy>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }
    private void Initialize(int count)
    {
        for(int i = 0; i < count; i++)
        {
            poolingObjectQueue.Enqueue(CreateNewEnemy());
        }
    }
    public static Enemy GetObject()
    {
        if(instance.poolingObjectQueue.Count > 0)
        {
            var obj = instance.poolingObjectQueue.Dequeue();
            obj.transform.SetParent(null);
            obj.gameObject.SetActive(true);
            return obj;
        }
        else
        {
            var newObj = instance.CreateNewEnemy();
            newObj.transform.SetParent(null);
            newObj.gameObject.SetActive(true);
            return newObj;
        }
    }
    public static void ReturnObject(Enemy enemy)
    {
        enemy.gameObject.SetActive(false);
        enemy.initHp();
        enemy.transform.SetParent(instance.transform);
        instance.poolingObjectQueue.Enqueue(enemy);
    }
}
