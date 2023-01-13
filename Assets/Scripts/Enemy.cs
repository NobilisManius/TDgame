using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;

    private Transform target;

    private int wavepointIndex = 0;

    public int hp = 10;

    private void Start()
    {

        target = waypoints.points[0];

    }

    private void Update()
    {
        
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

        if (this.hp <= 0)
        {
            Destroy(gameObject);
            return;
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }


        wavepointIndex++;
        target = waypoints.points[wavepointIndex];

    }

    void DamageDealt(int dmg)
    {
        this.hp -= dmg;
    }

}
 