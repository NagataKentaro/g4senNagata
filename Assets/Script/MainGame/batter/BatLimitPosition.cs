using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatLimitPosition : MonoBehaviour
{
    private const float _minX = -3.0f;
    private const float _maxX = -1.6f;

    private const float _maxY = 2.7f;
    private const float _minY = -0.5f;
    private void Update()
    {
        var pos = transform.position;

        // x軸方向の移動範囲制限
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;
    }
}