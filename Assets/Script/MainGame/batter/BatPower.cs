using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatPower : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            Rigidbody2D rb2 = col.gameObject.GetComponent<Rigidbody2D>();
            rb2.gravityScale = 0.3f;
        }
    }

}
