using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpBar : MonoBehaviour
{
    private GameObject playerHpBar;
    //private float m_fSpeed = 5.0f;
    void Start()
    {
        playerHpBar = GameObject.Find("Player/Canvas/HpBar");
    }

    // Update is called once per frame
    void Update()
    {
        playerHpBar.transform.GetComponent<Slider>().value = gameObject.GetComponent<PlayerHpSystem>().getHp();
    }
}
