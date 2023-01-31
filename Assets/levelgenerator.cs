using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class levelgenerator : MonoBehaviour
{
    public GameObject grassprefab;
    public GameObject cloudsprefab;
    public GameObject bcprefab;
    public GameObject player;
    private Vector2 screenbounds;
    public int grasstocloud;
    public float ypos;
    public int cycles;
    public float Lastyposition;

    // Start is called before the first frame update
    void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        bcprefab.transform.position = new Vector2(-20, player.GetComponent<Rigidbody2D>().position.y);
        backrounddupe();
        backrounddupe();
        backrounddupe();
    }

    // Update is called once per frame
    void Update()
    {
      

        ypos = player.GetComponent<player_movement>().yJumpPosition;
        if (cycles==3)
        {
            bcprefab.transform.position = new Vector2(-20, player.GetComponent<Rigidbody2D>().position.y);
            cycles = 0;
            backrounddupe();
        }
    }
  
    
    public void randomnumbergenerator()
    {
        grassprefab.transform.position = new Vector2(-20, player.GetComponent<Rigidbody2D>().position.y);
        cloudsprefab.transform.position = new Vector2(-20, player.GetComponent<Rigidbody2D>().position.y);
        
        grasstocloud = Random.Range(0, 100);
        if (grasstocloud <= 87)
        {
            Invoke("spawngrass", 0.3f); 
        }
        else
        {
            Invoke("spawnclouds", 0.3f);
        }
    }
    public void spawngrass()
    {
        cycles++;
        GameObject a = Instantiate(grassprefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-2.3f, 2.15f), ypos +Random.Range(2.5f,4f),0.7f);
       
    }

    public void spawnclouds()
    {
        cycles++;
        GameObject a = Instantiate(cloudsprefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-2.3f, 2.15f), ypos + Random.Range(2.5f, 4f),0.7f);
        
    }
    public void backrounddupe()
    {
         
        GameObject a = Instantiate(bcprefab) as GameObject;
        a.transform.position = new Vector3(0,Lastyposition+7.5f,8);
        Lastyposition = a.transform.position.y;
    }
}
