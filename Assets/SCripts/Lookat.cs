using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{
    // Start is called before the first frame update
    static public GameObject target;
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(target){
            transform.LookAt(target.transform);
        }
    }
}
