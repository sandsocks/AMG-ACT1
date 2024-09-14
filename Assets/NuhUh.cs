using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuhUh : MonoBehaviour
{
    public GameObject player;
    public GameObject target;

    public Vector2 direction, normalized;

    public float distance;

    public bool isInBetween;
    void Update()
    {
        Vector2 playerPosition = player.transform.position;
        Vector2 targetPosition = target.transform.position;

        Vector2 pointToCheck = transform.position;

        isInBetween =  IsPointInBetween(playerPosition,targetPosition, pointToCheck);

        direction = target.transform.position - player.transform.position;
        distance = Mathf.Sqrt((direction.x * direction.x) + (direction.y * direction.y));
        normalized = direction / distance;
    }

    bool IsPointInBetween(Vector2 Player, Vector2 Target, Vector2 Test)
    {
        Vector2 PlayerTarget = Target - Player;
        Vector2 PlayerTest = Test - Player;
        Vector2 TargetTest = Test - Target;

        float distSqr = TargetTest.sqrMagnitude;
        float D = Vector2.Dot(PlayerTarget, TargetTest) / distSqr;

        if (D < 0)
        {
            Debug.Log("The point is not in between.");
            return false;
        }
        
        Debug.Log("The point is in between.");
        return true;
    }
}
