using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudLogic : MonoBehaviour
{
    public GameObject cloud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D()
    {

        Invoke("collision", 0.4f);
    }

    void collision()
    {

       
        cloud.SetActive(false);
    }
}
