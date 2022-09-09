using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    GameController GC;

    public float moveSpeed;

    float moveX;
    float moveY;

    //GameController GC;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;
        
        //move in 4 directions and set bool for animator
        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            anim.SetBool("moving", true);
        }
        if (rb.velocity.x == 0 && rb.velocity.y == 0)
        {
            anim.SetBool("moving", false);
        }
        //turn the player to face left and right
        if (rb.velocity.x < 0)
        {
            transform.rotation = Quaternion.AngleAxis(180f, Vector3.up);            
        }
        if (rb.velocity.x > 0)
        {
            transform.rotation = Quaternion.AngleAxis(0f, Vector3.up);            
        }
        else if (rb.velocity.x == 0)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cash"))
        {
            GC.n_money += (int)Random.Range(1f, 10f);
            GC.UpdateCash();
            Destroy(collision.gameObject);
        }
    }

}
