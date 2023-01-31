using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameoverdestroy : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<player_movement>().gameover == true)
        {
            gameoverdestroyall();
        }
    }
    public void gameoverdestroyall()
    {

        Destroy(this.gameObject);
    }
}
