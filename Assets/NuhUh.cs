using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuhUh : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public GameObject test;

    public Vector2 direction, normalized;

    public float distance, PlayerTestDistance, TargetTestDistance, D;

    void Update()
    {
        Vector2 playerPosition = player.transform.position;
        Vector2 targetPosition = target.transform.position;
        Vector2 testPosition = test.transform.position;

        direction = target.transform.position - player.transform.position;
        distance = Mathf.Sqrt((playerPosition.x * targetPosition.x) + (playerPosition.y * targetPosition.y));
        normalized = direction / distance;

        playerPosition = player.transform.position;
        targetPosition = target.transform.position;
        testPosition = test.transform.position;
        
        PlayerTestDistance = Mathf.Sqrt((playerPosition.x * testPosition.x) + (playerPosition.y * testPosition.y));
        TargetTestDistance = Mathf.Sqrt((targetPosition.x * testPosition.x) + (targetPosition.y * testPosition.y));

        D = PlayerTestDistance + TargetTestDistance;
        
        if (D == distance)
        {
            Debug.Log("Is in between");
        }

        if (D != distance)
        {
            Debug.Log("Is not in between");
        }
    }

}
