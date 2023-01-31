using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraYpos : MonoBehaviour
{
    public GameObject player;
    public float playerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position.y;
        transform.position = new Vector2(0, playerPos);
    }
}
