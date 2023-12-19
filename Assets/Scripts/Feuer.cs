using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feuer : Objects
{

    public GameObject myfire;
    public GameObject pointLight;


    // Start is called before the first frame update
    void Start()
    {
        /*
        myfire = GameObject.Find("my fire");
        pointLight = GameObject.Find("point Light");
        */
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void DoOnClick()
    {
        print("hit in Feuer");
        if (pointLight.activeSelf == true)
        {
            pointLight.SetActive(false);
            myfire.SetActive(false);
        }
        else
        {
            pointLight.SetActive(true);
            myfire.SetActive(true);
        }
    }
}