using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpBar : MonoBehaviour
{
    private GameObject enemyHpBar;
    //private float m_fSpeed = 5.0f;
    void Start()
    {
        enemyHpBar = GameObject.Find("Canvas/Slider");
    }

    // Update is called once per frame
    void Update()
    {
        enemyHpBar.transform.GetComponent<Slider>().value = gameObject.GetComponent<HpSystem>().getHp();
        enemyHpBar.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));
    }
}
