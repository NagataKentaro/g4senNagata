using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundBall : MonoBehaviour
{
    private Rigidbody2D rb2;
    private Collider2D _collider;
    private GameObject _pitcher;
    private GameObject _textParent;
    private float fryingDistance;

    private GameObject camera;
    private bool isChase = false;
    void Start()
    {
        camera = GameObject.Find("Main Camera");
        rb2 = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
        _pitcher = GameObject.Find("Pitcher");
        _textParent = GameObject.Find("TextParent");
        StartCoroutine(OnGround());
    }

    void Update()
    {
        if (this.transform.position.y > 11 && this.transform.position.x is > -30 and < 30)
        {
            var position = transform.position;
            camera.transform.position = new Vector3(position.x,position.y,20);
        }
    }
    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator OnGround()
    {
        yield return new WaitForSeconds(3.0f);
        yield return new WaitUntil(() => rb2.velocity.y < 0);
        rb2.velocity = Vector2.zero;
        rb2.gravityScale = 0.0f;
        _collider.isTrigger = true;
        _pitcher.GetComponent<IReduceBallCountable>().ReduceBallCount();
        _textParent.GetComponent<IReduceBallCountable>().ReduceBallCount();
        MeasureDistance();
        yield return new WaitForSeconds(1.0f);
        camera.transform.position = new Vector3(0, 5, 20);
        Destroy(this.gameObject);
    }

    void MeasureDistance()
    {
        Vector2 pos = this.transform.position;
        float distance = Mathf.Sqrt(Mathf.Pow(pos.y, 2)) / Mathf.Sqrt(Mathf.Pow(pos.x, 2));
        if (pos.y > 0 && distance > 0.775f)
        {
            fryingDistance = Vector2.Distance(pos, Vector2.zero);
            _textParent.GetComponent<ISendDistancable>().Distance(fryingDistance);
        }
    }
}