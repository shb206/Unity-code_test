using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    void Update()
    {
        if (!GameOverManager.instance.gameOverCheck() && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            SoundManager.instance.PlayFireSound();

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Enemy(Clone)" || hit.transform.name == "Enemy")
                {
                    Debug.Log("good shoot");
                    hit.transform.GetComponent<Enemy>().damegeHit();
                }
            }
        }
    }
}
