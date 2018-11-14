﻿using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    public float health = 100;

    public int reward = 25;

    public GameObject deathEffect;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = Waypoints.points[0];
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health < 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += reward;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        Destroy(gameObject);
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
         if (wavepointIndex >= Waypoints.points.Length-1)
         {
            EndPath();
            return;
         }

            wavepointIndex++;
            target = Waypoints.points[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }

}

