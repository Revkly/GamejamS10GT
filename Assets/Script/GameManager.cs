using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject sistemPause;
    public bool isPaused;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                SetUnpause();
            }
            else
            {
                SetPause();
            }
        }
    }

    public void SetPause()
    {
        sistemPause.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void SetUnpause()
    {
        sistemPause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
