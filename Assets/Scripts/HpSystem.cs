using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpSystem : MonoBehaviour
{
    [SerializeField]
    private int hp;
    private void Start()
    {
        if (gameObject.name == "Enemy")
            hp = 10;
        else
            hp = 20;
    }
    public void damegeHit()
    {
        hp -= 2;
    }
    private void Update()
    {
        if (hp == 0)
            Destroy(gameObject);
    }
}
