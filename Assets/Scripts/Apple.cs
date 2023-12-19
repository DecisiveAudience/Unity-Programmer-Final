using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Stone
{
    new Rigidbody rigidbody;
    // Start is called before the first frame update
    public override void Start()
    {
        rigidbody = transform.gameObject.GetComponent<Rigidbody>();
    }

    protected override void DoOnClick()
    {
        
        rigidbody.useGravity = true;
    }
}
