using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour
{
    /*
    public float edge_velocity;
    Rigidbody2D r;
    void Start()
    {
        r.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            r.velocity = Vector2.up * edge_velocity;

        }
       
    }
    */
    public float edge_velocity;
    void Update()
    {
        transform.position += Vector3.up * edge_velocity * Time.deltaTime;
    }

}
