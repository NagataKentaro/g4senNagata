using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoLevPitcher : BasePitcher
{
    protected override void SelectBall()
    {
        int num = Random.Range(0, 3);
        Debug.Log(num);
        ThrowBall(num);
    }
}
