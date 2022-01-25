using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -7.5f) 
        {
            transform.Translate(new Vector3(-1, 0, 0) * playerSpeed);
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x < 7.5f)
        {
            transform.Translate(new Vector3(1, 0, 0) * playerSpeed);
        }
    }
}
