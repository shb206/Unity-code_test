using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        //transform.position = GameObject.Find("SpawnPosition").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
        //
    }
}
