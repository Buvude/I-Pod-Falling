using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    Touch touch;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
        }
        if (Input.touchCount >= 1)
        {
            if (touch.phase == TouchPhase.Began)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
