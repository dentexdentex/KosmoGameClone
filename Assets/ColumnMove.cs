using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ColumnMove : MonoBehaviour
{
    public ObjectPool pool;
    void Start()
    {
        StartCoroutine(ColumnSpawn());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ColumnSpawn()
    {
        yield return new WaitForSeconds(0.1f);
        GameObject obj = pool.emptyObject[pool.emptyObject.Count - 1].gameObject;
        pool.emptyObject.Remove(obj);
        pool.useObject.Add(obj);
        obj.SetActive(true);
        obj.transform.position = new Vector3(obj.transform.position.x, 1.5f, obj.transform.position.z);
        obj.transform.DOMoveY(obj.transform.position.y - 3, 4f);
        yield return new WaitForSeconds(4f);

        pool.emptyObject.Add(obj);
        pool.useObject.Remove(obj);
        obj.SetActive(false);

        StartCoroutine(ColumnSpawn());
    }
}
