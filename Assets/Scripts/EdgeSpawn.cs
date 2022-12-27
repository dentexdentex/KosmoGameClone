using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeSpawn : MonoBehaviour
{
    //public float speed;
    public float maxTime = 1;
    public float timer = 0;
    public GameObject pipe;
    public float h;

    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, 4, 0);
    }

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0 , 4, 0);
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;

    }

}
