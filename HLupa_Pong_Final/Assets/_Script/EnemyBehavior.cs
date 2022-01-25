using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject ball;
    public float ballPos;
    public float ballVelY;
    public Rigidbody brb;

    public Vector3 newPosition;
    public float enemySpeed = 5;
    public float enemyY = 4;
    public float enemyZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        brb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        ballPos = ball.transform.position.x;
        ballVelY = brb.velocity.y;

        if (ballVelY >= 0)
        {
            newPosition = new Vector3(ballPos, enemyY, enemyZ);

            transform.position = Vector3.MoveTowards(transform.position, newPosition, enemySpeed * Time.deltaTime);

            //Debug.Log("it happened");
        }
        else 
        {
            newPosition = new Vector3(0, enemyY, enemyZ);

            transform.position = Vector3.MoveTowards(transform.position, newPosition, enemySpeed * Time.deltaTime);

            //Debug.Log("this happened");
        }
        
    }
}
