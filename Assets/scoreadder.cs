using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreadder : MonoBehaviour
{
    score Score;
    public bool islanded;
    [SerializeField] GameObject scoremanager;
    [SerializeField] GameObject player;
    [SerializeField] GameObject levelgenerator;
    [SerializeField] GameObject JumpSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        JumpSFX.SetActive(false);
        if (islanded==false)
        {
            levelgenerator.GetComponent<levelgenerator>().randomnumbergenerator();
            player.GetComponent<player_movement>().yJumpPosition = player.GetComponent<Rigidbody2D>().position.y;
            scoremanager.GetComponent<score>().score_count++;
            islanded = true;
            
        }
        player.GetComponent<player_movement>().jump();

    }


   
}
