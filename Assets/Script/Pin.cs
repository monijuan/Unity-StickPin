using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Rotator")
        {
            rb.velocity = Vector2.zero;
            transform.SetParent(col.transform);
            Score.scoreValue++;
            if(Random.Range(0f,1f)>0.5f)
            {
                col.GetComponent<Rotator>().speed += 15;
                col.GetComponent<Rotator>().speed *= -1;
            }
        }
        else if(col.tag=="Pin")
        {
            GameObject.FindObjectOfType<GM>().GameOver();
        }
    }
}
