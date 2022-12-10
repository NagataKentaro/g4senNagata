using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InputQ());
    }

    IEnumerator InputQ()
    {
        yield return new WaitUntil(() => Input.GetKey(KeyCode.Q));
        Application.Quit();
    }
}
