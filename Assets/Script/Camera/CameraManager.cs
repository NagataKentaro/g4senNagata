using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera followCamera;

    [SerializeField] private CinemachineVirtualCamera homeCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnFollow()
    {
        followCamera.Priority = 15;
        
    }

    void BackCamera()
    {
        followCamera.Priority = 10;
    }
}
