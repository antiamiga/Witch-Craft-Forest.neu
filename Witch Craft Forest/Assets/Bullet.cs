using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float speed = 20f;
    public Rigidbody2D rb;
    private GameObject obstacle;
    public GameObject impactEffect;
    
    void Start()
    {
        obstacle = GameObject.FindGameObjectWithTag("Obstacle");
    
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Obstacle")
        {
            Instantiate(impactEffect, transform.position, transform.rotation);
        }
       
        }
       
    }


        
    
    

    



