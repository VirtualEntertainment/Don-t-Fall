using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.UI;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public TMP_Text change;
    public int score_count =-1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        change.text = score_count.ToString();
    }
}
