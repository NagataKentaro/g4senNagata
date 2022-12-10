using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterMove : MonoBehaviour
{
    
    private const float moveSpeed = 5.0f;

    // Start is called before the first frame update
    private Rigidbody2D rb2;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb2.velocity = new Vector2(0, rb2.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D) && rb2.velocity.x < 5.0f)
        {
            rb2.AddForce(new Vector2((moveSpeed-rb2.velocity.x)*100 * Time.deltaTime, 0),ForceMode2D.Impulse);
        }
        
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb2.velocity = new Vector2(0, rb2.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A) && rb2.velocity.x > -5.0f)
        {
            rb2.AddForce(new Vector2(-(moveSpeed+rb2.velocity.x)*100 * Time.deltaTime, 0),ForceMode2D.Impulse);
        }
        
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb2.velocity = new Vector2(rb2.velocity.x,0);
        }
        else if (Input.GetKey(KeyCode.W) && rb2.velocity.y < 5.0f)
        {
            rb2.AddForce(new Vector2(0, (moveSpeed-rb2.velocity.y)*100 * Time.deltaTime),ForceMode2D.Impulse);
        }
        
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb2.velocity = new Vector2(-rb2.velocity.x,0);
        }
        else if (Input.GetKey(KeyCode.S) && rb2.velocity.y > -5.0f)
        {
            rb2.AddForce(new Vector2(0, -(moveSpeed+rb2.velocity.y)*100 * Time.deltaTime),ForceMode2D.Impulse);
        }
    }
}
