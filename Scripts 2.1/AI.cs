using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject enemy;
    public Transform player;
    public Animator anim;
    public Vector2 move;
    public float speed;

    void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.CompareTag("Player"))
        {
            
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.Play("idle");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (move.x != player.position.x) 
            {
                move.x = player.position.x + speed * Time.deltaTime;
            }
            if (move.y != player.position.y)
            {
                move.y = player.position.y + speed * Time.deltaTime;
            }
            rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
            Debug.Log(player.position);
            anim.Play("zombie_walk");
        }
    }

    private void Update()
    {
        
    }



}
