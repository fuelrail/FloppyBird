using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        clone = Instantiate(objectPrefab, transform.position, Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
