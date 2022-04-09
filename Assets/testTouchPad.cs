using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testTouchPad : MonoBehaviour
{
    public Rigidbody rigidbody;
    void Start()
    {
        if (rigidbody == null)
        {
            rigidbody = this.GetComponent<Rigidbody>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
