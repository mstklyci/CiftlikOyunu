using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject[] obj;


    void Start()
    {
        Clone();
    }

    void Clone()
    {
        Instantiate(obj[Random.Range(0,obj.Length)], this.gameObject.transform.position, Quaternion.identity);

        Invoke("Clone", 2);
    }
}