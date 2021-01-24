using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Player;
    public Animator anim;
    public Transform Attack_point;
    public float attack_speed;
    public float attack_strength;
    public float attack_range;
    public LayerMask playerLayer;
    

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {

            anim.SetTrigger("Attack");
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.Play("idle");
        }
    }
}
