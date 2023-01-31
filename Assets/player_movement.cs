using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float jumpForce = 1000;
    public float steerForce = 200;
    public float yPosition ;
    public float yJumpPosition;
    public bool gameover;
    float movementInput;
    private Rigidbody2D rb;
    public GameObject player;
    public GameObject score;
    public GameObject jumpSFX;
    // Start is called before the first frame update
    void Awake()
    {
        
        yJumpPosition = -5;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up;


        rb.AddForce(transform.up * jumpForce);
    }

    // Update is called once per frame
   public void Update()
    {
        yPosition = GetComponent<Rigidbody2D>().position.y;
        if (yPosition < yJumpPosition-1.5f)
        {
            gameover = true;

        }
       movementInput=Input.GetAxisRaw("Horizontal");

        if (movementInput > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * steerForce);
            score.GetComponent<characterrotator>().flipleft();
       
        }

            if (movementInput < 0)
        {
            GetComponent<Rigidbody2D>().AddForce(-transform.right * steerForce);
            score.GetComponent<characterrotator>().flipright();

        }
    }
    

   public void jump ()
    {
        jumpSFX.SetActive(true);
        rb.velocity = Vector2.up;
       
       
        rb.AddForce(transform.up * jumpForce);
    }
    
}
