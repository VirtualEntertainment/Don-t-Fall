using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    player_movement PlayerMovement;
    public GameObject player;
    public GameObject gameovercanvas;
    //public GameObject camera;
    public GameObject hitSFX;
    // Start is called before the first frame update
    void Awake()
    {
        gameovercanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<player_movement>().gameover == true)
        {
            hitSFX.SetActive(true);
            gameovercanvas.SetActive(true);
            player.transform.position = new Vector3(50,50, 50);
            player.transform.localScale = new Vector3(0.0979f, 0.1337f, 1);
        }
    }
}
