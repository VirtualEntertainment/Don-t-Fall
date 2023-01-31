using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroygameobject : MonoBehaviour
{
    public GameObject player;
    public float location;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        location = player.GetComponent<player_movement>().yPosition;
      if (transform.position.y+25 < location)
        {
       
            Destroy(this.gameObject);
          
        }
    }
}
