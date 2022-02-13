using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   

    public void Lobbyscene()
    {
        SceneManager.LoadScene("LOBBYSCENE");
    }
    public void mainScreen()
    {
        SceneManager.LoadScene("GameDemo");
    }
    public void exitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
