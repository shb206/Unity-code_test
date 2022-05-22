using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpSystem : MonoBehaviour
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
    private void Update()
    {
        if (hp == 0)
            Destroy(gameObject);
    }
}
