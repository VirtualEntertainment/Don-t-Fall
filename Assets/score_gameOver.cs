using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.UI;
//using UnityEngine.UI;
using TMPro;

public class score_gameOver : MonoBehaviour
{
    public TMP_Text change;
    public GameObject score;
    public GameObject player;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        //player.SetActive(false);
        camera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        change.text = score.GetComponent<score>().score_count.ToString();
    }
}
