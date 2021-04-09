using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void sceneSelect()
    {
        SceneManager.LoadScene("main");
    }
    // Update is called once per frame
    public void quitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
