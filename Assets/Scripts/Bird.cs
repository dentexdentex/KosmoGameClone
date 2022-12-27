using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jump_spacing;
    public float left_right;
    Rigidbody2D rb; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (transform.position.y < 0)
                rb.velocity = Vector2.left * left_right + Vector2.up * jump_spacing;
            else
                rb.velocity = Vector2.left * left_right;


        }
        if (Input.GetMouseButtonDown(1))
        {


            if (transform.position.y < 0)
                rb.velocity = Vector2.right * left_right + Vector2.up * jump_spacing;

            else
                rb.velocity = Vector2.right * left_right;

        }
   

    }
    void OnCollisionEnter2D(Collision2D touch)
    {
        if (touch.gameObject.tag == "Pipe")
        {
        Time.timeScale = 0;
        }
    }

}
