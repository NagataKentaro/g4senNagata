using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPicherLev : MonoBehaviour
{
    public void OnClick(int num)
    {
        switch (num)
        {
            case 1:
                GameStart(1);
                break;
            case 2:
                GameStart(2);
                break;
            case 3:
                GameStart(3);
                break;
        }
    }

    void GameStart(int num )
    {
        SceneManager.LoadScene(num);
    }
}
