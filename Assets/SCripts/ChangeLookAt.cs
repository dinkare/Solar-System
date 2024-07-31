using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    // Update is called once per frame

    void Start()
    {
        if(target == null)
        {
            target = this.gameObject;
        }
    }
    private void OnMouseDown() {
        Lookat.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
    }

}
