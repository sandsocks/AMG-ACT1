using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VectorsTest : MonoBehaviour
{
    public GameObject Player, Target, Test; 
    public Vector2 direction, normalized, pointInBetween;
    [SerializeField] 
    public float distance;
    private float PlayerX, PlayerY, TargetX, TargetY, TestX, TestY;
    
    void Update()
    {
       direction = Test.transform.position - Player.transform.position;

        PlayerX = Player.transform.position.x;
        PlayerY = Player.transform.position.y;
        TargetX = Target.transform.position.x;
        TargetY = Target.transform.position.y;
        TestX = Test.transform.position.x;
        TestY = Test.transform.position.y;

        distance = Mathf.Sqrt((direction.x * direction.x) + (direction.y * direction.y));
        normalized = direction / distance;

    }
}
