using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour
{
    //prefab for instantiating apples
    public GameObject applePrefab;

    //speed at which the appleTree moves in meters per second
    public float speed = 1f;

    //distance where appleTree turns around
    public float leftAndRightEdge = 20f;

    //chance that the appleTree will change direction
    public float chanceToChangeDirection = 0.1f;

    //rate at which apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;

    void Start()
    {
        //dropping apples every second
    }
    void Update()
    {
        //basic movement and changing direction
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //changing direction
        if (pos.x < leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move left
        }
    }
    void FixedUpdate()
    {
        //changing direction randomly
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; //change direction
        }
    }
}
