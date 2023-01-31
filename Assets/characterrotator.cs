using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterrotator : MonoBehaviour
{
    public GameObject player;

    public void flipleft()
    { 
        player.transform.localScale = new Vector3(-1, 1, 1);
    }

    public void flipright()
    {
        player.transform.localScale = new Vector3(1, 1, 1);
    }
  
}
