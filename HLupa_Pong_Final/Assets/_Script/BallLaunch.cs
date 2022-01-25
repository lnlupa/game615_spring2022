using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    public float velY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        LaunchBall();
    }

    // Update is called once per frame
    void Update()
    {
        velY = rb.velocity.y;

        if (velY == 0) 
        {
            rb.AddForce(new Vector3(0, Random.Range(-4f, -2f), 0).normalized * speed);
        }
    }

    public void LaunchBall() 
    { 
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, -5f);

        Vector3 forceVector = new Vector3(x, y, 0);

        rb.velocity = new Vector3(0, -1f, 0);
        rb.AddForce(forceVector.normalized * speed);
    }
}
