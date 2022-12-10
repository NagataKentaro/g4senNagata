using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Rigidbody2D rb2;

    private bool isHit;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        isHit = false;
    }

    // Update is called once per frameE
    void Update()
    {
        if (isHit)
        {
            return;
        }
        
        if (rb2.velocity.y < 10.0f)
        {
            rb2.AddForce(Vector2.down * ((1f-rb2.velocity.y)*0.05f * Time.deltaTime));
        }
        Debug.Log(isHit);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Bat"))
        {
            isHit = true;
        }
    }
}
