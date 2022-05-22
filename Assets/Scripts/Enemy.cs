using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int hp;
    private void Start()
    {
        hp = 10;
    }
    public void damegeHit()
    {
        hp -= 2;
    }
    public int getHp()
    {
        return hp;
    }
    public void initHp()
    {
        hp = 10;
    }
    private void Update()
    {
        if (hp == 0)
        {
            DestroyEnemy();
        }
        transform.Translate(Vector3.left * Time.deltaTime);
    }
    private void DestroyEnemy()
    {
        EnemySpawnPool.ReturnObject(this);
    }
}
