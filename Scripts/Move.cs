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
    public GameObject panel;
    private void Start()
    {
        position = new Vector2(Player.transform.position.x, Player.transform.position.y);
    }

    void Update()
    {
        //Előre
        if (Input.GetKey(KeyCode.D))
        {
            rot = new Quaternion(Player.transform.rotation.x, 0, Player.transform.rotation.z, Player.transform.rotation.w);
            position = new Vector2(Player.transform.position.x + speed * Time.deltaTime, Player.transform.position.y);
            Player.transform.SetPositionAndRotation(position, rot);
            anim.SetTrigger("Walk");

        }
        //Hátra
        if (Input.GetKey(KeyCode.A))
        {
            position = new Vector2(Player.transform.position.x - speed * Time.deltaTime, Player.transform.position.y);
            Player.transform.SetPositionAndRotation(position, Player.transform.rotation);
            anim.SetTrigger("Walk");
        }
        //sprint
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            rot = new Quaternion(Player.transform.rotation.x, 0, Player.transform.rotation.z, Player.transform.rotation.w);
            position = new Vector2(Player.transform.position.x + speed * Time.deltaTime, Player.transform.position.y );
            Player.transform.SetPositionAndRotation(position, rot);
        }
        //Fel
        if (Input.GetKey(KeyCode.W))
        {
            if (Player.transform.position.y <= 3.75)
            {
                rot = new Quaternion(Player.transform.rotation.x, 0, Player.transform.rotation.z, Player.transform.rotation.w );
                position = new Vector2(Player.transform.position.x, Player.transform.position.y + speed * Time.deltaTime);
                Player.transform.SetPositionAndRotation(position, rot);
                anim.SetTrigger("Walk");
            } 
        }
        //Le
        if (Input.GetKey(KeyCode.S))
        {
            if (Player.transform.position.y >= 1.75)
            {
                position = new Vector2(Player.transform.position.x, Player.transform.position.y - speed * Time.deltaTime);
                Player.transform.SetPositionAndRotation(position, Player.transform.rotation);
                anim.SetTrigger("Walk");
            }
        }
        //Alap beállásra vissza
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            anim.Play("idle");
        }
        //y 1,75 3,75
        //Menü előhozása
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
        }
        
    }
}
