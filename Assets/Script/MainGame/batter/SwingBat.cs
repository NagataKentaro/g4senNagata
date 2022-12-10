using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SwingBat : MonoBehaviour
{
    private Rigidbody2D rb2;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        StartCoroutine(Swing());
    }

    IEnumerator Swing()
    {
        while (true)
        {
            yield return new WaitUntil(() => Input.GetMouseButton(0));
            rb2.bodyType = RigidbodyType2D.Kinematic;
            transform.DORotate(new Vector3(0, 0, 180), 0.8f);
            yield return new WaitForSeconds(0.8f);
            transform.DORotate(new Vector3(0, 0, 0), 1.5f);
            yield return new WaitForSeconds(1.7f);
            rb2.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}