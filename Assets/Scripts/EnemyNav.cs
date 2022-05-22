using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    NavMeshAgent nav;
    GameObject target;
    // Start is called before the first frame update
    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");
        nav.enabled = false;
    }
    private void Start()
    {
        //transform.position = GameObject.Find("SpawnPosition").transform.position;
        nav.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (nav.destination != target.transform.position)
            nav.SetDestination(target.transform.position);
        else
            nav.SetDestination(transform.position);
    }
}
