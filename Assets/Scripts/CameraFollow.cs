using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public float yposition;


    void Update()
    {
        if (target.transform.position.y > yposition)
        {
            yposition = target.transform.position.y;
        }
            
      
        transform.position = new Vector3(0, yposition, -10);
    }
}
