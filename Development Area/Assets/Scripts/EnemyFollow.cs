using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Not used, replaced w/ AI Unity Tech.

public class EnemyFollow : MonoBehaviour {

    public float speed;
    public float stoppingDistance;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();    
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
