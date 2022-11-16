using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalnextscene : MonoBehaviour
{
    public int SceneBuild;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Scene Entered");
        if(other.tag == "Player")
        {
            print("switch scene to" + SceneBuild);
            SceneManager.LoadScene(SceneBuild, LoadSceneMode.Single);
        }
    }
}
