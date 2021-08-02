using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 boxsize = GetComponent<Collider>().bounds.extents;
        Debug.Log(boxsize.x);
        Debug.Log(boxsize.y);
        Debug.Log(boxsize.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
