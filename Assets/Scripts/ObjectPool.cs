using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public GameObject poolObject;

    public List<GameObject> allObject;

    public List<GameObject> emptyObject;

    public List<GameObject> useObject;

    public int objectCount;

    void Start()
    {
        for (int i = 0; i < objectCount; i++)
        {
            GameObject lastObj = Instantiate(poolObject, transform.position, Quaternion.identity, transform);
            float randomX = Random.Range(-.35f, .35f);
            Vector3 newpos = new Vector3(randomX, 0, 0);
            lastObj.transform.position += newpos;
            allObject.Add(lastObj);
            lastObj.SetActive(false);
            emptyObject.Add(lastObj);
        }
    }

  
}
