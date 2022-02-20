using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void ExitGame()
    {
        Application.Quit();
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            ExitGame();
    }
}
