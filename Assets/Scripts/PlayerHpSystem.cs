using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHpSystem : MonoBehaviour
{
    [SerializeField]
    private int hp;
    private float time = 0f;
    private void Start()
    {
        hp = 20;
    }
    public void damegeHit()
    {
        hp -= 4;
    }
    public int getHp()
    {
        return hp;
    }

    private void OnCollisionStay(Collision collision)

    {
        if(collision.gameObject.name == "Enemy" || collision.gameObject.name == "Enemy(Clone)")
        {
            this.time += Time.deltaTime;
            if (this.time > 3f) 
            {
                damegeHit();
                Debug.Log("1√ ");
                this.time = 0; 
            }
        }
    }

    private void Update()
    {
        if (hp == 0)
        {
            GameOverManager.instance.gameOverChange();
            Destroy(gameObject);
        }
            
    }
}
