using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject Player;
    public GameObject cam;
    public float speed;
    public Vector2 position;
    public Animator anim;
    public Quaternion rot;
    public Quaternion camrot;

    private void Start()
    {
        position = new Vector2(Player.transform.position.x, Player.transform.position.y);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rot = new Quaternion(Player.transform.rotation.x, 0, Player.transform.rotation.z, Player.transform.rotation.w);
            position = new Vector2(Player.transform.position.x + speed, Player.transform.position.y);
            Player.transform.SetPositionAndRotation(position, rot);
             
            anim.Play("walk");
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            position = new Vector2(Player.transform.position.x - speed, Player.transform.position.y);
            Player.transform.SetPositionAndRotation(position, Player.transform.rotation);
            
            anim.Play("walk");
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            rot = new Quaternion(Player.transform.rotation.x, 0, Player.transform.rotation.z, Player.transform.rotation.w);
            position = new Vector2(Player.transform.position.x + speed, Player.transform.position.y);
            Player.transform.SetPositionAndRotation(position, rot);
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (Player.transform.position.y <= 3.75)
            {
                rot = new Quaternion(Player.transform.rotation.x, 0, Player.transform.rotation.z, Player.transform.rotation.w);
                position = new Vector2(Player.transform.position.x, Player.transform.position.y + speed);
                Player.transform.SetPositionAndRotation(position, rot);

                anim.Play("walk");
            } 
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Player.transform.position.y >= 1.75)
            {
                position = new Vector2(Player.transform.position.x, Player.transform.position.y - speed);
                Player.transform.SetPositionAndRotation(position, Player.transform.rotation);

                anim.Play("walk");
            }
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {

            anim.Play("idle");
        }
        //y 1,75 3,75

    }
}
