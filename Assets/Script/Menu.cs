using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    
    public Image OptionsImg;
    public int buildScene;
    public int sceneBack;
    
    public void mulaiGame()
    {
        print("switch scene to" + buildScene);
        SceneManager.LoadScene(buildScene, LoadSceneMode.Single);

        
    }
    
    public void backToMenu()
    {
        print("switch scene to" + sceneBack);
        SceneManager.LoadScene(sceneBack, LoadSceneMode.Single);
    }
    public void Options()
    {
        OptionsImg.gameObject.SetActive(true);
    }
    public void Exit()
    {
        OptionsImg.gameObject.SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }
}
