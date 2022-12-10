using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasePitcher : MonoBehaviour,IReduceBallCountable
{
    [SerializeField] private GameObject[] ball = new GameObject[4];
    private int ballCount = 10;

    protected int randomNum;
     void Start()
    {
        StartCoroutine(IntervalThrowBall());
    } 
     protected virtual void SelectBall()
    {
        
    }

    protected void ThrowBall(int num)
    {
        Instantiate(ball[num],this.transform.position,Quaternion.identity);
    }
    

    public void ReduceBallCount()
    {
        ballCount--;
        if (ballCount == 0)
        {
            Invoke(nameof(LoadScene),2.0f);
        }

        StartCoroutine(IntervalThrowBall());

    }
    void LoadScene()
    {
        SceneManager.LoadScene(4);
    }

    IEnumerator IntervalThrowBall()
    {
        yield return new WaitForSeconds(3.0f);
        SelectBall();
    }
}
