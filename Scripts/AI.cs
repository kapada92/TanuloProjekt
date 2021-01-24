using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public float enemy_speed;
    public Vector2 v;
    public Animator anim;


    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            


            Debug.Log("A player belépett az enemy területére!");
        }
    }
}
