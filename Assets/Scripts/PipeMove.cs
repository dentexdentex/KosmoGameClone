using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
