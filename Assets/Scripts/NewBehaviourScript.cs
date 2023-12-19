using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : Objects
{
    new Rigidbody rigidbody;
    // Start is called before the first frame update
    public virtual void Start()
    {
        rigidbody = transform.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void DoOnClick()
    {
        print("stone called");
        rigidbody.freezeRotation = false;
        rigidbody.AddForce(transform.up * 100);
    }
}


