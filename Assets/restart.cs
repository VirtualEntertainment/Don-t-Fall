using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void restartgame()
    {
        SceneManager.LoadScene(1);


    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);


    }
}
