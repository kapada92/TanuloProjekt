using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_follow : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        Vector3 v = transform.position;
        v.x = player.position.x;
        transform.position = v;
    }
}
