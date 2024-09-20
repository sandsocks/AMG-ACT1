using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VectorsTest : MonoBehaviour
/*{
    public GameObject Player, Target, Test; 
    public Vector2 direction, normalized, pointInBetween;
    public float distance;
    private float PlayerX, PlayerY, TargetX, TargetY;
    
    void Update()
    {
       direction = Test.transform.position - Player.transform.position;

        PlayerX = Player.transform.position.x;
        PlayerY = Player.transform.position.y;
        TargetX = Target.transform.position.x;
        TargetY = Target.transform.position.y;

        distance = Mathf.Sqrt((direction.x * direction.x) + (direction.y * direction.y));
        normalized = direction / distance;



    }
}*/
{
public GameObject Player, Target;
    public float PlayerTestMagnitude, PlayerTargetMagnitude;

    void Start()
    {
        Vector2 playerPosition = Player.transform.position;
        Vector2 targetPosition = Target.transform.position;
        Vector2 testPosition = transform.position;

        bool isInBetween = IsPointInBetween (playerPosition, targetPosition, testPosition);

        if (isInBetween)
        {
            Debug.Log("Is in between");
        }

        else
        {
            Debug.Log("Is not in between");
        }
    }

    bool IsPointInBetween (Vector2 player, Vector2 target, Vector2 test)
    {
        Vector2 PlayerTargetDirection = target - player;
        Vector2 PlayerTestDistance = test - player;

        float dotProduct = Vector2.Dot(PlayerTestDistance, PlayerTargetDirection);

        if (dotProduct > 0)
        {
            PlayerTargetMagnitude = Mathf.Sqrt((PlayerTargetDirection.x * PlayerTargetDirection.x) + (PlayerTargetDirection.y * PlayerTargetDirection.y));
            PlayerTestMagnitude = Mathf.Sqrt ((PlayerTestDistance.x * PlayerTestDistance.x) + (PlayerTestDistance. y * PlayerTestDistance.y));

            if (PlayerTestMagnitude <= PlayerTargetMagnitude)
            {
                return true;
            }
            
        }
        return false;
        
    }
}




