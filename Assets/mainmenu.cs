using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void startgame()
    {
        SceneManager.LoadScene(1);
    }
    public void credits()
    {
        SceneManager.LoadScene(2);


    }

    public void tutorial()
    {
        SceneManager.LoadScene(3);


    }

    public void end()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;

    }
}
