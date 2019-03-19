using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    private Rigidbody2D rb;

    float fall = 0;
    float fallspeed = 1;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Time.time - fall >= fallspeed)
            {
                rb.MovePosition(rb.position + new Vector2(0, -52));
                fall = Time.time;
            }

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    rb.MovePosition(rb.position + new Vector2(-52, 0));
                }

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    rb.MovePosition(rb.position + new Vector2(52, 0));
                }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                {
                     rb.MovePosition(rb.position + new Vector2(0, -52) * 0.5f);
                }
    }    
}
