using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public float close = 10.0f;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerDir = player.transform.position - transform.position;
        float playerDist = playerDir.magnitude;
        playerDir.Normalize();
        if (playerDist <= close)
        {
            //if player is close, chase player
            GetComponent<Rigidbody2D>().velocity = playerDir * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        GetComponent<Animator>().SetFloat("xInput", playerDir.x);
        GetComponent<Animator>().SetFloat("yInput", playerDir.y);
    }
}
